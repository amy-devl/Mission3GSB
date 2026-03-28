using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3GSB
{
    public partial class Ajouter : Form
    {
        gsb2025Entities gsb2025Entities = new gsb2025Entities();
        private gsb2025Entities mesDonneesEF;
        public Ajouter()
        {
            InitializeComponent();
            mesDonneesEF = new gsb2025Entities();
            this.bdgSourceAjouter.DataSource = mesDonneesEF.rapports.ToList();
            var visiteurs = mesDonneesEF.visiteurs.ToList();
            this.cmbNomVisiteur.DataSource = visiteurs;
            this.cmbNomVisiteur.DisplayMember = "nom";
            this.cmbNomVisiteur.ValueMember = "id";
            this.cmbNomVisiteur.SelectedIndex = -1;
            this.cmbPrenomVisiteur.DataSource = visiteurs;
            this.cmbPrenomVisiteur.DisplayMember = "prenom";
            this.cmbPrenomVisiteur.ValueMember = "id";
            this.cmbPrenomVisiteur.SelectedIndex = -1;

            this.cmbVilleVisiteur.DataSource = visiteurs;   
            this.cmbVilleVisiteur.DisplayMember = "ville";
            this.cmbVilleVisiteur.ValueMember = "id";
            this.cmbVilleVisiteur.SelectedIndex = -1;

            this.cmbAdresseVisiteur.DataSource = visiteurs;
            this.cmbAdresseVisiteur.DisplayMember = "adresse";
            this.cmbAdresseVisiteur.ValueMember = "id";
            this.cmbAdresseVisiteur.SelectedIndex = -1;

            var medecins = mesDonneesEF.medecins.ToList();
            this.cmbNomMedecin.DataSource = medecins;
            this.cmbNomMedecin.DisplayMember = "nom";
            this.cmbNomMedecin.ValueMember = "id";
            this.cmbNomMedecin.SelectedIndex = -1;
            this.cmbPrenomMedecin.DataSource = medecins;
            this.cmbPrenomMedecin.DisplayMember = "prenom";
            this.cmbPrenomMedecin.ValueMember = "id";
            this.cmbPrenomMedecin.SelectedIndex = -1;

            var medicaments = mesDonneesEF.medicaments.ToList();
            this.cmbNomMedicament.DataSource = medicaments;
            this.cmbNomMedicament.DisplayMember = "nom_commercial";
            this.cmbNomMedicament.ValueMember = "id";
            this.cmbNomMedicament.SelectedIndex = -1;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsb2025DataSet.rapport'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rapportTableAdapter.Fill(this.gsb2025DataSet.rapport);
            // TODO: cette ligne de code charge les données dans la table 'gsb2025DataSet.visiteur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.visiteurTableAdapter.Fill(this.gsb2025DataSet.visiteur);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbMedicament.Items.Add(cmbNomMedicament.Text);
            listbMedicament.SelectedIndex = listbMedicament.Items.Count - 1;
            listbMedicament.Items.Add(numericUpDown1.Value.ToString());
        }

        private void btnValiderAdd_Click(object sender, EventArgs e)
        {
            rapport nouveauRapport = new rapport();
            nouveauRapport.idVisiteur = (string)cmbNomVisiteur.SelectedValue;
            nouveauRapport.idMedecin = (int)cmbNomMedecin.SelectedValue;
            nouveauRapport.date = dateTimePicker1.Value;
            nouveauRapport.bilan = txtBilan.Text;
            nouveauRapport.motif = txtMotif.Text;
            nouveauRapport.id = mesDonneesEF.rapports.Max(r => r.id) + 1;
            mesDonneesEF.rapports.Add(nouveauRapport);
            mesDonneesEF.SaveChanges();
            MessageBox.Show("Rapport ajouté avec succès !");
        }
    }
}
    