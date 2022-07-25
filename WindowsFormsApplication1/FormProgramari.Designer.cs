namespace WindowsFormsApplication1
{
    partial class FormProgramari
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
            this.lblNumeProg = new System.Windows.Forms.Label();
            this.lblPrenProg = new System.Windows.Forms.Label();
            this.lblDataProg = new System.Windows.Forms.Label();
            this.lblServiciuProg = new System.Windows.Forms.Label();
            this.txtboxNume = new System.Windows.Forms.TextBox();
            this.txtboxPrenume = new System.Windows.Forms.TextBox();
            this.txtboxServiciu = new System.Windows.Forms.TextBox();
            this.btnActualizeazaProg = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeProg
            // 
            this.lblNumeProg.AutoSize = true;
            this.lblNumeProg.Location = new System.Drawing.Point(25, 33);
            this.lblNumeProg.Name = "lblNumeProg";
            this.lblNumeProg.Size = new System.Drawing.Size(35, 13);
            this.lblNumeProg.TabIndex = 1;
            this.lblNumeProg.Text = "Nume";
            this.lblNumeProg.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrenProg
            // 
            this.lblPrenProg.AutoSize = true;
            this.lblPrenProg.Location = new System.Drawing.Point(25, 60);
            this.lblPrenProg.Name = "lblPrenProg";
            this.lblPrenProg.Size = new System.Drawing.Size(49, 13);
            this.lblPrenProg.TabIndex = 2;
            this.lblPrenProg.Text = "Prenume";
            // 
            // lblDataProg
            // 
            this.lblDataProg.AutoSize = true;
            this.lblDataProg.Location = new System.Drawing.Point(25, 168);
            this.lblDataProg.Name = "lblDataProg";
            this.lblDataProg.Size = new System.Drawing.Size(30, 13);
            this.lblDataProg.TabIndex = 3;
            this.lblDataProg.Text = "Data";
            // 
            // lblServiciuProg
            // 
            this.lblServiciuProg.AutoSize = true;
            this.lblServiciuProg.Location = new System.Drawing.Point(25, 139);
            this.lblServiciuProg.Name = "lblServiciuProg";
            this.lblServiciuProg.Size = new System.Drawing.Size(45, 13);
            this.lblServiciuProg.TabIndex = 5;
            this.lblServiciuProg.Text = "Serviciu";
            // 
            // txtboxNume
            // 
            this.txtboxNume.Location = new System.Drawing.Point(102, 30);
            this.txtboxNume.Name = "txtboxNume";
            this.txtboxNume.Size = new System.Drawing.Size(280, 20);
            this.txtboxNume.TabIndex = 6;
            this.txtboxNume.TextChanged += new System.EventHandler(this.txtboxNume_TextChanged);
            // 
            // txtboxPrenume
            // 
            this.txtboxPrenume.Location = new System.Drawing.Point(102, 57);
            this.txtboxPrenume.Name = "txtboxPrenume";
            this.txtboxPrenume.Size = new System.Drawing.Size(280, 20);
            this.txtboxPrenume.TabIndex = 7;
            // 
            // txtboxServiciu
            // 
            this.txtboxServiciu.Location = new System.Drawing.Point(102, 136);
            this.txtboxServiciu.Name = "txtboxServiciu";
            this.txtboxServiciu.Size = new System.Drawing.Size(280, 20);
            this.txtboxServiciu.TabIndex = 9;
            // 
            // btnActualizeazaProg
            // 
            this.btnActualizeazaProg.Location = new System.Drawing.Point(246, 215);
            this.btnActualizeazaProg.Name = "btnActualizeazaProg";
            this.btnActualizeazaProg.Size = new System.Drawing.Size(116, 23);
            this.btnActualizeazaProg.TabIndex = 10;
            this.btnActualizeazaProg.Text = "Actualizeaza";
            this.btnActualizeazaProg.UseVisualStyleBackColor = true;
            this.btnActualizeazaProg.Click += new System.EventHandler(this.btnActualizeazaProg_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(28, 215);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(116, 23);
            this.btnRenunta.TabIndex = 11;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(102, 162);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(280, 20);
            this.dtpData.TabIndex = 12;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(102, 110);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(280, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(102, 83);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 20);
            this.txtMail.TabIndex = 15;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(25, 113);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 14;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(25, 86);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail";
            // 
            // FormProgramari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(394, 270);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnActualizeazaProg);
            this.Controls.Add(this.txtboxServiciu);
            this.Controls.Add(this.txtboxPrenume);
            this.Controls.Add(this.txtboxNume);
            this.Controls.Add(this.lblServiciuProg);
            this.Controls.Add(this.lblDataProg);
            this.Controls.Add(this.lblPrenProg);
            this.Controls.Add(this.lblNumeProg);
            this.Name = "FormProgramari";
            this.ShowIcon = false;
            this.Text = "Programari";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeProg;
        private System.Windows.Forms.Label lblPrenProg;
        private System.Windows.Forms.Label lblDataProg;
        private System.Windows.Forms.Label lblServiciuProg;
        private System.Windows.Forms.TextBox txtboxNume;
        private System.Windows.Forms.TextBox txtboxPrenume;
        private System.Windows.Forms.TextBox txtboxServiciu;
        private System.Windows.Forms.Button btnActualizeazaProg;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMail;
    }
}