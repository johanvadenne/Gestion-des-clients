using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classe_Rideau;

namespace Gestion_des_clients
{
    public partial class Calcul : Form
    {
        ClasseMetierRideau metierRideau = new ClasseMetierRideau(5.5m, 9.9m, 5.8m, 1, 1);

        public Calcul()
        {
            InitializeComponent();
        }

        private void Calcul_Load(object sender, EventArgs e)
        {

            decimal total = metierRideau.CoutTotal();
            MessageBox.Show(total.ToString());
        }
    }
}
