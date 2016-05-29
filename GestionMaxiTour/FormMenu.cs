using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMaxiTour
{
    public partial class FormMenu : Form
    {

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }


        private void factureTSMI_Click(object sender, EventArgs e)
        {
            FormFacture ffact = new FormFacture();
            ffact.ShowDialog();
        }

        private void devisTSMI_Click(object sender, EventArgs e)
        {
            FormDevis fdevis = new FormDevis();
            fdevis.ShowDialog();
        }

        private void imprevusTSMI_Click(object sender, EventArgs e)
        {
            FormImprevu fimprevu = new FormImprevu();
            fimprevu.ShowDialog();

        }
    }
}
