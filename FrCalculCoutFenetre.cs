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
    public partial class FrCalculCoutFenetre : Form
    {

        ClasseTissu DBTissue = new ClasseTissu();
        ClasseModele DBRideau = new ClasseModele();

        public FrCalculCoutFenetre()
        {
            InitializeComponent();
        }

        private void FrCalculCoutFenetre_Load(object sender, EventArgs e)
        {
            LB_Tissue.DataSource = DBTissue.SQLTissus();
            LB_Tissue.DisplayMember = "NOMTYPETISSU";
            LB_Tissue.ValueMember = "REFTYPETISSU";
            LB_Tissue.SelectedIndex = 0;


            LB_Modele.DataSource = DBRideau.SQLModeles();
            LB_Modele.DisplayMember = "NOMMODELE";
            LB_Modele.ValueMember = "NUMMODELE";
            LB_Modele.SelectedIndex = 0;
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal largeur = Convert.ToDecimal(TB_Largeur.Text.ToString());
            decimal hauteur = Convert.ToDecimal(TB_Hauteur.Text.ToString());
            decimal ampleur = Convert.ToDecimal(TB_Ampleur.Text.ToString());

            int numModele;
            int numTissu;
            int.TryParse(LB_Modele.SelectedValue.ToString(), out numModele);
            int.TryParse(LB_Tissue.SelectedValue.ToString(), out numTissu);
            ClasseMetierRideau metierRideau = new ClasseMetierRideau(largeur, hauteur, ampleur, numTissu, numModele);

            TB_Montant.Text = metierRideau.CoutTotal().ToString();
        }

        private void TB_Largeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != 8)
            // 8 = backspace
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void TB_Hauteur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != 8)
            // 8 = backspace
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

        }

        private void TB_Ampleur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != 8)
            // 8 = backspace
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}
