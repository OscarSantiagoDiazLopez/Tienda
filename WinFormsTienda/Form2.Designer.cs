namespace WinFormsTienda
{
    partial class FormLOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUSUARIO = new TextBox();
            textBoxCONTRASENA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            bottonINICIAR = new Button();
            buttonSALIR = new Button();
            buttonINVITADO = new Button();
            SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            textBoxUSUARIO.Font = new Font("Rockwell", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUSUARIO.Location = new Point(887, 278);
            textBoxUSUARIO.Margin = new Padding(3, 2, 3, 2);
            textBoxUSUARIO.Name = "textBoxUSUARIO";
            textBoxUSUARIO.Size = new Size(547, 39);
            textBoxUSUARIO.TabIndex = 1;
            // 
            // textBoxCONTRASENA
            // 
            textBoxCONTRASENA.Font = new Font("Rockwell", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCONTRASENA.Location = new Point(887, 374);
            textBoxCONTRASENA.Margin = new Padding(3, 2, 3, 2);
            textBoxCONTRASENA.Name = "textBoxCONTRASENA";
            textBoxCONTRASENA.Size = new Size(547, 39);
            textBoxCONTRASENA.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(891, 250);
            label2.Name = "label2";
            label2.Size = new Size(121, 27);
            label2.TabIndex = 4;
            label2.Text = "USUARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(891, 347);
            label3.Name = "label3";
            label3.Size = new Size(178, 27);
            label3.TabIndex = 5;
            label3.Text = "CONTRASEÑA:";
            // 
            // bottonINICIAR
            // 
            bottonINICIAR.BackColor = Color.Gold;
            bottonINICIAR.FlatStyle = FlatStyle.Popup;
            bottonINICIAR.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            bottonINICIAR.ForeColor = SystemColors.ActiveCaptionText;
            bottonINICIAR.Location = new Point(887, 464);
            bottonINICIAR.Margin = new Padding(3, 2, 3, 2);
            bottonINICIAR.Name = "bottonINICIAR";
            bottonINICIAR.Size = new Size(267, 50);
            bottonINICIAR.TabIndex = 7;
            bottonINICIAR.Text = "INICIAR";
            bottonINICIAR.UseVisualStyleBackColor = false;
            bottonINICIAR.Click += bottonINICIAR_Click_1;
            // 
            // buttonSALIR
            // 
            buttonSALIR.BackColor = Color.Gold;
            buttonSALIR.FlatStyle = FlatStyle.Popup;
            buttonSALIR.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSALIR.ForeColor = SystemColors.ActiveCaptionText;
            buttonSALIR.Location = new Point(1167, 464);
            buttonSALIR.Margin = new Padding(3, 2, 3, 2);
            buttonSALIR.Name = "buttonSALIR";
            buttonSALIR.Size = new Size(267, 50);
            buttonSALIR.TabIndex = 8;
            buttonSALIR.Text = "SALIR";
            buttonSALIR.UseVisualStyleBackColor = false;
            buttonSALIR.Click += buttonSALIR_Click;
            // 
            // buttonINVITADO
            // 
            buttonINVITADO.BackColor = Color.Transparent;
            buttonINVITADO.FlatAppearance.BorderSize = 0;
            buttonINVITADO.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonINVITADO.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonINVITADO.FlatStyle = FlatStyle.Flat;
            buttonINVITADO.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonINVITADO.ForeColor = Color.Black;
            buttonINVITADO.Location = new Point(1031, 617);
            buttonINVITADO.Margin = new Padding(3, 2, 3, 2);
            buttonINVITADO.Name = "buttonINVITADO";
            buttonINVITADO.Size = new Size(263, 50);
            buttonINVITADO.TabIndex = 9;
            buttonINVITADO.Text = "ENTRAR COMO INVITADO";
            buttonINVITADO.UseVisualStyleBackColor = false;
            // 
            // FormLOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login1;
            ClientSize = new Size(1648, 740);
            Controls.Add(buttonINVITADO);
            Controls.Add(buttonSALIR);
            Controls.Add(bottonINICIAR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxCONTRASENA);
            Controls.Add(textBoxUSUARIO);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLOGIN";
            Text = "FormLOGIN";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUSUARIO;
        private TextBox textBoxCONTRASENA;
        private Label label2;
        private Label label3;
        private Button bottonINICIAR;
        private Button buttonSALIR;
        private Button buttonINVITADO;
    }
}