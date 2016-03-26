#region MÉTADONNÉES
/* Nom du fichier         : A CHANGER
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 30 mars 2016
 */
#endregion


#region USING

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //Permet d'utiliser la class media

#endregion



namespace tp2_partie1
{
    public partial class Form1 : Form
    {

        #region ATTRIBUTS

        private SoundPlayer _joueurDeSons;

        private SoundPlayer _s = new SoundPlayer(tp2_partie1.Properties.Resources.btnCliquer);

        #endregion


        public Form1()
        {
            InitializeComponent();
            this._joueurDeSons = new SoundPlayer("btnCliquer.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.imgCartes.Hide();
            this.tblCarte.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tblCarte.Show();
            this.imgCartes.Hide();
            this._s.Play(); //Joue du sons 
        }

        private void btnCher_Click(object sender, EventArgs e)
        {
            this._s.Play(); //Joue du sons 
        }

        private void btnImages_Click_1(object sender, EventArgs e)
        {
            this.imgCartes.Show();
            this.tblCarte.Hide();
            this._s.Play(); //Joue du sons 
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.imgCartes.Show();
            this.tblCarte.Hide();
            this._s.Play(); //Joue du sons
            //Nouveaux Formulaire
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnCréer_Click(object sender, EventArgs e)
        {
            this._s.Play(); //Joue du sons
            //Nouveaux Formulaire
            Form2 f2 = new Form2();
            f2.Show();

        }
    }
}
