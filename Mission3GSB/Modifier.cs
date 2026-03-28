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
    public partial class Modifier : Form
    {
        gsb2025Entities gsbEntities2025 = new gsb2025Entities();
        private gsb2025Entities mesDonneesEF;
        private string IdVisiteur;
        public Modifier()
        {
            InitializeComponent();
            this.mesDonneesEF = new gsb2025Entities();
            this.IdVisiteur = IdVisiteur;

            var visiteurs = mesDonneesEF.visiteurs.ToList();
            this.cmbNomVis.DataSource = visiteurs;
            this.cmbNomVis.DisplayMember = "nom";
            this.cmbNomVis.ValueMember = "id";
            this.cmbNomVis.SelectedIndex = -1;

            this.cmbPrenomVis.DataSource = visiteurs;
            this.cmbPrenomVis.DisplayMember = "prenom";
            this.cmbPrenomVis.ValueMember = "id";
            this.cmbPrenomVis.SelectedIndex = -1;

            
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsb2025DataSet1.rapport'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rapportTableAdapter.Fill(this.gsb2025DataSet1.rapport);


        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.IdVisiteur = cmbNomVis.SelectedValue.ToString();
            var rapports = mesDonneesEF.rapports
                .Where(r => r.idVisiteur == IdVisiteur)
                .ToList();
            rapportBindingSource = new BindingSource();
            rapportBindingSource.DataSource = rapports;
            dataGridViewRapport.DataSource = rapportBindingSource;

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            rapport nouveau = new rapport();
            nouveau.date = dateTimePicker1.Value;
            nouveau.motif = dataGridViewRapport.Text;
            nouveau.bilan = dataGridViewRapport.Text;
            mesDonneesEF.SaveChanges();
            MessageBox.Show("Rapport modifié avec succès !");
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
