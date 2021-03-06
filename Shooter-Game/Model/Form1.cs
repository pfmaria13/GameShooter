using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Model
{
    public partial class Model : Form
    {
        bool goLeft, goRight, gameOver, shooting;
        int score;
        readonly int playerSpeed = 20;
        int enemySpeed;
        int bulletSpeed;
        readonly Random random = new Random();
        public PictureBox enemy1;
        public PictureBox enemy2;
        public PictureBox enemy3;
        Timer gameTimer = new Timer { Interval = 10 };
        Label countScore;
        public PictureBox bullet;
        public PictureBox player;
        private readonly Label nameScore;
        private PictureBox gameOverText;

        private void GameTimerEvent(object sender, EventArgs e)
        {
            countScore.Text = score.ToString();
            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;
            enemy3.Top += enemySpeed;
            if (enemy1.Top > 700 || enemy2.Top > 700 || enemy3.Top > 700)
                GameOver();
            MovementLogic();
            bulletSpeed = (shooting) ? 20 : 0;
            if (shooting) bullet.Top -= bulletSpeed; else bullet.Left = -300;
            if (bullet.Top < -30)
                shooting = false;
            HittingTheEnemy(enemy1, 450);
            HittingTheEnemy(enemy2, 650);
            HittingTheEnemy(enemy3, 750);
            if (score == 10)
                enemySpeed = 10;
            if (score == 20)
                enemySpeed = 15;
        }

        private void HittingTheEnemy(PictureBox enemy, int distance)
        {
            if (bullet.Bounds.IntersectsWith(enemy.Bounds))
            {
                score += 1;
                enemy.Top = -distance;
                enemy.Left = random.Next(20, 600);
                shooting = false;
            }
        }

        private void MovementLogic()
        {
            if (goLeft && player.Left > 0)
                player.Left -= playerSpeed;
            if (goRight && player.Right < 688)
                player.Left += playerSpeed;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = true;
                    break;
                case Keys.Right:
                    goRight = true;
                    break;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = false;
                    break;
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.Space:
                    if (!shooting)
                    {
                        shooting = true;
                        bullet.Top = player.Top - 30;
                        bullet.Left = player.Left + (player.Width / 2);
                    }
                    break;
                case Keys.Enter:
                    if (gameOver)
                    {
                        gameOverText.Image = null;
                        enemy1.BringToFront();
                        enemy2.BringToFront();
                        enemy3.BringToFront();
                        ResetGame();
                    }
                    break;
            }
        }

        private void ResetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;
            enemy1.Left = random.Next(20, 600);
            enemy2.Left = random.Next(20, 600);
            enemy3.Left = random.Next(20, 600);
            enemy1.Top = random.Next(0, 200) * -1;
            enemy2.Top = random.Next(0, 500) * -1;
            enemy3.Top = random.Next(0, 900) * -1;
            bullet.Left = -300;
            score = 0;
            bulletSpeed = 0;
            shooting = false;
            countScore.Text = score.ToString();
        }

        private void GameOver()
        {
            gameOver = true;
            gameTimer.Stop();
            gameOverText.Image = Image.FromFile("C:/Users/Apple/source/repos/Shooter-Game/Shooter-Game/Resources/text1.png");
            gameOverText.BringToFront();
        }

        public Model()
        {
            KeyDown += new KeyEventHandler(KeyIsDown);
            KeyUp += new KeyEventHandler(KeyIsUp);
            InitializeComponent();
            ResetGame();
        }
    }
}
