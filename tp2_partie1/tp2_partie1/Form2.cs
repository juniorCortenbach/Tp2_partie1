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
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace tp2_partie1
{
    /// <summary>
    /// Formulaire de gestion de deck du héro.
    /// </summary>
    public partial class Form2 : Form
    {
        #region ATTRIBUTS

        /// <summary>
        /// Création de l'objet _s qui permet l'exécution du programme sonore.
        /// </summary>
        private SoundPlayer _s = new SoundPlayer(tp2_partie1.Properties.Resources.btnCliquer);

         #endregion

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //Retrait de l'image et du tableau du deck du formulaire.
            this.imgDeck.Hide();
            this.tblDeck.Hide();
        }

        /// <summary>
        /// Visualisation du deck (sous forme tabulaire ou d'images)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImages_Click(object sender, EventArgs e)
        {
            //Retrait de la formulaire tabulaire du deck du formulaire.
            this.tblDeck.Hide();
            //Affichage de l'image du deck plutôt que le tableau.
            this.imgDeck.Show();
            //Joue du sons 
            this._s.Play(); 
        }

        /// <summary>
        /// Visualiser un deck sous forme tabulaire ou image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTableaux_Click(object sender, EventArgs e)
        {
            //Affichage du tableau du deck plutôt que l'image.
            this.tblDeck.Show();
            //Retrait de l'image du formulaire.
            this.imgDeck.Hide();
            //Joue du son.
            this._s.Play(); 
        }

        /// <summary>
        /// Chargement des données sur le héro et des cartes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCharger_Click(object sender, EventArgs e)
        {
            //Joue du son.
            this._s.Play();
        }

        /// <summary>
        /// Enregistrement du deck dans un fichier .xml dans un dossier deck.
        /// Nom du fichier est déterminé en fonction du nom du deck
        /// sans boîte de dialogue de Windows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //Joue du son.
            this._s.Play(); 
        }
    }
}
