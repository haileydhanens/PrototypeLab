using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS446_Project_LivePrototype
{
    public partial class ViewStatsForm : Form
    {
        private MapToken mapToken;
        private Point formPos;

        public ViewStatsForm(MapToken mapToken, Point formPos)
        {
            InitializeComponent();

            this.mapToken = mapToken;
            this.formPos = formPos;
        }

        private void ViewStatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mapToken.Selected = false;
        }

        private void ViewStatsForm_Load(object sender, EventArgs e)
        {
            TokenData tokData = mapToken.GetTokenData();

            this.tokenNameLbl.Text = tokData.Name;

            this.curHPBox.Minimum = 0;
            this.curHPBox.Maximum = tokData.MaxHP;
            this.curHPBox.Value = tokData.CurrentHP;
            this.maxHPLbl.Text = "/ " + tokData.MaxHP;
            this.acLbl.Text = tokData.ArmorClass.ToString();

            this.strLbl.Text = tokData.Strength.ToString();
            this.dexLbl.Text = tokData.Dexterity.ToString();
            this.constLbl.Text = tokData.Constitution.ToString();
            this.intLbl.Text = tokData.Intelligence.ToString();
            this.wisLbl.Text = tokData.Wisdom.ToString();
            this.chrLbl.Text = tokData.Charisma.ToString();
            this.notesBox.Text = tokData.Notes;

            formPos.X -= Size.Width;
            formPos.Y -= Size.Height;

            Rectangle screenRect = Screen.FromControl(this).Bounds;

            formPos.X = Math.Max(Math.Min(screenRect.Width - Size.Width, formPos.X), 0);
            formPos.Y = Math.Max(Math.Min(screenRect.Height - Size.Height, formPos.Y), 0);

            this.Location = formPos;
        }

        private void curHPBox_ValueChanged(object sender, EventArgs e)
        {
            mapToken.CurrentHP = (int)curHPBox.Value;
        }

        private void notesBox_TextChanged(object sender, EventArgs e)
        {
            mapToken.Notes = notesBox.Text;
        }
    }
}
