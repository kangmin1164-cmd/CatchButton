namespace CatchButton
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
            Catch_Button = new Button();
            SuspendLayout();
            // 
            // Catch_Button
            // 
            Catch_Button.BackColor = Color.FromArgb(128, 255, 255);
            Catch_Button.Font = new Font("한컴 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Catch_Button.ForeColor = Color.Navy;
            Catch_Button.Location = new Point(341, 164);
            Catch_Button.Name = "Catch_Button";
            Catch_Button.Size = new Size(137, 62);
            Catch_Button.TabIndex = 0;
            Catch_Button.Text = "나를 잡아봐";
            Catch_Button.UseVisualStyleBackColor = false;
            Catch_Button.Click += Catch_Button_Click;
            Catch_Button.MouseDown += Catch_Button_MouseDown;
            Catch_Button.MouseEnter += Catch_Button_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Catch_Button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Catch_Button;
    }
}
