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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.imgDeck.Hide();
            this.tblDeck.Hide();
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            this.tblDeck.Hide();
            this.imgDeck.Show();
        }

        private void btnTablaux_Click(object sender, EventArgs e)
        {
            this.tblDeck.Show();
            this.imgDeck.Hide();
        }


    }
}
