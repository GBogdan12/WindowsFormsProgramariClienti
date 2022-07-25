namespace WindowsFormsApplication1
{
    partial class FormClienti
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
            this.btnActClient = new System.Windows.Forms.Button();
            this.txtboxTelefon = new System.Windows.Forms.TextBox();
            this.txtboxMail = new System.Windows.Forms.TextBox();
            this.lblTelefonClient = new System.Windows.Forms.Label();
            this.lblMailClient = new System.Windows.Forms.Label();
            this.txtboxPrenume = new System.Windows.Forms.TextBox();
            this.txtboxNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActClient
            // 
            this.btnActClient.Location = new System.Drawing.Point(43, 199);
            this.btnActClient.Name = "btnActClient";
            this.btnActClient.Size = new System.Drawing.Size(75, 23);
            this.btnActClient.TabIndex = 30;
            this.btnActClient.Text = "Actualizeaza";
            this.btnActClient.UseVisualStyleBackColor = true;
            this.btnActClient.Click += new System.EventHandler(this.btnActClient_Click);
            // 
            // txtboxTelefon
            // 
            this.txtboxTelefon.Location = new System.Drawing.Point(131, 151);
            this.txtboxTelefon.Name = "txtboxTelefon";
            this.txtboxTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtboxTelefon.TabIndex = 29;
            // 
            // txtboxMail
            // 
            this.txtboxMail.Location = new System.Drawing.Point(131, 124);
            this.txtboxMail.Name = "txtboxMail";
            this.txtboxMail.Size = new System.Drawing.Size(100, 20);
            this.txtboxMail.TabIndex = 28;
            // 
            // lblTelefonClient
            // 
            this.lblTelefonClient.AutoSize = true;
            this.lblTelefonClient.Location = new System.Drawing.Point(54, 154);
            this.lblTelefonClient.Name = "lblTelefonClient";
            this.lblTelefonClient.Size = new System.Drawing.Size(43, 13);
            this.lblTelefonClient.TabIndex = 27;
            this.lblTelefonClient.Text = "Telefon";
            // 
            // lblMailClient
            // 
            this.lblMailClient.AutoSize = true;
            this.lblMailClient.Location = new System.Drawing.Point(54, 124);
            this.lblMailClient.Name = "lblMailClient";
            this.lblMailClient.Size = new System.Drawing.Size(26, 13);
            this.lblMailClient.TabIndex = 26;
            this.lblMailClient.Text = "Mail";
            // 
            // txtboxPrenume
            // 
            this.txtboxPrenume.Location = new System.Drawing.Point(131, 91);
            this.txtboxPrenume.Name = "txtboxPrenume";
            this.txtboxPrenume.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrenume.TabIndex = 25;
            // 
            // txtboxNume
            // 
            this.txtboxNume.Location = new System.Drawing.Point(131, 64);
            this.txtboxNume.Name = "txtboxNume";
            this.txtboxNume.Size = new System.Drawing.Size(100, 20);
            this.txtboxNume.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nume";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(152, 26);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 21;
            this.lblClient.Text = "Client";
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(155, 199);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(75, 23);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnActClient);
            this.Controls.Add(this.txtboxTelefon);
            this.Controls.Add(this.txtboxMail);
            this.Controls.Add(this.lblTelefonClient);
            this.Controls.Add(this.lblMailClient);
            this.Controls.Add(this.txtboxPrenume);
            this.Controls.Add(this.txtboxNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClient);
            this.Name = "FormClienti";
            this.ShowIcon = false;
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.FormClienti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActClient;
        private System.Windows.Forms.TextBox txtboxTelefon;
        private System.Windows.Forms.TextBox txtboxMail;
        private System.Windows.Forms.Label lblTelefonClient;
        private System.Windows.Forms.Label lblMailClient;
        private System.Windows.Forms.TextBox txtboxPrenume;
        private System.Windows.Forms.TextBox txtboxNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnRenunta;
    }
}