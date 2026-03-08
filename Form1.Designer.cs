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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(431, 31);
            label1.Name = "label1";
            label1.Size = new Size(122, 46);
            label1.TabIndex = 1;
            label1.Text = "김태연";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(431, 120);
            label2.Name = "label2";
            label2.Size = new Size(269, 35);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터학부(컴퓨터SW)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(431, 191);
            label3.Name = "label3";
            label3.Size = new Size(334, 35);
            label3.TabIndex = 3;
            label3.Text = "jenniferkim0704@naver.com";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(501, 343);
            button1.Name = "button1";
            button1.Size = new Size(170, 57);
            button1.TabIndex = 4;
            button1.Text = "배경색 랜덤 변경";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
