using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS446_Project_LivePrototype
{
    public class TokenHoverToolTip : ToolTip
    {
        private TokenData tokData;

        public TokenHoverToolTip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        public void SetTokenData(ref TokenData data)
        {
            tokData = new TokenData(ref data);
        }

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            e.ToolTipSize = new Size(200, 75);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {
            Graphics g = e.Graphics;

            drawBackground(g, e.Bounds);
            drawStringWithShadow(g, tokData.Name, e.Font, new PointF(10, 10), Brushes.Gold);
            drawHP(g, e.Font, new PointF(10, 30), e.Bounds);
            drawAC(g, e.Font, new PointF(10, 50), e.Bounds);
        }

        private void drawHP(Graphics g, Font font, PointF pos, Rectangle tooltipBounds)
        {
            SizeF lblSize = g.MeasureString("HP: ", font);
            drawStringWithShadow(g, "HP: ", font, pos, Brushes.White);

            Rectangle hpBarRect = new Rectangle();
            hpBarRect.X = (int)(pos.X + lblSize.Width + 5);
            hpBarRect.Y = (int)pos.Y;
            hpBarRect.Width = (int)(tooltipBounds.Width - hpBarRect.X - pos.X - 5);
            hpBarRect.Height = (int)lblSize.Height;

            float curHpRatio = (float)tokData.CurrentHP / tokData.MaxHP;

            Rectangle hpCurrentRect = hpBarRect;
            hpCurrentRect.Width = (int)(curHpRatio * hpCurrentRect.Width);
            hpCurrentRect.Width = Math.Max(hpCurrentRect.Width, 1);

            using (LinearGradientBrush b = new LinearGradientBrush(hpCurrentRect,
                Color.FromArgb(51, 51, 51), Color.FromArgb(221, 24, 24), LinearGradientMode.Horizontal))
            {
                Pen pen = new Pen(Brushes.Black, 1);

                g.FillRectangle(Brushes.White, hpBarRect);
                g.FillRectangle(b, hpCurrentRect);

                g.DrawRectangle(pen, new Rectangle(hpBarRect.X, hpBarRect.Y,
                    hpBarRect.Width, hpBarRect.Height));
            }
        }

        private void drawAC(Graphics g, Font font, PointF pos, Rectangle tooltipBounds)
        {
            drawStringWithShadow(g, "Armor Class: " + tokData.ArmorClass, font, pos, Brushes.White);
        }

        private void drawBackground(Graphics g, Rectangle rect)
        {
            using (LinearGradientBrush b = new LinearGradientBrush(rect,
                Color.FromArgb(109, 213, 237), Color.FromArgb(33, 147, 176), LinearGradientMode.Vertical))
            {
                g.FillRectangle(b, rect);

                g.DrawRectangle(new Pen(Brushes.White, 1), new Rectangle(rect.X, rect.Y,
                    rect.Width - 1, rect.Height - 1));
            }
        }

        private void drawStringWithShadow(Graphics g, string text, Font font, PointF pos, Brush brush)
        {
            PointF shadowPos = new PointF(pos.X + 1, pos.Y + 1);

            g.DrawString(text, font, Brushes.Black, shadowPos); // shadow layer
            g.DrawString(text, font, brush, pos); // top layer
        }
    }
}
