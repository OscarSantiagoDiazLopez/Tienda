﻿namespace WinFormsTienda
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
            textBoxUSUARIO.Location = new Point(1014, 370);
            textBoxUSUARIO.Name = "textBoxUSUARIO";
            textBoxUSUARIO.Size = new Size(625, 46);
            textBoxUSUARIO.TabIndex = 1;
            // 
            // textBoxCONTRASENA
            // 
            textBoxCONTRASENA.Font = new Font("Rockwell", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCONTRASENA.Location = new Point(1014, 498);
            textBoxCONTRASENA.Name = "textBoxCONTRASENA";
            textBoxCONTRASENA.Size = new Size(625, 46);
            textBoxCONTRASENA.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(1018, 334);
            label2.Name = "label2";
            label2.Size = new Size(153, 33);
            label2.TabIndex = 4;
            label2.Text = "USUARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(1018, 463);
            label3.Name = "label3";
            label3.Size = new Size(228, 33);
            label3.TabIndex = 5;
            label3.Text = "CONTRASEÑA:";
            // 
            // bottonINICIAR
            // 
            bottonINICIAR.BackColor = Color.Gold;
            bottonINICIAR.FlatStyle = FlatStyle.Popup;
            bottonINICIAR.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            bottonINICIAR.ForeColor = SystemColors.ActiveCaptionText;
            bottonINICIAR.Location = new Point(1014, 619);
            bottonINICIAR.Name = "bottonINICIAR";
            bottonINICIAR.Size = new Size(305, 66);
            bottonINICIAR.TabIndex = 7;
            bottonINICIAR.Text = "INICIAR";
            bottonINICIAR.UseVisualStyleBackColor = false;
            // 
            // buttonSALIR
            // 
            buttonSALIR.BackColor = Color.Gold;
            buttonSALIR.FlatStyle = FlatStyle.Popup;
            buttonSALIR.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSALIR.ForeColor = SystemColors.ActiveCaptionText;
            buttonSALIR.Location = new Point(1334, 619);
            buttonSALIR.Name = "buttonSALIR";
            buttonSALIR.Size = new Size(305, 66);
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
            buttonINVITADO.Location = new Point(1178, 823);
            buttonINVITADO.Name = "buttonINVITADO";
            buttonINVITADO.Size = new Size(301, 66);
            buttonINVITADO.TabIndex = 9;
            buttonINVITADO.Text = "ENTRAR COMO INVITADO";
            buttonINVITADO.UseVisualStyleBackColor = false;
            // 
            // FormLOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login1;
            ClientSize = new Size(1884, 986);
            Controls.Add(buttonINVITADO);
            Controls.Add(buttonSALIR);
            Controls.Add(bottonINICIAR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxCONTRASENA);
            Controls.Add(textBoxUSUARIO);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
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