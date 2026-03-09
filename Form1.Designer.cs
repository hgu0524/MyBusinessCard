namespace MyBusinessCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 22.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(477, 137);
            label1.Name = "label1";
            label1.Size = new Size(222, 94);
            label1.TabIndex = 1;
            label1.Text = "홍근우";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(477, 250);
            label2.Name = "label2";
            label2.Size = new Size(164, 45);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터SW";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(477, 327);
            label3.Name = "label3";
            label3.Size = new Size(329, 45);
            label3.TabIndex = 3;
            label3.Text = "hgu0524@gmail.com";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(477, 467);
            button1.Name = "button1";
            button1.Size = new Size(445, 101);
            button1.TabIndex = 4;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(864, 142);
            button2.Name = "button2";
            button2.Size = new Size(246, 63);
            button2.TabIndex = 5;
            button2.Text = "Instagram";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.Location = new Point(106, 600);
            button3.Name = "button3";
            button3.Size = new Size(321, 73);
            button3.TabIndex = 6;
            button3.Text = "사진 바꾸기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 740);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
