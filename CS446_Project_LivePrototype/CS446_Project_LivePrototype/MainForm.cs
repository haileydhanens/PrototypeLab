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
    public partial class MainForm : Form
    {
        private MapControl mapControl;
        private GameState gameState;
        private int savedSplitterPos = 250;

        public MainForm()
        {
            InitializeComponent();

            gameState = new GameState();

            gameState.MainForm = this;

            mapControl = new MapControl(gameState);
            this.mainSplitContainer.Panel1.Controls.Add(mapControl);
            mapControl.Dock = DockStyle.Fill;

            gameState.MapControl = mapControl;
            
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            gridScaleSlider.Minimum = 8;
            gridScaleSlider.Maximum = 25;
            gridScaleSlider.Value = gridScaleSlider.Minimum;
            updateGridScale();
        }

        private void mainSplitContainer_DoubleClick(object sender, EventArgs e)
        {
            int closedPos = mainSplitContainer.Width - mainSplitContainer.SplitterWidth;

            if (mainSplitContainer.SplitterDistance >= closedPos)
            {
                mainSplitContainer.SplitterDistance = savedSplitterPos;
            }
            else
            {
                savedSplitterPos = mainSplitContainer.SplitterDistance;
                mainSplitContainer.SplitterDistance = mainSplitContainer.Width - mainSplitContainer.SplitterWidth;
            }
        }

        private void testLoadMapBtn_Click(object sender, EventArgs e)
        {
            if (openMapImageDialog.ShowDialog() == DialogResult.OK)
            {
                if (gameState.MapImage != null)
                {
                    gameState.MapImage.Dispose();
                    gameState.MapImage = null;
                }

                if (gameState.MapImageSized != null)
                {
                    gameState.MapImageSized.Dispose();
                    gameState.MapImageSized = null;
                }

                gameState.MapViewZoom = 1.0f;

                gameState.MapImage = Bitmap.FromFile(openMapImageDialog.FileName);
                mapControl.resizeMapImage();

                RectangleF viewportRect = mapControl.getViewportUnitRect();
                gameState.MapViewPosX = viewportRect.Width / 2;
                gameState.MapViewPosY = viewportRect.Height / 2;
                mapControl.Refresh();
            }
            
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            gameState.MapViewZoom *= 1.25f;
            mapControl.Refresh();
        }

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            gameState.MapViewZoom *= 0.8f;
            mapControl.Refresh();
        }

        private void panLeftBtn_Click(object sender, EventArgs e)
        {
            gameState.MapViewPosX -= 1.0f / gameState.MapViewZoom;
            mapControl.Refresh();
        }

        private void panRightBtn_Click(object sender, EventArgs e)
        {
            gameState.MapViewPosX += 1.0f / gameState.MapViewZoom;
            mapControl.Refresh();
        }

        private void panUpBtn_Click(object sender, EventArgs e)
        {
            gameState.MapViewPosY -= 1.0f / gameState.MapViewZoom;
            mapControl.Refresh();
        }

        private void panDownBtn_Click(object sender, EventArgs e)
        {
            gameState.MapViewPosY += 1.0f / gameState.MapViewZoom;
            mapControl.Refresh();
        }

        private void mainSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void gridScaleSlider_Scroll(object sender, EventArgs e)
        {
            updateGridScale();
        }

        private void updateGridScale()
        {
            float xViewPosRatio = gameState.MapViewPosX / gameState.MapGridScale;
            float yViewPosRatio = gameState.MapViewPosY / gameState.MapGridScale;

            gameState.MapGridScale = (float)Math.Round(Math.Pow(1.25, gridScaleSlider.Value));

            gameState.MapViewPosX = gameState.MapGridScale * xViewPosRatio;
            gameState.MapViewPosY = gameState.MapGridScale * yViewPosRatio;

            mapControl.Refresh();
        }

        private void gridAlphaSlider_Scroll(object sender, EventArgs e)
        {
            gameState.MapGridAlpha = gridAlphaSlider.Value;

            mapControl.Refresh();
        }

        private void gridThicknessSlider_Scroll(object sender, EventArgs e)
        {
            gameState.MapGridThickness = gridThicknessSlider.Value;

            mapControl.Refresh();
        }

        private void gridHorzOffset_Scroll(object sender, EventArgs e)
        {
            float newOffset = 0; ;

            if (gridHorzOffset.Value != 0)
            {
                newOffset = (float)gridHorzOffset.Value / 10.0f;
            }

            gameState.MapGridHorzOffset = newOffset;

            mapControl.Refresh();
        }

        private void gridVertOffsetSlider_Scroll(object sender, EventArgs e)
        {
            float newOffset = 0; ;

            if (gridVertOffsetSlider.Value != 0)
            {
                newOffset = (float)gridVertOffsetSlider.Value / 10.0f;
            }

            gameState.MapGridVertOffset = newOffset;

            mapControl.Refresh();
        }

        private void newTokenBtn_Click(object sender, EventArgs e)
        {
            characterForm charForm = new characterForm();
            charForm.ShowDialog(this);
        }
    }
}
