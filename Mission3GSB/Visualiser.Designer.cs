namespace Mission3GSB
{
    partial class Visualiser
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewRapport = new System.Windows.Forms.DataGridView();
            this.gsb2025DataSet = new Mission3GSB.gsb2025DataSet();
            this.rapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportTableAdapter = new Mission3GSB.gsb2025DataSetTableAdapters.rapportTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNomVis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPrenomVis = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrenomMedecin = new System.Windows.Forms.ComboBox();
            this.cmbNomMedecin = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisualiser = new System.Windows.Forms.Button();
            this.btnGenererXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRapport
            // 
            this.dataGridViewRapport.AutoGenerateColumns = false;
            this.dataGridViewRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn});
            this.dataGridViewRapport.DataSource = this.rapportBindingSource;
            this.dataGridViewRapport.Location = new System.Drawing.Point(43, 350);
            this.dataGridViewRapport.Name = "dataGridViewRapport";
            this.dataGridViewRapport.RowHeadersWidth = 51;
            this.dataGridViewRapport.RowTemplate.Height = 24;
            this.dataGridViewRapport.Size = new System.Drawing.Size(802, 339);
            this.dataGridViewRapport.TabIndex = 1;
            // 
            // gsb2025DataSet
            // 
            this.gsb2025DataSet.DataSetName = "gsb2025DataSet";
            this.gsb2025DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapportBindingSource
            // 
            this.rapportBindingSource.DataMember = "rapport";
            this.rapportBindingSource.DataSource = this.gsb2025DataSet;
            // 
            // rapportTableAdapter
            // 
            this.rapportTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.Width = 125;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            this.bilanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            this.idVisiteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // cmbNomVis
            // 
            this.cmbNomVis.FormattingEnabled = true;
            this.cmbNomVis.Location = new System.Drawing.Point(191, 66);
            this.cmbNomVis.Name = "cmbNomVis";
            this.cmbNomVis.Size = new System.Drawing.Size(121, 24);
            this.cmbNomVis.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom";
            // 
            // cmbPrenomVis
            // 
            this.cmbPrenomVis.FormattingEnabled = true;
            this.cmbPrenomVis.Location = new System.Drawing.Point(191, 124);
            this.cmbPrenomVis.Name = "cmbPrenomVis";
            this.cmbPrenomVis.Size = new System.Drawing.Size(121, 24);
            this.cmbPrenomVis.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbPrenomMedecin);
            this.groupBox2.Controls.Add(this.cmbNomMedecin);
            this.groupBox2.Location = new System.Drawing.Point(43, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordonnées Médecins ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom";
            // 
            // cmbPrenomMedecin
            // 
            this.cmbPrenomMedecin.FormattingEnabled = true;
            this.cmbPrenomMedecin.Location = new System.Drawing.Point(424, 40);
            this.cmbPrenomMedecin.Name = "cmbPrenomMedecin";
            this.cmbPrenomMedecin.Size = new System.Drawing.Size(121, 24);
            this.cmbPrenomMedecin.TabIndex = 9;
            // 
            // cmbNomMedecin
            // 
            this.cmbNomMedecin.FormattingEnabled = true;
            this.cmbNomMedecin.Location = new System.Drawing.Point(148, 40);
            this.cmbNomMedecin.Name = "cmbNomMedecin";
            this.cmbNomMedecin.Size = new System.Drawing.Size(121, 24);
            this.cmbNomMedecin.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // btnVisualiser
            // 
            this.btnVisualiser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVisualiser.Location = new System.Drawing.Point(43, 289);
            this.btnVisualiser.Name = "btnVisualiser";
            this.btnVisualiser.Size = new System.Drawing.Size(132, 33);
            this.btnVisualiser.TabIndex = 13;
            this.btnVisualiser.Text = "Visualiser";
            this.btnVisualiser.UseVisualStyleBackColor = false;
            this.btnVisualiser.Click += new System.EventHandler(this.btnVisualiser_Click);
            // 
            // btnGenererXml
            // 
            this.btnGenererXml.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenererXml.Location = new System.Drawing.Point(43, 725);
            this.btnGenererXml.Name = "btnGenererXml";
            this.btnGenererXml.Size = new System.Drawing.Size(209, 43);
            this.btnGenererXml.TabIndex = 14;
            this.btnGenererXml.Text = "Géner un fichier XML";
            this.btnGenererXml.UseVisualStyleBackColor = false;
            this.btnGenererXml.Click += new System.EventHandler(this.btnGenererXml_Click);
            // 
            // Visualiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 790);
            this.Controls.Add(this.btnGenererXml);
            this.Controls.Add(this.btnVisualiser);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPrenomVis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNomVis);
            this.Controls.Add(this.dataGridViewRapport);
            this.Name = "Visualiser";
            this.Text = "Visualiser";
            this.Load += new System.EventHandler(this.Visualiser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRapport;
        private gsb2025DataSet gsb2025DataSet;
        private System.Windows.Forms.BindingSource rapportBindingSource;
        private gsb2025DataSetTableAdapters.rapportTableAdapter rapportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNomVis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPrenomVis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrenomMedecin;
        private System.Windows.Forms.ComboBox cmbNomMedecin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVisualiser;
        private System.Windows.Forms.Button btnGenererXml;
    }
}