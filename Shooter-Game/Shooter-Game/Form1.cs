using Chronic;
using Shooter_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooter_Game
{
    public partial class Form1 : Form
    { 
        public static PictureBox enemy1 = new PictureBox()
        {
            BackColor = Color.Transparent,
            Image = Resources.enemy,
            Location = new Point(115, -30),
            Size = new Size(72, 97)
        };

        public static PictureBox enemy2 = new PictureBox()
        {
            BackColor = Color.Transparent,
            Image = Resources.enemy,
            Location = new Point(380, -30),
            Size = new Size(72, 97)
        };

        public static PictureBox enemy3 = new PictureBox()
        {
            BackColor = Color.Transparent,
            Image = Resources.enemy,
            Location = new Point(650, -30),
            Size = new Size(72, 97)
        };

        static Label countScore = new Label
        {
            BackColor = Color.Transparent,
            Location = new Point(98, 610),
            Size = new Size(63, 40),
            Text = "0",
            Font = new Font(
              new FontFamily("Arial"),
               30,
               FontStyle.Regular,
               GraphicsUnit.Pixel)
        };
        static public PictureBox bullet = new PictureBox
        {
            Image = Resources.bullet,
            Size = new Size(19, 30),
            Location = new Point(402, 490),
            BackColor = Color.Transparent
        };

        public static PictureBox player = new PictureBox
        {
            BackColor = Color.Transparent,
            Image = Resources.player,
            Location = new Point(369, 550),
            Size = new Size(91, 99)
        };

        private static Label nameScore = new Label
        {
            Location = new Point(2, 610),
            Size = new Size(100, 39),
            BackColor = Color.Transparent,
            Text = "Score:",
            Font = new Font(
              new FontFamily("Arial"),
               30,
               FontStyle.Regular,
               GraphicsUnit.Pixel)
        };

        private static PictureBox gameOverText = new PictureBox
        {
            BackColor = Color.Transparent,
            Location = new Point(145, 260),
            Size = new Size(540, 130)
        };

        public Form1()
        {
            BackgroundImage = Resources.sky;
            Controls.Add(player);
            Controls.Add(bullet);
            Controls.Add(enemy1);
            Controls.Add(enemy2);
            Controls.Add(enemy3);
            Controls.Add(nameScore);
            Controls.Add(gameOverText);
            Controls.Add(countScore);
            InitializeComponent();  
        }
    }
}
