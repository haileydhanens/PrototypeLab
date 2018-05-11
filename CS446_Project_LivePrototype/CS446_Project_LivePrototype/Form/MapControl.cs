using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CS446_Project_LivePrototype
{
    public enum MouseDragState
    {
        Map,
        Token
    }

    public partial class MapControl : UserControl
    {
        public static readonly int MAX_GRID_THICKNESS = 6;
        public static readonly int MIN_GRID_SCALE_FACTOR = 10;
        public static readonly int MAX_GRID_SCALE_FACTOR = 25;
        public static readonly int MIN_GRID_SCALE = calcGridScale(MIN_GRID_SCALE_FACTOR);
        public static readonly int MAX_GRID_SCALE = calcGridScale(MAX_GRID_SCALE_FACTOR);
        public static readonly int SELECT_TIME_FRAME = 250;
        public static readonly float GRID_SHIFT_STEP = 0.1f;
        public static readonly float ZOOM_STEP = 1.25f;
        public static readonly float PAN_STEP = 0.1f;
        public static readonly float MAX_ZOOM = (float)Math.Pow(ZOOM_STEP, 8);
        public static readonly float MIN_ZOOM = (float)Math.Pow(ZOOM_STEP, -4);

        private readonly object drawMutex = new object();
        private GameState gameState;
        private TokenHoverToolTip tokenHoverToolTip;
        private MapToken draggedToken = null;
        private MapToken rightClickedToken = null;
        private MouseDragState mouseDragState;
        private Point mouseDownPos;
        Stopwatch mouseDownTimer = new Stopwatch();
        private bool leftMouseDown = false;
        private bool redrawNeeded = false;
        private bool tokenSnapToGrid = false;
        private bool showTokenLabels = true;
        private Image mapImage = null;
        private Image mapImageSized = null;
        private int gridAlpha = 255;
        private int gridThickness = 1;
        private int gridScale = MIN_GRID_SCALE;
        private float gridHorzOffset = 0.0f;
        private float gridVertOffset = 0.0f;
        private float viewZoom = 1.0f;
        private float viewPosX = 0.0f;
        private float viewPosY = 0.0f;

        public MapControl(GameState gameState)
        {
            InitializeComponent();

            this.gameState = gameState;
            this.ResizeRedraw = true;
            this.tokenHoverToolTip = new TokenHoverToolTip();
            this.tokenHoverToolTip.SetToolTip(this, "Tooltip");
            this.tokenHoverToolTip.Active = false;
            this.tokenHoverToolTip.ShowAlways = true;
            this.tokenHoverToolTip.ReshowDelay = 0;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            gameState.ActiveTokens.MapTokenAddedRemovedEvent += ActiveTokens_MapTokenAddedRemovedEvent;

            CenterViewOnMap();
        }

        private void ActiveTokens_MapTokenAddedRemovedEvent(object sender, MapTokenAddedRemovedEventArgs a)
        {
            Refresh();
        }

        // This is a little hack to try and speed up the drawing process
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        // Returns true if a map background is set, otherwise false
        public bool HasBackground
        {
            get { return mapImage != null; }
        }

        // Loads and updates the background image based on the file path
        // in gameState.MapImageFile
        public bool UpdateBackground()
        {
            // File name string is empty
            if (gameState.MapImageFile.Length == 0) { return false; }

            try
            {
                Image newBck = Bitmap.FromFile(gameState.MapImageFile);

                // Dispose of old images
                if (mapImage != null)
                {
                    mapImage.Dispose();
                    mapImage = null;
                }

                if (mapImageSized != null)
                {
                    mapImageSized.Dispose();
                    mapImageSized = null;
                }

                mapImage = newBck;
                mapImageSized = null;

                // Reset zoom level
                viewZoom = 1.0f;

                // Resize background image to the correct size for zoom
                // level and control size
                ResizeMapImage();

                // Center view over map
                CenterViewOnMap();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading background image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Property for Grid Transparency
        public int GridTransparency
        {
            get { return gridAlpha; }
            set
            {
                int newAlpha = value;

                // Make sure alpha is within range [0-255]
                newAlpha = Math.Min(Math.Max(0, newAlpha), 255);
                gridAlpha = newAlpha;

                // Redraw control
                Refresh();
            }
        }

        // Property for Grid Thickness
        public int GridThickness
        {
            get { return gridThickness; }
            set
            {
                int newThickness = value;

                // Make sure thickness value is within range
                newThickness = Math.Min(Math.Max(1, newThickness), MAX_GRID_THICKNESS);
                gridThickness = newThickness;

                // Redraw control
                Refresh();
            }
        }

        // Property for Grid Horizontal Offset
        public float GridHorizontalOffset
        {
            get { return gridHorzOffset; }
            set
            {
                // Make sure value is within range [-1.0, 1.0]
                gridHorzOffset = value - (float)Math.Truncate(value);

                Refresh();
            }
        }

        // Property for Grid Vertical Offset
        public float GridVerticalOffset
        {
            get { return gridVertOffset; }
            set
            {
                // Make sure value is within range [-1.0, 1.0]
                gridVertOffset = value - (float)Math.Truncate(value);

                Refresh();
            }
        }

        // Property for Grid Scale
        public int GridScale
        {
            get { return gridScale; }
            set
            {
                int oldScale = gridScale;
                int newScale = calcGridScale(value);

                // Make sure scale value is within range
                newScale = Math.Min(Math.Max(MIN_GRID_SCALE, newScale), MAX_GRID_SCALE);
                gridScale = newScale;

                // Adjust view position to the same relative position
                // for the new grid scale
                float xDiffRatio = viewPosX / oldScale;
                float yDiffRatio = viewPosY / oldScale;

                viewPosX = newScale * xDiffRatio;
                viewPosY = newScale * yDiffRatio;

                adjustTokenPositions(oldScale, newScale);

                // Redraw control
                Refresh();
            }
        }

        // Property for View Position
        public PointF ViewPosition
        {
            get { return new PointF(viewPosX, viewPosY); }
            set
            {
                viewPosX = value.X;
                viewPosY = value.Y;

                Refresh();
            }
        }

        public bool TokenSnapToGrid
        {
            get { return tokenSnapToGrid; }
            set
			{
				tokenSnapToGrid = value;
				foreach (MapToken token in gameState.ActiveTokens)
					token.Position = token.Position;

				Refresh();
			}
        }

        public bool ShowTokenLabels
        {
            get { return showTokenLabels; }
            set
            {
                showTokenLabels = value;
                Refresh();
            }
        }

        public bool RedrawNeeded
        {
            get { return redrawNeeded; }
            set { redrawNeeded = value; }
        }

        // Centers view over the center of the map
        public void CenterViewOnMap()
        {
            RectangleF worldRect = GetWorldUnitRect();
            viewPosX = worldRect.Width / 2;
            viewPosY = worldRect.Height / 2;

            // Redraw control
            Refresh();
        }

        public float ZoomFactor
        {
            get { return viewZoom; }
            set
            {
                viewZoom = Math.Min(Math.Max(MIN_ZOOM, value), MAX_ZOOM);

                // Redraw control
                Refresh();
            }
        }

        public void ZoomIn()
        {
            ZoomFactor *= ZOOM_STEP;
        }

        public void ZoomOut()
        {
            ZoomFactor /= ZOOM_STEP;
        }

        public void PanLeft()
        {
            viewPosX -= (PAN_STEP * (float)gridScale) / ZoomFactor;
            Refresh();
        }

        public void PanRight()
        {
            viewPosX += (PAN_STEP * (float)gridScale) / ZoomFactor;
            Refresh();
        }

        public void PanUp()
        {
            viewPosY -= (PAN_STEP * (float)gridScale) / ZoomFactor;
            Refresh();
        }

        public void PanDown()
        {
            viewPosY += (PAN_STEP * (float)gridScale) / ZoomFactor;
            Refresh();
        }

        public Font MapLabelFont
        {
            get { return gameState.MapLabelsFont; }
        }

        // Calculates a grid scale based off of the given scale factor
        private static int calcGridScale(int factor)
        {
            return (int)Math.Round(Math.Pow(1.25, factor));
        }

        // Repositions all tokens on the map so that they stay in the same
        // place after a grid scale adjustment
        private void adjustTokenPositions(float oldGridScale, float newGridScale)
        {
            // Return if no tokens
            if (gameState.ActiveTokens.Count == 0) { return; }

            foreach (MapToken token in gameState.ActiveTokens)
            {
                PointF pos = token.Position;
                float xPosFactor = pos.X / oldGridScale;
                float yPosFactor = pos.Y / oldGridScale;
                pos.X = newGridScale * xPosFactor;
                pos.Y = newGridScale * yPosFactor;

                token.Position = pos;
            }
        }

        // Called when map control needs to be redrawn
        // Draws both the map background and the grid lines
        protected override void OnPaint(PaintEventArgs e)
        {
            lock (drawMutex)
            {
                base.OnPaint(e);

                ResizeMapImage();

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                e.Graphics.Clear(Color.LightBlue);

                if (mapImageSized != null)
                {
                    GraphicsUnit units = GraphicsUnit.Pixel;

                    // Draw image to screen.
                    e.Graphics.DrawImage(mapImageSized, new Rectangle(0, 0, Width, Height), getImageSrcRect(), units);
                }

                RectangleF viewportRect = GetViewportUnitRect();

                drawGridLines(e, ref viewportRect);
                drawTokens(e, ref viewportRect);
                if (showTokenLabels) { drawTokenLabels(e, ref viewportRect);  }
            }
        }

        // Draws the grid lines in the map window viewport
        protected virtual void drawGridLines(PaintEventArgs e, ref RectangleF viewPortRect)
        {
            float firstVerticalLine = (float)Math.Floor(viewPortRect.Left);
            float firstHorizontalLine = (float)Math.Floor(viewPortRect.Top);

            Pen pen = new Pen(Color.FromArgb(gridAlpha, 0, 0, 0), gridThickness);

            for (float x = firstVerticalLine + gridHorzOffset; x <= viewPortRect.Right; x++)
            {
                Point topPos = UnitPosToPixelPos(x, viewPortRect.Top, viewPortRect);
                Point botPos = UnitPosToPixelPos(x, viewPortRect.Bottom, viewPortRect);

                e.Graphics.DrawLine(pen, topPos, botPos);
            }

            for (float y = firstHorizontalLine + gridVertOffset; y <= viewPortRect.Bottom; y++)
            {
                Point leftPos = UnitPosToPixelPos(viewPortRect.Left, y, viewPortRect);
                Point rightPos = UnitPosToPixelPos(viewPortRect.Right, y, viewPortRect);

                e.Graphics.DrawLine(pen, leftPos, rightPos);
            }
        }

        protected virtual void drawTokens(PaintEventArgs e, ref RectangleF viewPortRect)
        {
            // Return if no tokens to draw
            if (gameState.ActiveTokens.Count == 0) { return; }

            foreach (MapToken token in gameState.ActiveTokens)
            {
                token.DrawToken(e.Graphics, ref viewPortRect);
            }
        }

        protected virtual void drawTokenLabels(PaintEventArgs e, ref RectangleF viewPortRect)
        {
            // Return if no tokens to draw
            if (gameState.ActiveTokens.Count == 0) { return; }

            foreach (MapToken token in gameState.ActiveTokens)
            {
                token.DrawTokenLabel(e.Graphics, ref viewPortRect);
            }
        }

        // Gets the size of a single unit in pixels relative to the map control
        public int GetUnitPixelSize()
        {
            return (int)Math.Round((float)Width / (gridScale / viewZoom));
        }

        // Takes a unit map position and returns a pixel coordinate relative to
        // map viewport
        public Point UnitPosToPixelPos(float x, float y, RectangleF viewPortRect)
        {
            Point pixelPoint = new Point();

            float xViewRatio = (x - viewPortRect.Left) / viewPortRect.Width;
            float yViewRatio = (y - viewPortRect.Top) / viewPortRect.Height;

            pixelPoint.X = (int)Math.Round(xViewRatio * Width);
            pixelPoint.Y = (int)Math.Round(yViewRatio * Height);

            return pixelPoint;
        }

        // Takes a pixel viewport position and returns a unit coordinate relative to
        // the world
        public PointF PixelPosToUnitPos(Point pixelPos, RectangleF viewPortRect)
        {
            PointF unitPoint = new Point();

            float xViewRatio = (float)pixelPos.X / Width;
            float yViewRatio = (float)pixelPos.Y / Height;

            unitPoint.X = viewPortRect.Left + (xViewRatio * viewPortRect.Width);
            unitPoint.Y = viewPortRect.Top + (yViewRatio * viewPortRect.Height);

            return unitPoint;
        }

        // Takes a unit rectangle and returns a pixel rectangle relative to the current
        // map control
        public Rectangle UnitRectToPixelRect(RectangleF srcRect, RectangleF? viewPortRect = null)
        {
            if (viewPortRect == null)
            {
                viewPortRect = GetViewportUnitRect();
            }

            Rectangle pixelRect = new Rectangle();
            int unitPixelSize = GetUnitPixelSize();

            float xPosRatio = (srcRect.Left - viewPortRect.Value.Left) / viewPortRect.Value.Width;
            float yPosRatio = (srcRect.Top - viewPortRect.Value.Top) / viewPortRect.Value.Height;

            pixelRect.X = (int)Math.Round(xPosRatio * Width);
            pixelRect.Y = (int)Math.Round(yPosRatio * Height);

            pixelRect.Width = (int)Math.Round(srcRect.Width * unitPixelSize);
            pixelRect.Height = (int)Math.Round(srcRect.Height * unitPixelSize);

            return pixelRect;
        }

        // Returns floating point Rectangle that contains Unit coordinates
        // for current map view. 1 unit == 1 grid square.
        public RectangleF GetViewportUnitRect()
        {
            RectangleF unitViewport = new RectangleF();

            unitViewport.Width = (float)gridScale / viewZoom;
            unitViewport.Height = ((float)this.Height / this.Width) * unitViewport.Width;

            unitViewport.X = viewPosX - (unitViewport.Width / 2);
            unitViewport.Y = viewPosY - (unitViewport.Height / 2);

            return unitViewport;
        }

        // Returns floating point Rectangle that contains Unit coordinates
        // for entire map. 1 unit == 1 grid square.
        public RectangleF GetWorldUnitRect()
        {
            RectangleF worldRect = new RectangleF();

            worldRect.X = 0;
            worldRect.Y = 0;
            worldRect.Width = gridScale;
            worldRect.Height = gridScale;

            if (HasBackground)
            {
                // Adjust height to match background image aspect ratio
                worldRect.Height *= (float)mapImage.Height / mapImage.Width;
            }

            return worldRect;
        }

        // Returns pixel coordinate Rectangle for portion of map image that is to
        // be drawn on screen.
        protected Rectangle getImageSrcRect()
        {
            if (mapImageSized == null)
            {
                return new Rectangle();
            }

            RectangleF unitViewport = GetViewportUnitRect();
            Rectangle imgSrcRect = new Rectangle();

            float unitSizePixels = (float)mapImageSized.Width / (float)gridScale;

            imgSrcRect.X = (int)Math.Round(unitViewport.Left * unitSizePixels);
            imgSrcRect.Y = (int)Math.Round(unitViewport.Top * unitSizePixels);
            imgSrcRect.Width = (int)Math.Round(unitViewport.Width * unitSizePixels);
            imgSrcRect.Height = (int)Math.Round(unitViewport.Height * unitSizePixels);

            return imgSrcRect;
        }

        // Redraw map control on resize
        private void MapControl_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        // User clicked the map.
        // Remember that mouse position for later use
        // when calculating map drag offset
        private void MapControl_MouseDown(object sender, MouseEventArgs e)
        {
            MapToken tokenUnderMouse = getTokenUnderMouse(e.Location);
            mouseDownPos = e.Location;
            mouseDownTimer.Reset();
            mouseDownTimer.Start();

            if (e.Button == MouseButtons.Left)
            {
                leftMouseDown = true;

                if (tokenUnderMouse != null)
                {
                    tokenUnderMouse.MouseState = TokenMouseState.Drag;
                    this.draggedToken = tokenUnderMouse;
                    this.mouseDragState = MouseDragState.Token;
                }
                else
                {
                    this.mouseDragState = MouseDragState.Map;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (tokenUnderMouse != null)
                {
                    rightClickedToken = tokenUnderMouse;
                    tokenContextMenu.Show(this, e.Location);
                }
                else
                {
                    rightClickedToken = null;
                    mapContextMenu.Show(this, e.Location);
                }
            }

            refreshIfNeeded();
        }

        // Event that is called every time the mouse is moved over the control
        private void MapControl_MouseMove(object sender, MouseEventArgs e)
        {
            Point newMousePos = e.Location;

            updateActiveTokenMouseState(newMousePos);

            if (leftMouseDown && !mouseDownPos.Equals(newMousePos))
            {
                float xOffset = mouseDownPos.X - newMousePos.X;
                float yOffset = mouseDownPos.Y - newMousePos.Y;

                RectangleF unitViewport = GetViewportUnitRect();

                float unitOffsetX = (xOffset / Width) * unitViewport.Width;
                float unitOffsetY = (yOffset / Height) * unitViewport.Height;

                if (mouseDragState == MouseDragState.Token)
                {
                    PointF tokenPos = draggedToken.Position;
                    PointF mouseUnitPos = PixelPosToUnitPos(newMousePos, unitViewport);

                    tokenPos.X -= unitOffsetX;
                    tokenPos.Y -= unitOffsetY;

                    draggedToken.Position = tokenPos;

                    RectangleF tokenUnitRect = draggedToken.GetUnitRect();

                    if (!tokenUnitRect.Contains(mouseUnitPos))
                    {
                        draggedToken.Position = mouseUnitPos;
                    }
                }
                else if (mouseDragState == MouseDragState.Map)
                {
                    viewPosX += unitOffsetX;
                    viewPosY += unitOffsetY;

                    redrawNeeded = true;
                }

                mouseDownPos = newMousePos;
            }

            refreshIfNeeded();
        }

        // User let go of the mouse button
        private void MapControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (draggedToken != null)
            {
                draggedToken.MouseState = TokenMouseState.Hover;
                draggedToken = null;
            }

            leftMouseDown = false;

            refreshIfNeeded();
        }

        protected void refreshIfNeeded()
        {
            if (redrawNeeded)
            {
                Refresh();
                redrawNeeded = false;
            }
        }

        // updates the mouse state of any active tokens on the map
        // depending on the current mouse position
        protected void updateActiveTokenMouseState(Point mousePos)
        {
            // No active tokens? Return
            if (gameState.ActiveTokens.Count == 0) { return; }

            // Get unit rectangle for current view
            RectangleF viewPortRect = GetViewportUnitRect();

            MapToken tokenUnderMouse = null;

            // Loop through each active token
            foreach (MapToken token in gameState.ActiveTokens)
            {
                // Is a token currently being dragged?
                if (draggedToken != null)
                {
                    if (token != draggedToken) { token.MouseState = TokenMouseState.Idle;  }
                }
                else
                {
                    RectangleF tokenUnitRect = token.GetUnitRect(); // Get unit rectangle for token
                    Rectangle pixelRect = UnitRectToPixelRect(tokenUnitRect, viewPortRect); // Convert unit rect to pixel coordinates

                    // If token is under mouse, set Hover state
                    if (pixelRect.Contains(mousePos))
                    {
                        token.MouseState = TokenMouseState.Hover;
                        tokenUnderMouse = token;
                    }
                    else
                    {
                        token.MouseState = TokenMouseState.Idle;
                    }
                }
            }

            if (tokenUnderMouse != null && !tokenHoverToolTip.Active)
            {
                TokenData data = tokenUnderMouse.GetTokenData();
                tokenHoverToolTip.SetTokenData(ref data);
                tokenHoverToolTip.Active = true;
            }
            else if (tokenUnderMouse == null && tokenHoverToolTip.Active)
            {
                tokenHoverToolTip.Active = false;
                tokenHoverToolTip.Hide(this);
            }
            

        }

        protected MapToken getTokenUnderMouse(Point mousePos)
        {
            // No active tokens? Return null
            if (gameState.ActiveTokens.Count == 0) { return null; }

            // Get unit rectangle for current view
            RectangleF viewPortRect = GetViewportUnitRect();

            // Loop through each active token
            foreach (MapToken token in gameState.ActiveTokens)
            {
                RectangleF tokenUnitRect = token.GetUnitRect(); // Get unit rectangle for token
                Rectangle pixelRect = UnitRectToPixelRect(tokenUnitRect, viewPortRect); // Convert unit rect to pixel coordinates

                // If token is under mouse, return it
                if (pixelRect.Contains(mousePos))
                {
                    return token;
                }
            }

            // No token under mouse, return null
            return null;
        }

        // This resizes the map image to be the same resolution as the current zoom
        // level. Speeds up drawing/paint process significantly
        public void ResizeMapImage()
        {
            if (mapImage == null) {
                mapImageSized = mapImage;
                return;
            }

            int newWidth = (int)Math.Round((float)Width * viewZoom);
            int newHeight = (int)Math.Round((float)newWidth * ((float)mapImage.Height / mapImage.Width));

            if (mapImageSized != null && mapImageSized.Width == newWidth)
            {
                    return;
            }

            this.ParentForm.Cursor = Cursors.WaitCursor;

            Image oldImage = mapImageSized;
            mapImageSized = ResizeImage(mapImage, newWidth, newHeight);

            if (oldImage != null)
            {
                oldImage.Dispose();
                oldImage = null;
            }

            this.ParentForm.Cursor = Cursors.Default;
            
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void centerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangleF viewportRect = GetViewportUnitRect();
            PointF mouseUnitPos = PixelPosToUnitPos(mouseDownPos, viewportRect);

            this.ViewPosition = mouseUnitPos;

            Refresh();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ZoomOut();
        }

        private void centerViewOnTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rightClickedToken == null) { return; }

            this.ViewPosition = rightClickedToken.Position;

            Refresh();
        }

        private void toggleShowLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTokenLabels = !ShowTokenLabels;
        }

        private void editTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rightClickedToken == null) { return; }

            TokenData data = rightClickedToken.GetTokenData();

            EditTokenForm editTokenForm = new EditTokenForm(gameState);
            editTokenForm.SetTokenData(ref data);

            DialogResult result = editTokenForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                data = editTokenForm.GetTokenData();
                rightClickedToken.SetTokenData(ref data);
            }
        }

        private void duplicateTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rightClickedToken == null) { return; }

            MapToken duplicateToken = new MapToken(rightClickedToken);
            gameState.ActiveTokens.Add(duplicateToken);

            Refresh();
        }

        private void removeTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rightClickedToken == null) { return; }

            gameState.ActiveTokens.Remove(rightClickedToken);

            Refresh();
        }

        private void MapControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void MapControl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    PanLeft();
                    break;
                case Keys.Right:
                    PanRight();
                    break;
                case Keys.Up:
                    PanUp();
                    break;
                case Keys.Down:
                    PanDown();
                    break;
            }
        }

        private void MapControl_MouseClick(object sender, MouseEventArgs e)
        {
            mouseDownTimer.Stop();
            if (mouseDownTimer.ElapsedMilliseconds <= SELECT_TIME_FRAME)
            {
                MapToken mapToken = getTokenUnderMouse(e.Location);
                if (mapToken != null)
                {
                    mapToken.Selected = !mapToken.Selected;
                }
            }

            refreshIfNeeded();
        }

        private void MapControl_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
