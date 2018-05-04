using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS446_Project_LivePrototype
{
    // ========================================================

    public enum TokenType
    {
        Player,
        Enemy,
        NPC
    }

  // ========================================================

    // Struct to hold basic token data
    public struct TokenData
    {
        private string name;
        private TokenType tokenType;
        private int maxHP;
        private int currentHP;

        public int ArmorClass;
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;

        public TokenData(string name, TokenType tokenType)
        {
            this.name = name;
            this.tokenType = tokenType;

            this.maxHP = 100;
            this.currentHP = 100;
            this.ArmorClass = 10;
            this.Strength = 10;
            this.Dexterity = 10;
            this.Constitution = 10;
            this.Intelligence = 10;
            this.Wisdom = 10;
            this.Charisma = 10;
        }

        // Copy constructor
        public TokenData(ref TokenData other)
        {
            this.name = other.Name;
            this.tokenType = other.TokenType;

            this.maxHP = other.MaxHP;
            this.currentHP = other.CurrentHP;
            this.ArmorClass = other.ArmorClass;
            this.Strength = other.Strength;
            this.Dexterity = other.Dexterity;
            this.Constitution = other.Constitution;
            this.Intelligence = other.Intelligence;
            this.Wisdom = other.Wisdom;
            this.Charisma = other.Charisma;
        }

        public string Name
        {
            get { return this.name;  }
        }

        public TokenType TokenType
        {
            get { return this.tokenType; }
        }

        public int MaxHP
        {
            get { return this.maxHP; }
            set
            {
                // Ensure max hp is at least 1
                this.maxHP = value > 0 ? value : 1;

                // Ensure current hp is less than or equal to max hp
                this.currentHP = Math.Min(this.currentHP, this.maxHP);
            }
        }

        public int CurrentHP
        {
            get { return this.currentHP; }
            set
            {
                // Ensure current hp is at least 0
                this.currentHP = value >= 0 ? value : 0;

                // Ensure current hp is less than or equal to max hp
                this.currentHP = Math.Min(this.currentHP, this.maxHP);
            }
        }
    }

    // ========================================================

    public enum TokenMouseState
    {
        Idle,
        Hover,
        Drag
    }

    public class MapToken
    {
        public static readonly Color COLOR_IDLE = Color.Red;
        public static readonly Color COLOR_HOVER = Color.Yellow;
        public static readonly Color COLOR_DRAG = Color.Green;

        protected MapControl mapCtrl;
        protected TokenData tokenData;
        protected TokenMouseState mouseState = TokenMouseState.Idle;
        protected PointF position;
        protected float scale = 1.0f;

        public MapToken(MapControl mapCtrl, ref TokenData tokenData, PointF mapPosition)
        {
            this.mapCtrl = mapCtrl;
            this.tokenData = new TokenData(ref tokenData);
            this.position = mapPosition;
        }

        // Copy constructor
        public MapToken(MapToken other)
        {
            TokenData otherTokenData = other.GetTokenData();

            this.mapCtrl = other.mapCtrl;
            this.tokenData = new TokenData(ref otherTokenData);
            this.position = other.Position;
        }

        public TokenData GetTokenData()
        {
            return this.tokenData;
        }

        public void SetTokenData(ref TokenData otherData)
        {
            this.tokenData = new TokenData(ref otherData);
        }

        public PointF Position
        {
            get { return this.position; }
            set
            {
                RectangleF worldRect = mapCtrl.GetWorldUnitRect();
                PointF newPos = value;

                // Make sure token is within the bounds of the map
                if (mapCtrl.HasBackground && !worldRect.Contains(newPos))
                {
                    // Move token back onto map
                    newPos.X = Math.Min(Math.Max(0, newPos.X), worldRect.Width);
                    newPos.Y = Math.Min(Math.Max(0, newPos.Y), worldRect.Height);
                }

                if (!position.Equals(newPos))
                {
                    mapCtrl.RedrawNeeded = true;
                    this.position = newPos;
                }
            }
        }

        // Draws the token using the given graphics
        public void Draw(Graphics graphics, ref RectangleF viewportRect)
        {
            RectangleF tokenRect = GetUnitRect();

            // Token is offscreen, so no need to draw it
            if (!viewportRect.IntersectsWith(tokenRect)) { return; }

            Rectangle pixelRect = mapCtrl.UnitRectToPixelRect(tokenRect, viewportRect);

            Color drawColor = Color.White;

            switch (mouseState)
            {
                case TokenMouseState.Idle:
                    drawColor = COLOR_IDLE;
                    break;
                case TokenMouseState.Hover:
                    drawColor = COLOR_HOVER;
                    break;
                case TokenMouseState.Drag:
                    drawColor = COLOR_DRAG;
                    break;
            }

            SolidBrush brush = new SolidBrush(drawColor);

            // Placeholder graphics.
            // TODO: Draw token image
            graphics.FillEllipse(brush, pixelRect);
        }

        public RectangleF GetUnitRect()
        {
            RectangleF unitRect = new RectangleF();

            unitRect.Width = this.scale;
            unitRect.Height = this.scale;

            unitRect.X = position.X - (unitRect.Width / 2); // Center Rect over X pos
            unitRect.Y = position.Y - (unitRect.Height / 2); // Center Rect over Y pos

            return unitRect;
        }

        public TokenMouseState MouseState
        {
            get { return mouseState; }
            set
            {
                if (mouseState != value)
                {
                    mapCtrl.RedrawNeeded = true;
                    mouseState = value;
                }
            }
        }
    }
}
