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
    public partial class EditTokenForm : Form
    {
        private GameState gameState = null;
        private bool editingExistingToken = false;

        public EditTokenForm(GameState gameState)
        {
            InitializeComponent();

            this.gameState = gameState;
        }

        // Updates fields on form based on existing token data
        public void SetTokenData(ref TokenData data)
        {
            playerType_rad.Checked = false;
            enemyType_rad.Checked = false;
            NPCtype_rad.Checked = false;

            switch (data.TokenType)
            {
                case TokenType.Player:
                    playerType_rad.Checked = true;
                    break;
                case TokenType.Enemy:
                    enemyType_rad.Checked = true;
                    break;
                case TokenType.NPC:
                    NPCtype_rad.Checked = true;
                    break;
            }

            tokenNameBox.Text = data.Name;
            tokenHPBox.Value = data.MaxHP;
            tokenACBox.Value = data.ArmorClass;
            tokenStrBox.Value = data.Strength;
            tokenIntBox.Value = data.Intelligence;
            tokenDexBox.Value = data.Dexterity;
            tokenWisBox.Value = data.Wisdom;
            tokenConstBox.Value = data.Constitution;
            tokenChrBox.Value = data.Charisma;
            charNotesBox.Text = data.Notes;

            tokenNameBox.ReadOnly = true;

            playerType_rad.Enabled = false;
            enemyType_rad.Enabled = false;
            NPCtype_rad.Enabled = false;

            editingExistingToken = true;
        }

        public TokenData GetTokenData()
        {
            TokenType tokenType = TokenType.Player;

            if (enemyType_rad.Checked) { tokenType = TokenType.Enemy; }
            else if (NPCtype_rad.Checked) { tokenType = TokenType.NPC; }

            TokenData data = new TokenData(tokenNameBox.Text, tokenType);
            data.MaxHP = (int)tokenHPBox.Value;
            data.ArmorClass = (int)tokenACBox.Value;
            data.Strength = (int)tokenStrBox.Value;
            data.Intelligence = (int)tokenIntBox.Value;
            data.Dexterity = (int)tokenDexBox.Value;
            data.Wisdom = (int)tokenWisBox.Value;
            data.Constitution = (int)tokenConstBox.Value;
            data.Charisma = (int)tokenChrBox.Value;
            data.Notes = charNotesBox.Text;

            return data;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (tokenNameBox.Text.Length < 3)
            {
                MessageBox.Show("Please enter a valid token name (At least 3 characters).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!editingExistingToken && gameState.TokenLibrary.Contains(tokenNameBox.Text))
            {
                MessageBox.Show("A token with that name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //when token objects have been made change this method
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
