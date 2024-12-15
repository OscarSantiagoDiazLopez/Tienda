namespace WinFormsTienda
{
    partial class FormPORTADA
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(404, 865);
            button1.Name = "button1";
            button1.Size = new Size(254, 60);
            button1.TabIndex = 0;
            button1.Text = "COMENZAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormPORTADA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.portada;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPORTADA";
            Text = "PORTADA";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
