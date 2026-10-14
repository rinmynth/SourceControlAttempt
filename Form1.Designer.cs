namespace SourceControlAttempt
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
            BtnRikka = new Button();
            SuspendLayout();
            // 
            // BtnRikka
            // 
            BtnRikka.Location = new Point(150, 167);
            BtnRikka.Name = "BtnRikka";
            BtnRikka.Size = new Size(127, 80);
            BtnRikka.TabIndex = 0;
            BtnRikka.Text = "Rikka's button";
            BtnRikka.UseVisualStyleBackColor = true;
            BtnRikka.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRikka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRikka;
    }
}
