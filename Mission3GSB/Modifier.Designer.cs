namespace Mission3GSB
{
    partial class Modifier
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
            this.btnValider = new System.Windows.Forms.Button();
            this.cmbNomVis = new System.Windows.Forms.ComboBox();
            this.cmbPrenomVis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bdgSourceRapport = new System.Windows.Forms.BindingSource(this.components);
            this.gsb2025DataSet1 = new Mission3GSB.gsb2025DataSet1();
            this.rapportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rapportTableAdapter = new Mission3GSB.gsb2025DataSet1TableAdapters.rapportTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.rapportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource2)).BeginInit();
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
            this.dataGridViewRapport.DataSource = this.rapportBindingSource1;
            this.dataGridViewRapport.Location = new System.Drawing.Point(23, 289);
            this.dataGridViewRapport.Name = "dataGridViewRapport";
            this.dataGridViewRapport.RowHeadersWidth = 51;
            this.dataGridViewRapport.RowTemplate.Height = 24;
            this.dataGridViewRapport.Size = new System.Drawing.Size(802, 339);
            this.dataGridViewRapport.TabIndex = 0;
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
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(106, 232);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(95, 31);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cmbNomVis
            // 
            this.cmbNomVis.FormattingEnabled = true;
            this.cmbNomVis.Location = new System.Drawing.Point(161, 78);
            this.cmbNomVis.Name = "cmbNomVis";
            this.cmbNomVis.Size = new System.Drawing.Size(121, 24);
            this.cmbNomVis.TabIndex = 2;
            // 
            // cmbPrenomVis
            // 
            this.cmbPrenomVis.FormattingEnabled = true;
            this.cmbPrenomVis.Location = new System.Drawing.Point(161, 131);
            this.cmbPrenomVis.Name = "cmbPrenomVis";
            this.cmbPrenomVis.Size = new System.Drawing.Size(121, 24);
            this.cmbPrenomVis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // bdgSourceRapport
            // 
            this.bdgSourceRapport.DataSource = this.gsb2025DataSet1;
            this.bdgSourceRapport.Position = 0;
            // 
            // gsb2025DataSet1
            // 
            this.gsb2025DataSet1.DataSetName = "gsb2025DataSet1";
            this.gsb2025DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapportBindingSource1
            // 
            this.rapportBindingSource1.DataMember = "rapport";
            this.rapportBindingSource1.DataSource = this.bdgSourceRapport;
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
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(312, 649);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(178, 40);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // rapportBindingSource2
            // 
            this.rapportBindingSource2.DataMember = "rapport";
            this.rapportBindingSource2.DataSource = this.bdgSourceRapport;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 717);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPrenomVis);
            this.Controls.Add(this.cmbNomVis);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dataGridViewRapport);
            this.Name = "Modifier";
            this.Text = "Modifier un rapport";
            this.Load += new System.EventHandler(this.Modifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRapport;
        private gsb2025DataSet gsb2025DataSet;
        private System.Windows.Forms.BindingSource rapportBindingSource;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cmbNomVis;
        private System.Windows.Forms.ComboBox cmbPrenomVis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdgSourceRapport;
        private gsb2025DataSet1 gsb2025DataSet1;
        private System.Windows.Forms.BindingSource rapportBindingSource1;
        private gsb2025DataSet1TableAdapters.rapportTableAdapter rapportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.BindingSource rapportBindingSource2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}