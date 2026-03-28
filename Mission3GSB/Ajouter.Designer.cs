namespace Mission3GSB
{
    partial class Ajouter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAdresseVisiteur = new System.Windows.Forms.ComboBox();
            this.cmbVilleVisiteur = new System.Windows.Forms.ComboBox();
            this.cmbPrenomVisiteur = new System.Windows.Forms.ComboBox();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSourceAjouter = new System.Windows.Forms.BindingSource(this.components);
            this.gsb2025DataSet = new Mission3GSB.gsb2025DataSet();
            this.cmbNomVisiteur = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrenomMedecin = new System.Windows.Forms.ComboBox();
            this.cmbNomMedecin = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNomMedicament = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listbMedicament = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.btnValiderAdd = new System.Windows.Forms.Button();
            this.visiteurTableAdapter = new Mission3GSB.gsb2025DataSetTableAdapters.visiteurTableAdapter();
            this.rapportfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportTableAdapter = new Mission3GSB.gsb2025DataSetTableAdapters.rapportTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceAjouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportfk1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAdresseVisiteur);
            this.groupBox1.Controls.Add(this.cmbVilleVisiteur);
            this.groupBox1.Controls.Add(this.cmbPrenomVisiteur);
            this.groupBox1.Controls.Add(this.cmbNomVisiteur);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordonnées Visiteurs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // cmbAdresseVisiteur
            // 
            this.cmbAdresseVisiteur.FormattingEnabled = true;
            this.cmbAdresseVisiteur.Location = new System.Drawing.Point(398, 151);
            this.cmbAdresseVisiteur.Name = "cmbAdresseVisiteur";
            this.cmbAdresseVisiteur.Size = new System.Drawing.Size(187, 24);
            this.cmbAdresseVisiteur.TabIndex = 3;
            // 
            // cmbVilleVisiteur
            // 
            this.cmbVilleVisiteur.FormattingEnabled = true;
            this.cmbVilleVisiteur.Location = new System.Drawing.Point(148, 152);
            this.cmbVilleVisiteur.Name = "cmbVilleVisiteur";
            this.cmbVilleVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cmbVilleVisiteur.TabIndex = 2;
            // 
            // cmbPrenomVisiteur
            // 
            this.cmbPrenomVisiteur.DataSource = this.visiteurBindingSource;
            this.cmbPrenomVisiteur.FormattingEnabled = true;
            this.cmbPrenomVisiteur.Location = new System.Drawing.Point(398, 69);
            this.cmbPrenomVisiteur.Name = "cmbPrenomVisiteur";
            this.cmbPrenomVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cmbPrenomVisiteur.TabIndex = 1;
            // 
            // visiteurBindingSource
            // 
            this.visiteurBindingSource.DataMember = "visiteur";
            this.visiteurBindingSource.DataSource = this.bdgSourceAjouter;
            // 
            // bdgSourceAjouter
            // 
            this.bdgSourceAjouter.DataSource = this.gsb2025DataSet;
            this.bdgSourceAjouter.Position = 0;
            // 
            // gsb2025DataSet
            // 
            this.gsb2025DataSet.DataSetName = "gsb2025DataSet";
            this.gsb2025DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNomVisiteur
            // 
            this.cmbNomVisiteur.DataSource = this.visiteurBindingSource;
            this.cmbNomVisiteur.FormattingEnabled = true;
            this.cmbNomVisiteur.Location = new System.Drawing.Point(148, 69);
            this.cmbNomVisiteur.Name = "cmbNomVisiteur";
            this.cmbNomVisiteur.Size = new System.Drawing.Size(121, 24);
            this.cmbNomVisiteur.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbPrenomMedecin);
            this.groupBox2.Controls.Add(this.cmbNomMedecin);
            this.groupBox2.Location = new System.Drawing.Point(37, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 75);
            this.groupBox2.TabIndex = 1;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cmbNomMedicament);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.listbMedicament);
            this.groupBox3.Location = new System.Drawing.Point(476, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 389);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Médicaments";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(29, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNomMedicament
            // 
            this.cmbNomMedicament.FormattingEnabled = true;
            this.cmbNomMedicament.Location = new System.Drawing.Point(169, 102);
            this.cmbNomMedicament.Name = "cmbNomMedicament";
            this.cmbNomMedicament.Size = new System.Drawing.Size(121, 24);
            this.cmbNomMedicament.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nom Médicament";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantité";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // listbMedicament
            // 
            this.listbMedicament.FormattingEnabled = true;
            this.listbMedicament.ItemHeight = 16;
            this.listbMedicament.Location = new System.Drawing.Point(29, 220);
            this.listbMedicament.Name = "listbMedicament";
            this.listbMedicament.Size = new System.Drawing.Size(131, 164);
            this.listbMedicament.TabIndex = 0;
            this.listbMedicament.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 411);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Motif";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(125, 482);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(205, 22);
            this.txtMotif.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 546);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Bilan";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(125, 546);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(205, 175);
            this.txtBilan.TabIndex = 13;
            // 
            // btnValiderAdd
            // 
            this.btnValiderAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnValiderAdd.Location = new System.Drawing.Point(171, 767);
            this.btnValiderAdd.Name = "btnValiderAdd";
            this.btnValiderAdd.Size = new System.Drawing.Size(101, 36);
            this.btnValiderAdd.TabIndex = 14;
            this.btnValiderAdd.Text = "VALIDER";
            this.btnValiderAdd.UseVisualStyleBackColor = false;
            this.btnValiderAdd.Click += new System.EventHandler(this.btnValiderAdd_Click);
            // 
            // visiteurTableAdapter
            // 
            this.visiteurTableAdapter.ClearBeforeFill = true;
            // 
            // rapportfk1BindingSource
            // 
            this.rapportfk1BindingSource.DataMember = "rapport_fk1";
            this.rapportfk1BindingSource.DataSource = this.visiteurBindingSource;
            // 
            // rapportTableAdapter
            // 
            this.rapportTableAdapter.ClearBeforeFill = true;
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 830);
            this.Controls.Add(this.btnValiderAdd);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ajouter";
            this.Text = "Ajouter un rapport";
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceAjouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb2025DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportfk1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAdresseVisiteur;
        private System.Windows.Forms.ComboBox cmbVilleVisiteur;
        private System.Windows.Forms.ComboBox cmbPrenomVisiteur;
        private System.Windows.Forms.ComboBox cmbNomVisiteur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrenomMedecin;
        private System.Windows.Forms.ComboBox cmbNomMedecin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbNomMedicament;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listbMedicament;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Button btnValiderAdd;
        private System.Windows.Forms.BindingSource bdgSourceAjouter;
        private gsb2025DataSet gsb2025DataSet;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private gsb2025DataSetTableAdapters.visiteurTableAdapter visiteurTableAdapter;
        private System.Windows.Forms.BindingSource rapportfk1BindingSource;
        private gsb2025DataSetTableAdapters.rapportTableAdapter rapportTableAdapter;
    }
}