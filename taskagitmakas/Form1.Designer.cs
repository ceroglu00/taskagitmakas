namespace taskagitmakas
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
            richTbxLog = new RichTextBox();
            lblSonuç = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBoxBot = new PictureBox();
            label2 = new Label();
            lblBotSeçim = new Label();
            label3 = new Label();
            label4 = new Label();
            lblBotSkor = new Label();
            lblOyuncuSkor = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBot).BeginInit();
            SuspendLayout();
            // 
            // richTbxLog
            // 
            richTbxLog.Location = new Point(12, 619);
            richTbxLog.Name = "richTbxLog";
            richTbxLog.Size = new Size(420, 56);
            richTbxLog.TabIndex = 2;
            richTbxLog.Text = "";
            // 
            // lblSonuç
            // 
            lblSonuç.AutoSize = true;
            lblSonuç.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSonuç.Location = new Point(268, 312);
            lblSonuç.Name = "lblSonuç";
            lblSonuç.Size = new Size(83, 28);
            lblSonuç.TabIndex = 1;
            lblSonuç.Text = "SONUÇ:";
            lblSonuç.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.taş;
            pictureBox1.Location = new Point(30, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "TAŞ";
            pictureBox1.Click += btnTaş_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.makas;
            pictureBox2.Location = new Point(30, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "MAKAS";
            pictureBox2.Click += btnTaş_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.kağıt;
            pictureBox3.Location = new Point(30, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "KAĞIT";
            pictureBox3.Click += btnTaş_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 596);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Loglar";
            // 
            // pictureBoxBot
            // 
            pictureBoxBot.Image = Properties.Resources.kağıt;
            pictureBoxBot.Location = new Point(284, 101);
            pictureBoxBot.Name = "pictureBoxBot";
            pictureBoxBot.Size = new Size(129, 147);
            pictureBoxBot.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBot.TabIndex = 3;
            pictureBoxBot.TabStop = false;
            pictureBoxBot.Tag = "KAĞIT";
            pictureBoxBot.Click += btnTaş_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 115);
            label2.Name = "label2";
            label2.Size = new Size(141, 106);
            label2.TabIndex = 1;
            label2.Text = "VS";
            // 
            // lblBotSeçim
            // 
            lblBotSeçim.AutoSize = true;
            lblBotSeçim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBotSeçim.Location = new Point(21, 344);
            lblBotSeçim.Name = "lblBotSeçim";
            lblBotSeçim.Size = new Size(135, 28);
            lblBotSeçim.TabIndex = 1;
            lblBotSeçim.Text = "Botun Seçimi: ";
            lblBotSeçim.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(248, 400);
            label3.Name = "label3";
            label3.Size = new Size(58, 38);
            label3.TabIndex = 1;
            label3.Text = "Bot";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(88, 400);
            label4.Name = "label4";
            label4.Size = new Size(113, 38);
            label4.TabIndex = 1;
            label4.Text = "Oyuncu";
            // 
            // lblBotSkor
            // 
            lblBotSkor.AutoSize = true;
            lblBotSkor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblBotSkor.Location = new Point(261, 438);
            lblBotSkor.Name = "lblBotSkor";
            lblBotSkor.Size = new Size(33, 38);
            lblBotSkor.TabIndex = 1;
            lblBotSkor.Text = "0";
            // 
            // lblOyuncuSkor
            // 
            lblOyuncuSkor.AutoSize = true;
            lblOyuncuSkor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblOyuncuSkor.Location = new Point(126, 438);
            lblOyuncuSkor.Name = "lblOyuncuSkor";
            lblOyuncuSkor.Size = new Size(33, 38);
            lblOyuncuSkor.TabIndex = 1;
            lblOyuncuSkor.Text = "0";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(157, 537);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(103, 37);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 687);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(pictureBoxBot);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTbxLog);
            Controls.Add(label2);
            Controls.Add(lblSonuç);
            Controls.Add(lblOyuncuSkor);
            Controls.Add(lblBotSkor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblBotSeçim);
            Name = "Form1";
            Text = "TAŞ - KAĞIT - MAKAS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTbxLog;
        private Label lblSonuç;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBoxBot;
        private Label label2;
        private Label lblBotSeçim;
        private Label label3;
        private Label label4;
        private Label lblBotSkor;
        private Label lblOyuncuSkor;
        private Button btnReset;
    }
}
