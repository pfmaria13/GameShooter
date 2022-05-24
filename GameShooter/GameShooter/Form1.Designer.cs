
namespace GameShooter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.countScore = new System.Windows.Forms.Label();
            this.nameScore = new System.Windows.Forms.Label();
            this.gameOverText = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // countScore
            // 
            this.countScore.BackColor = System.Drawing.Color.Transparent;
            this.countScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countScore.Location = new System.Drawing.Point(98, 610);
            this.countScore.Name = "countScore";
            this.countScore.Size = new System.Drawing.Size(63, 39);
            this.countScore.TabIndex = 1;
            this.countScore.Text = "0";
            // 
            // nameScore
            // 
            this.nameScore.BackColor = System.Drawing.Color.Transparent;
            this.nameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameScore.Location = new System.Drawing.Point(2, 610);
            this.nameScore.Name = "nameScore";
            this.nameScore.Size = new System.Drawing.Size(100, 39);
            this.nameScore.TabIndex = 2;
            this.nameScore.Text = "Score:";
            // 
            // gameOverText
            // 
            this.gameOverText.BackColor = System.Drawing.Color.Transparent;
            this.gameOverText.Location = new System.Drawing.Point(145, 260);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(540, 130);
            this.gameOverText.TabIndex = 7;
            this.gameOverText.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::GameShooter.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(369, 550);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(91, 99);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::GameShooter.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(402, 490);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(19, 30);
            this.bullet.TabIndex = 6;
            this.bullet.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Image = global::GameShooter.Properties.Resources.enemy;
            this.enemy3.InitialImage = global::GameShooter.Properties.Resources.enemy;
            this.enemy3.Location = new System.Drawing.Point(647, -30);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(72, 97);
            this.enemy3.TabIndex = 5;
            this.enemy3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::GameShooter.Properties.Resources.enemy;
            this.enemy1.InitialImage = global::GameShooter.Properties.Resources.enemy;
            this.enemy1.Location = new System.Drawing.Point(115, -30);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(72, 97);
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::GameShooter.Properties.Resources.enemy;
            this.enemy2.InitialImage = global::GameShooter.Properties.Resources.enemy;
            this.enemy2.Location = new System.Drawing.Point(379, -30);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(72, 97);
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.nameScore);
            this.Controls.Add(this.countScore);
            this.Controls.Add(this.gameOverText);
            this.Name = "Form1";
            this.Text = "Shooter Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameOverText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label countScore;
        private System.Windows.Forms.Label nameScore;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox gameOverText;
    }
}

