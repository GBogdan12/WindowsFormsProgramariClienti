namespace WindowsFormsApplication1
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdaugaProg = new System.Windows.Forms.Button();
            this.btnStergeProg = new System.Windows.Forms.Button();
            this.btnActualizeazaProg = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.TabControl();
            this.tpProgramari = new System.Windows.Forms.TabPage();
            this.dgProgramari = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serviciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpClienti = new System.Windows.Forms.TabPage();
            this.dgClienti = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReincarca = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tc.SuspendLayout();
            this.tpProgramari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramari)).BeginInit();
            this.tpClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugaProg
            // 
            this.btnAdaugaProg.Location = new System.Drawing.Point(21, 479);
            this.btnAdaugaProg.Name = "btnAdaugaProg";
            this.btnAdaugaProg.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaProg.TabIndex = 4;
            this.btnAdaugaProg.Text = "Adauga";
            this.btnAdaugaProg.UseVisualStyleBackColor = true;
            this.btnAdaugaProg.Click += new System.EventHandler(this.btnAdaugaProg_Click);
            // 
            // btnStergeProg
            // 
            this.btnStergeProg.Location = new System.Drawing.Point(197, 479);
            this.btnStergeProg.Name = "btnStergeProg";
            this.btnStergeProg.Size = new System.Drawing.Size(75, 23);
            this.btnStergeProg.TabIndex = 5;
            this.btnStergeProg.Text = "Sterge";
            this.btnStergeProg.UseVisualStyleBackColor = true;
            this.btnStergeProg.Click += new System.EventHandler(this.btnStergeProg_Click);
            // 
            // btnActualizeazaProg
            // 
            this.btnActualizeazaProg.Location = new System.Drawing.Point(116, 479);
            this.btnActualizeazaProg.Name = "btnActualizeazaProg";
            this.btnActualizeazaProg.Size = new System.Drawing.Size(75, 23);
            this.btnActualizeazaProg.TabIndex = 6;
            this.btnActualizeazaProg.Text = "Actualizeaza";
            this.btnActualizeazaProg.UseVisualStyleBackColor = true;
            this.btnActualizeazaProg.Click += new System.EventHandler(this.btnActualizeazaProg_Click);
            // 
            // tc
            // 
            this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc.Controls.Add(this.tpProgramari);
            this.tc.Controls.Add(this.tpClienti);
            this.tc.Location = new System.Drawing.Point(12, 59);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(756, 414);
            this.tc.TabIndex = 7;
            // 
            // tpProgramari
            // 
            this.tpProgramari.Controls.Add(this.dgProgramari);
            this.tpProgramari.Location = new System.Drawing.Point(4, 22);
            this.tpProgramari.Name = "tpProgramari";
            this.tpProgramari.Padding = new System.Windows.Forms.Padding(3);
            this.tpProgramari.Size = new System.Drawing.Size(748, 388);
            this.tpProgramari.TabIndex = 0;
            this.tpProgramari.Text = "Programari";
            this.tpProgramari.UseVisualStyleBackColor = true;
            // 
            // dgProgramari
            // 
            this.dgProgramari.AllowUserToAddRows = false;
            this.dgProgramari.AllowUserToDeleteRows = false;
            this.dgProgramari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProgramari.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProgramari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgProgramari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProgramari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Serviciu,
            this.Client,
            this.Telefon});
            this.dgProgramari.Location = new System.Drawing.Point(6, 6);
            this.dgProgramari.Name = "dgProgramari";
            this.dgProgramari.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProgramari.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgProgramari.RowHeadersWidth = 42;
            this.dgProgramari.Size = new System.Drawing.Size(736, 376);
            this.dgProgramari.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Serviciu
            // 
            this.Serviciu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Serviciu.DataPropertyName = "Serviciu";
            this.Serviciu.HeaderText = "Serviciu";
            this.Serviciu.Name = "Serviciu";
            this.Serviciu.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // tpClienti
            // 
            this.tpClienti.Controls.Add(this.dgClienti);
            this.tpClienti.Location = new System.Drawing.Point(4, 22);
            this.tpClienti.Name = "tpClienti";
            this.tpClienti.Padding = new System.Windows.Forms.Padding(3);
            this.tpClienti.Size = new System.Drawing.Size(748, 388);
            this.tpClienti.TabIndex = 1;
            this.tpClienti.Text = "Clienti";
            this.tpClienti.UseVisualStyleBackColor = true;
            this.tpClienti.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgClienti
            // 
            this.dgClienti.AllowUserToAddRows = false;
            this.dgClienti.AllowUserToDeleteRows = false;
            this.dgClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClienti.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dgClienti.Location = new System.Drawing.Point(6, 6);
            this.dgClienti.Name = "dgClienti";
            this.dgClienti.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClienti.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgClienti.RowHeadersWidth = 42;
            this.dgClienti.Size = new System.Drawing.Size(736, 376);
            this.dgClienti.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnReincarca
            // 
            this.btnReincarca.Location = new System.Drawing.Point(665, 13);
            this.btnReincarca.Name = "btnReincarca";
            this.btnReincarca.Size = new System.Drawing.Size(103, 23);
            this.btnReincarca.TabIndex = 8;
            this.btnReincarca.Text = "Reincarca";
            this.btnReincarca.UseVisualStyleBackColor = true;
            this.btnReincarca.Click += new System.EventHandler(this.btnReincarca_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(12, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 549);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnReincarca);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.btnActualizeazaProg);
            this.Controls.Add(this.btnStergeProg);
            this.Controls.Add(this.btnAdaugaProg);
            this.Name = "Home";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc.ResumeLayout(false);
            this.tpProgramari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramari)).EndInit();
            this.tpClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaProg;
        private System.Windows.Forms.Button btnStergeProg;
        private System.Windows.Forms.Button btnActualizeazaProg;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpProgramari;
        private System.Windows.Forms.TabPage tpClienti;
        private System.Windows.Forms.Button btnReincarca;
        private System.Windows.Forms.DataGridView dgClienti;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serviciu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgProgramari;
    }
}

