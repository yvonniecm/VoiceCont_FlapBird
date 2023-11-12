namespace VoiceCont_FlapBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            button1 = new Button();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            bird = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            good1 = new PictureBox();
            good2 = new PictureBox();
            bad1 = new PictureBox();
            gameoverlogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)good1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)good2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bad1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameoverlogo).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 7);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(345, 23);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(502, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 1;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(365, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // bird
            // 
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(34, 244);
            bird.Name = "bird";
            bird.Size = new Size(34, 24);
            bird.SizeMode = PictureBoxSizeMode.AutoSize;
            bird.TabIndex = 3;
            bird.TabStop = false;
            bird.Click += pictureBox1_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // good1
            // 
            good1.BackColor = Color.Transparent;
            good1.Image = Properties.Resources.pipe_green;
            good1.Location = new Point(199, 233);
            good1.Name = "good1";
            good1.Size = new Size(52, 239);
            good1.TabIndex = 4;
            good1.TabStop = false;
            good1.Click += pictureBox1_Click_1;
            // 
            // good2
            // 
            good2.BackColor = Color.Transparent;
            good2.Image = Properties.Resources.pipe_green;
            good2.Location = new Point(451, 300);
            good2.Name = "good2";
            good2.Size = new Size(52, 172);
            good2.TabIndex = 5;
            good2.TabStop = false;
            // 
            // bad1
            // 
            bad1.BackColor = Color.Transparent;
            bad1.Image = (Image)resources.GetObject("bad1.Image");
            bad1.Location = new Point(695, 153);
            bad1.Name = "bad1";
            bad1.Size = new Size(52, 319);
            bad1.TabIndex = 6;
            bad1.TabStop = false;
            bad1.Click += pictureBox1_Click_2;
            // 
            // gameoverlogo
            // 
            gameoverlogo.BackColor = Color.Transparent;
            gameoverlogo.Image = Properties.Resources.gameover;
            gameoverlogo.Location = new Point(273, 86);
            gameoverlogo.Name = "gameoverlogo";
            gameoverlogo.Size = new Size(190, 46);
            gameoverlogo.TabIndex = 7;
            gameoverlogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.background_day;
            ClientSize = new Size(750, 473);
            Controls.Add(gameoverlogo);
            Controls.Add(bad1);
            Controls.Add(good2);
            Controls.Add(good1);
            Controls.Add(bird);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)good1).EndInit();
            ((System.ComponentModel.ISupportInitialize)good2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bad1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameoverlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox bird;
        private System.Windows.Forms.Timer timer2;
        private PictureBox good1;
        private PictureBox good2;
        private PictureBox bad1;
        private PictureBox gameoverlogo;
    }
}