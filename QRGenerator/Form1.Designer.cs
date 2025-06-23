namespace QRGenerator
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 66);
            label1.Name = "label1";
            label1.Size = new Size(345, 61);
            label1.TabIndex = 1;
            label1.Text = "QR Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 230);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter your link , text here";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Desktop;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(274, 291);
            button1.Name = "button1";
            button1.Size = new Size(292, 69);
            button1.TabIndex = 3;
            button1.Text = "Generate";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(209, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 459);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(136, 11);
            label3.Name = "label3";
            label3.Size = new Size(132, 31);
            label3.TabIndex = 3;
            label3.Text = "All Done...";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            button3.Location = new Point(166, 401);
            button3.Name = "button3";
            button3.Size = new Size(197, 46);
            button3.TabIndex = 2;
            button3.Text = "Download";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            button2.Location = new Point(26, 401);
            button2.Name = "button2";
            button2.Size = new Size(107, 46);
            button2.TabIndex = 1;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(26, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 455);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 5;
            label4.Text = "By @jafar1011";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 483);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QR Generator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}
