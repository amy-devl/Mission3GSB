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
    public partial class Visualiser : Form
    {
        gsb2025Entities gsb2025Entities = new gsb2025Entities();
        gsb2025Entities mesDonneesEF;
        private string IdVisiteur;
        private string IdMedecin;
        public Visualiser()
        {
            InitializeComponent();
            mesDonneesEF = new gsb2025Entities();
            var rapports = mesDonneesEF.rapports.ToList();
            var visiteurs = mesDonneesEF.visiteurs.ToList();
            var medecins = mesDonneesEF.medecins.ToList();

            this.cmbNomVis.DataSource = visiteurs;
            this.cmbNomVis.DisplayMember = "nom";
            this.cmbNomVis.ValueMember = "id";
            this.cmbNomVis.SelectedIndex = -1;
            this.cmbPrenomVis.DataSource = visiteurs;
            this.cmbPrenomVis.DisplayMember = "prenom";
            this.cmbPrenomVis.ValueMember = "id";
            this.cmbPrenomVis.SelectedIndex = -1;

            this.cmbNomMedecin.DataSource = medecins;
            this.cmbNomMedecin.DisplayMember = "nom";
            this.cmbNomMedecin.ValueMember = "id";
            this.cmbNomMedecin.SelectedIndex = -1;
            this.cmbPrenomMedecin.DataSource = medecins;
            this.cmbPrenomMedecin.DisplayMember = "prenom";
            this.cmbPrenomMedecin.ValueMember = "id";
            this.cmbPrenomMedecin.SelectedIndex = -1;

        }

        private void Visualiser_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsb2025DataSet.rapport'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rapportTableAdapter.Fill(this.gsb2025DataSet.rapport);

        }

        private void btnVisualiser_Click(object sender, EventArgs e)
        {
            this.IdVisiteur = cmbNomVis.SelectedValue.ToString();
            this.IdMedecin = cmbNomMedecin.SelectedValue.ToString();
            var rapports = mesDonneesEF.rapports
                .Where(r => r.idVisiteur == IdVisiteur && r.idMedecin.ToString() == IdMedecin)
                .Select(r => new
                {
                    r.id,
                    r.date,
                    r.motif,
                    r.bilan,
                    r.idVisiteur,
                    r.idMedecin
                })
                .ToList();

            rapportBindingSource = new BindingSource();
            rapportBindingSource.DataSource = rapports;
            dataGridViewRapport.DataSource = rapportBindingSource;
        }

        private void GenererXml(DataTable dt)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fichier XML (*.xml)|*.xml";
            sfd.FileName = "rapports.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dt.WriteXml(sfd.FileName, XmlWriteMode.WriteSchema);
                MessageBox.Show("Fichier XML généré avec succès !");
            }
        }

        private void btnGenererXml_Click(object sender, EventArgs e)
        {
            DataTable dtRapports = GetRapports(); // méthode qui récupère les données

            // 2. Vérification
            if (dtRapports.Rows.Count == 0)
            {
                MessageBox.Show("Aucun rapport à exporter.",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // 3. Choix du fichier
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fichier XML (*.xml)|*.xml";
            sfd.FileName = "rapports.xml";

            // 4. Génération du fichier XML
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dtRapports.WriteXml(sfd.FileName, XmlWriteMode.WriteSchema);

                MessageBox.Show("Fichier XML généré avec succès !",
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private DataTable GetRapports()
        {
            DataTable dt = new DataTable("Rapports");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Motif", typeof(string));
            dt.Columns.Add("Bilan", typeof(string));
            dt.Columns.Add("IdVisiteur", typeof(string));
            dt.Columns.Add("IdMedecin", typeof(int));
            foreach (var rapport in mesDonneesEF.rapports)
            {
                DataRow row = dt.NewRow();
                row["Id"] = rapport.id;
                row["Date"] = rapport.date;
                row["Motif"] = rapport.motif;
                row["Bilan"] = rapport.bilan;
                row["IdVisiteur"] = rapport.idVisiteur;
                row["IdMedecin"] = rapport.idMedecin;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}

