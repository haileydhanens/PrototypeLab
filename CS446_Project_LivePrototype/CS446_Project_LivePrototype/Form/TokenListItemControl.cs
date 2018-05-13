using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS446_Project_LivePrototype
{
    public partial class TokenListItemControl : UserControl
    {
        private MapToken token;
        private TokenData data;

        public TokenListItemControl(MapToken token)
        {
            InitializeComponent();

            this.token = token;

            this.data = token.GetTokenData();

            TokenName.Text = data.Name;

            ACLabel.Text = "AC: " + data.ArmorClass;

            TokenStrength.Text = "STR: " + data.Strength;

            TokenDexterity.Text = "DEX: " + data.Dexterity;

            TokenConstitution.Text = "CON: " + data.Constitution;

            TokenIntelligence.Text = "INT: " + data.Intelligence;

            TokenWisdom.Text = "WIS: " + data.Wisdom;

            TokenCharisma.Text = "CHA: " + data.Charisma;

            HealthBox.Text = data.CurrentHP + " / " + data.MaxHP;

            if (data.CurrentHP >= data.MaxHP / 3)
            {
                HealthBox.BackColor = Color.Lime;
            }
            else if (data.CurrentHP >= data.MaxHP / 10)
            {
                HealthBox.BackColor = Color.Orange;
            }
            else
            {
                HealthBox.BackColor = Color.Red;
            }


        }

        private void TokenListItemControl_Load(object sender, EventArgs e)
        {

        }

        private void TokenName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HPPlus_Click(object sender, EventArgs e)
        {

            if (data.CurrentHP < data.MaxHP)
            {
                data.CurrentHP += 1;

                HealthBox.Text = data.CurrentHP + " / " + data.MaxHP;
            }
        }

        private void HPMinus_Click(object sender, EventArgs e)
        {

            if (data.CurrentHP > 0)
            {
                data.CurrentHP -= 1;

                HealthBox.Text = data.CurrentHP + " / " + data.MaxHP;
            }
        }

        private void HealthBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(HealthBox.Text) >= 0 || Convert.ToInt32(HealthBox.Text) <= data.MaxHP) { }

                data.CurrentHP = Convert.ToInt32(HealthBox.Text);
                HealthBox.Text = data.CurrentHP + " / " + data.MaxHP;

                if (data.CurrentHP >= data.MaxHP / 3)
                {
                    HealthBox.BackColor = Color.Lime;
                }
                else if(data.CurrentHP >= data.MaxHP / 10)
                {
                    HealthBox.BackColor = Color.Orange;
                }
                else
                {
                    HealthBox.BackColor = Color.Red;
                }
            }


            catch (Exception a)
            {
                HealthBox.Text = data.CurrentHP + " / " + data.MaxHP;
            }
        }
    }
}
