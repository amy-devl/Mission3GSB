using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3GSB
{
    public partial class Gestion : Form
    {
        gsb2025Entities gsb2025Entities = new gsb2025Entities();
        public Gestion()
        {
            InitializeComponent();
        }

        private void ajouterUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter frmAjouter = new Ajouter();
            frmAjouter.Show();
        }

        private void modifierUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier frmModifier = new Modifier();
            frmModifier.Show();
        }

        private void visualiserUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualiser frmVisualiser = new Visualiser();
            frmVisualiser.Show();
        }
    }
}
