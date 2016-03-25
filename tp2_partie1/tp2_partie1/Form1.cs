/* Nom du fichier         : A CHANGER
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 30 mars 2016
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2_partie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.imgCartes.Hide();
            this.tblCarte.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.imgCartes.Show();
            this.tblCarte.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tblCarte.Show();
            this.imgCartes.Hide();
        }
    }
}
