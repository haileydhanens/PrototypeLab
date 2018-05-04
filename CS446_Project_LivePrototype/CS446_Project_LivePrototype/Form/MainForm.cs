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

            mapControl = new MapControl(gameState);
            this.mainSplitContainer.Panel1.Controls.Add(mapControl);
            mapControl.Dock = DockStyle.Fill;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            gridThicknessSlider.Minimum = 1;
            gridThicknessSlider.Maximum = MapControl.MAX_GRID_THICKNESS;

            gridScaleSlider.Minimum = MapControl.MIN_GRID_SCALE_FACTOR;
            gridScaleSlider.Maximum = MapControl.MAX_GRID_SCALE_FACTOR;
            gridScaleSlider.Value = gridScaleSlider.Minimum;
            mapControl.GridScale = gridScaleSlider.Value;
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
                gameState.MapImageFile = openMapImageDialog.FileName;
                mapControl.UpdateBackground();
            }
            
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            mapControl.ZoomIn();
        }

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            mapControl.ZoomOut();
        }

        private void mainSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void gridScaleSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridScale = gridScaleSlider.Value;
        }

        private void gridAlphaSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridTransparency = gridAlphaSlider.Value;
        }

        private void gridThicknessSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridThickness = gridThicknessSlider.Value;
        }

        private void gridHorzOffset_Scroll(object sender, EventArgs e)
        {
            mapControl.GridHorizontalOffset = (float)gridHorzOffset.Value / 10.0f;
        }

        private void gridVertOffsetSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridVerticalOffset = (float)gridVertOffsetSlider.Value / 10.0f;
        }

        private void newTokenBtn_Click(object sender, EventArgs e)
        {
            EditTokenForm charForm = new EditTokenForm();
            DialogResult result = charForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                RectangleF worldRect = mapControl.GetWorldUnitRect();

                TokenData newData = new TokenData("Test Token", TokenType.Player);
                MapToken newToken = new MapToken(mapControl, ref newData, new PointF(worldRect.Width / 2, worldRect.Height / 2));
                gameState.ActiveTokens.Add(newToken);

                mapControl.Refresh();
            }
        }
    }
}
