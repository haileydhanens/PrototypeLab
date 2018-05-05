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
        private int savedSplitterPos;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gameState = new GameState();

            mapControl = new MapControl(gameState);
            this.mainSplitContainer.Panel1.Controls.Add(mapControl);
            mapControl.Dock = DockStyle.Fill;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            // Open map tab by default
            rightPanelTabControl.SelectedIndex = 2;

            gridThicknessSlider.Minimum = 1;
            gridThicknessSlider.Maximum = MapControl.MAX_GRID_THICKNESS;

            gridScaleSlider.Minimum = MapControl.MIN_GRID_SCALE_FACTOR;
            gridScaleSlider.Maximum = MapControl.MAX_GRID_SCALE_FACTOR;
            gridScaleSlider.Value = gridScaleSlider.Minimum;
            mapControl.GridScale = gridScaleSlider.Value;

            savedSplitterPos = mainSplitContainer.SplitterDistance;
            snapTokensToGridCheckbox.CheckState = mapControl.TokenSnapToGrid ? CheckState.Checked : CheckState.Unchecked;

            gameState.TokenLibrary.TokenAddedRemovedEvent += TokenLibrary_TokenAddedRemovedEvent;
        }

        private void mainSplitContainer_DoubleClick(object sender, EventArgs e)
        {
            int closedPos = mainSplitContainer.Width - mainSplitContainer.SplitterWidth;

            if (mainSplitContainer.SplitterDistance >= closedPos)
            {
                mainSplitContainer.SplitterDistance = mainSplitContainer.Width - savedSplitterPos;
            }
            else
            {
                savedSplitterPos = mainSplitContainer.Width - mainSplitContainer.SplitterDistance;
                mainSplitContainer.SplitterDistance = mainSplitContainer.Width - mainSplitContainer.SplitterWidth;
            }
        }

        private void loadMapBackgroundBtn_Click(object sender, EventArgs e)
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
            mapControl.GridTransparency = 255 - gridAlphaSlider.Value;
        }

        private void gridThicknessSlider_Scroll(object sender, EventArgs e)
        {
            mapControl.GridThickness = gridThicknessSlider.Value;
        }

        private void gridHorzOffset_Scroll(object sender, EventArgs e)
        {
           // mapControl.GridHorizontalOffset = (float)gridHorzOffset.Value / 10.0f;
        }

        private void gridVertOffsetSlider_Scroll(object sender, EventArgs e)
        {
           // mapControl.GridVerticalOffset = (float)gridVertOffsetSlider.Value / 10.0f;
        }

        private void rollDiceBtn_Click(object sender, EventArgs e)
        {
            int numDice = (int)numericUpDown1.Value;
            int numSides = (int)numericUpDown2.Value;
            String output = "";

            Random rnd = new Random();

            for (int i = numDice; i > 0; i--)
                output += "  " + rnd.Next(1, numSides + 1);

            output.Trim();

            Console.WriteLine(output);
            diceOutputTextbox.Text = output;
        }

        private void centerViewBtn_Click(object sender, EventArgs e)
        {
            mapControl.CenterViewOnMap();
        }

        private void resetViewBtn_Click(object sender, EventArgs e)
        {
            mapControl.ZoomFactor = 1.0f;
            mapControl.CenterViewOnMap();
        }

        private void shiftGridLeftBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridHorizontalOffset -= MapControl.GRID_SHIFT_STEP;
        }

        private void shiftGridUpBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridVerticalOffset -= MapControl.GRID_SHIFT_STEP;
        }

        private void shiftGridRightBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridHorizontalOffset += MapControl.GRID_SHIFT_STEP;
        }

        private void shiftGridDownBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridVerticalOffset += MapControl.GRID_SHIFT_STEP;
        }

        private void resetGridPosBtn_Click(object sender, EventArgs e)
        {
            mapControl.GridHorizontalOffset = 0.0f;
            mapControl.GridVerticalOffset = 0.0f;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void snapTokensToGridCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            mapControl.TokenSnapToGrid = (snapTokensToGridCheckbox.CheckState == CheckState.Checked);
        }

        private void newTokenBtn_Click(object sender, EventArgs e)
        {
            EditTokenForm charForm = new EditTokenForm(gameState);
            DialogResult result = charForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                TokenData newData = charForm.GetTokenData();
                gameState.TokenLibrary.Add(ref newData);
            }
        }

        private void editLibTokenBtn_Click(object sender, EventArgs e)
        {
            int curSelectedIndex = tokenLibList.SelectedIndex;

            if (curSelectedIndex < 0)
            {
                MessageBox.Show("No token selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TokenData tokenData = gameState.TokenLibrary[(string)tokenLibList.SelectedItem];

            EditTokenForm charForm = new EditTokenForm(gameState);
            charForm.SetTokenData(ref tokenData);
            DialogResult result = charForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                tokenData = charForm.GetTokenData();
                gameState.TokenLibrary[tokenData.Name] = tokenData;
            }
        }

        private void placeTokenOnMapBtn_Click(object sender, EventArgs e)
        {
            int curSelectedIndex = tokenLibList.SelectedIndex;

            if (curSelectedIndex < 0)
            {
                MessageBox.Show("No token selected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TokenData selectedToken = gameState.TokenLibrary[(string)tokenLibList.SelectedItem];

            MapToken newToken = new MapToken(mapControl, ref selectedToken, mapControl.ViewPosition);
            gameState.ActiveTokens.Add(newToken);

            // Make sure token is within the map bounds
            newToken.Position = newToken.Position;

            mapControl.Refresh();
        }

        // This event is automatically called whenever a token is added or removed from the token library
        private void TokenLibrary_TokenAddedRemovedEvent(object sender, TokenAddedRemovedEventArgs a)
        {
            refreshTokenLibList();
        }

        private void refreshTokenLibList()
        {
            string selectedToken = null;

            if (tokenLibList.SelectedIndex >= 0)
            {
                selectedToken = (string)tokenLibList.SelectedItem;
            }

            tokenLibList.Items.Clear();

            var enumerator = gameState.TokenLibrary.GetEnumerator();

            List<string> filteredList = new List<string>();

            while (enumerator.MoveNext())
            {
                TokenData token = enumerator.Current;

                if (token.TokenType == TokenType.Player && libPlayerFilterCheck.Checked)
                {
                    filteredList.Add(token.Name);
                }
                else if (token.TokenType == TokenType.Enemy && libEnemyFilterCheck.Checked)
                {
                    filteredList.Add(token.Name);
                }
                else if (token.TokenType == TokenType.NPC && libNonplayerFilterCheck.Checked)
                {
                    filteredList.Add(token.Name);
                }
            }

            // Sort list of names
            filteredList.Sort();

            // Add each name to lib list
            foreach (string item in filteredList)
            {
                tokenLibList.Items.Add(item);
            }

            tokenLibList.SelectedItem = selectedToken;
        }

        private void libPlayerFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshTokenLibList();
        }

        private void libEnemyFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshTokenLibList();
        }

        private void libNonplayerFilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            refreshTokenLibList();
        }

        
    }
}
