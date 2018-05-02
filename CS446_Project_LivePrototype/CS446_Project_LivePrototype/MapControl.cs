using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS446_Project_LivePrototype
{
    public partial class MapControl : UserControl
    {
        private readonly object drawMutex = new object();
        private GameState gameState;
        private Point mouseDownPos;
        private bool mouseDown = false;

        public MapControl(GameState gameState)
        {
            InitializeComponent();

            this.gameState = gameState;
            this.ResizeRedraw = true;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
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

        // Called when map control needs to be redrawn
        // Draws both the map background and the grid lines
        protected override void OnPaint(PaintEventArgs e)
        {
            lock (drawMutex)
            {
                base.OnPaint(e);

                resizeMapImage();

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                e.Graphics.Clear(Color.LightBlue);

                if (gameState.MapImageSized != null)
                {
                    GraphicsUnit units = GraphicsUnit.Pixel;

                    // Draw image to screen.
                    e.Graphics.DrawImage(gameState.MapImageSized, new Rectangle(0, 0, Width, Height), getImageSrcRect(), units);
                }

                drawGridLines(e, getViewportUnitRect());
            }
        }

        // Draws the grid lines in the map window viewport
        protected virtual void drawGridLines(PaintEventArgs e, RectangleF viewPortRect)
        {
            float firstVerticalLine = (float)Math.Ceiling(viewPortRect.Left);
            float firstHorizontalLine = (float)Math.Ceiling(viewPortRect.Top);

            Pen pen = new Pen(Color.FromArgb(gameState.MapGridAlpha, 0, 0, 0), gameState.MapGridThickness);

            for (float x = firstVerticalLine + gameState.MapGridHorzOffset; x <= viewPortRect.Right; x++)
            {
                Point topPos = unitPosToPixelPos(x, viewPortRect.Top, viewPortRect);
                Point botPos = unitPosToPixelPos(x, viewPortRect.Bottom, viewPortRect);

                e.Graphics.DrawLine(pen, topPos, botPos);
            }

            for (float y = firstHorizontalLine + gameState.MapGridVertOffset; y <= viewPortRect.Bottom; y++)
            {
                Point leftPos = unitPosToPixelPos(viewPortRect.Left, y, viewPortRect);
                Point rightPos = unitPosToPixelPos(viewPortRect.Right, y, viewPortRect);

                e.Graphics.DrawLine(pen, leftPos, rightPos);
            }
        }

        // Takes a unit map position and returns a pixel coordinate relative to
        // window viewport
        protected Point unitPosToPixelPos(float x, float y, RectangleF viewPortRect)
        {
            Point pixelPoint = new Point();

            float xViewRatio = (x - viewPortRect.Left) / viewPortRect.Width;
            float yViewRatio = (y - viewPortRect.Top) / viewPortRect.Height;

            pixelPoint.X = (int)Math.Round(xViewRatio * Width);
            pixelPoint.Y = (int)Math.Round(yViewRatio * Height);

            return pixelPoint;
        }

        // Returns floating point Rectangle that contains Unit coordinates
        // for current map view. 1 unit == 1 grid square.
        public RectangleF getViewportUnitRect()
        {
            RectangleF unitViewport = new RectangleF();

            unitViewport.Width = gameState.MapGridScale / gameState.MapViewZoom;
            unitViewport.Height = ((float)this.Height / this.Width) * unitViewport.Width;

            unitViewport.X = gameState.MapViewPosX - (unitViewport.Width / 2);
            unitViewport.Y = gameState.MapViewPosY - (unitViewport.Height / 2);

            return unitViewport;
        }

        // Returns pixel coordinate Rectangle for portion of map image that is to
        // be drawn on screen.
        protected Rectangle getImageSrcRect()
        {
            if (gameState.MapImageSized == null)
            {
                return new Rectangle();
            }

            RectangleF unitViewport = getViewportUnitRect();
            Rectangle imgSrcRect = new Rectangle();

            float unitSizePixels = (float)gameState.MapImageSized.Width / gameState.MapGridScale;

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
            mouseDownPos = e.Location;
            mouseDown = true;
        }

        // Repositions map based off mouse movement
        private void MapControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown) { return; }

            Point newPos = e.Location;

            if (mouseDownPos != newPos)
            {
                float xOffset = mouseDownPos.X - newPos.X;
                float yOffset = mouseDownPos.Y - newPos.Y;

                RectangleF unitViewport = getViewportUnitRect();

                float viewOffsetX = (xOffset / Width) * unitViewport.Width;
                float viewOffsetY = (yOffset / Height) * unitViewport.Height;

                gameState.MapViewPosX += viewOffsetX;
                gameState.MapViewPosY += viewOffsetY;

                mouseDownPos = newPos;

                Refresh();
            }
        }

        // User let go of the mouse button
        private void MapControl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // This resizes the map image to be the same resolution as the current zoom
        // level. Speeds up drawing/paint process significantly
        public void resizeMapImage()
        {
            if (gameState.MapImage == null) {
                gameState.MapImageSized = gameState.MapImage;
                return;
            }

            int newWidth = (int)Math.Round((float)Width * gameState.MapViewZoom);
            int newHeight = (int)Math.Round((float)newWidth * ((float)gameState.MapImage.Height / gameState.MapImage.Width));

            if (gameState.MapImageSized != null && gameState.MapImageSized.Width == newWidth)
            {
                    return;
            }

            // gameState.MainForm.Enabled = false;
            gameState.MainForm.Cursor = Cursors.WaitCursor;

            Image oldImage = gameState.MapImageSized;
            gameState.MapImageSized = ResizeImage(gameState.MapImage, newWidth, newHeight);

            if (oldImage != null)
            {
                oldImage.Dispose();
                oldImage = null;
            }

            gameState.MainForm.Cursor = Cursors.Default;
            // gameState.MainForm.Enabled = true;
            
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
    }
}
