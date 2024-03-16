namespace WinFormsApp1
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
            label1 = new Label();
            textBox1 = new TextBox();
            btn_Red = new Button();
            btn_Blue = new Button();
            btn_Pink = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 180);
            label1.Name = "label1";
            label1.Size = new Size(377, 59);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Name:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(884, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 65);
            textBox1.TabIndex = 1;
            // 
            // btn_Red
            // 
            btn_Red.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold);
            btn_Red.Location = new Point(409, 562);
            btn_Red.Name = "btn_Red";
            btn_Red.Size = new Size(251, 129);
            btn_Red.TabIndex = 2;
            btn_Red.Text = "Red";
            btn_Red.UseVisualStyleBackColor = true;
            btn_Red.Click += btn_Red_Click;
            // 
            // btn_Blue
            // 
            btn_Blue.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold);
            btn_Blue.Location = new Point(807, 562);
            btn_Blue.Name = "btn_Blue";
            btn_Blue.Size = new Size(251, 129);
            btn_Blue.TabIndex = 3;
            btn_Blue.Text = "Blue";
            btn_Blue.UseVisualStyleBackColor = true;
            btn_Blue.Click += btn_Blue_Click;
            // 
            // btn_Pink
            // 
            btn_Pink.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold);
            btn_Pink.Location = new Point(1188, 562);
            btn_Pink.Name = "btn_Pink";
            btn_Pink.Size = new Size(251, 129);
            btn_Pink.TabIndex = 4;
            btn_Pink.Text = "Pink";
            btn_Pink.UseVisualStyleBackColor = true;
            btn_Pink.Click += btn_Pink_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1869, 979);
            Controls.Add(btn_Pink);
            Controls.Add(btn_Blue);
            Controls.Add(btn_Red);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btn_Red;
        private Button btn_Blue;
        private Button btn_Pink;
    }
}
