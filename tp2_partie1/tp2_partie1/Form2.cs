﻿#region MÉTADONNÉES
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
    public partial class Form2 : Form
    {
        #region ATTRIBUTS

        private SoundPlayer _s = new SoundPlayer(tp2_partie1.Properties.Resources.btnCliquer);


         #endregion

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.imgDeck.Hide();
            this.tblDeck.Hide();
        }

        /// <summary>
        /// Visualiser un deck soit sous forme  d’images 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImages_Click(object sender, EventArgs e)
        {
            this.tblDeck.Hide();
            this.imgDeck.Show();
            this._s.Play(); //Joue du sons 
        }

        /// <summary>
        /// Visualiser un deck soit sous forme  tabulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTablaux_Click(object sender, EventArgs e)
        {
            this.tblDeck.Show();
            this.imgDeck.Hide();
            this._s.Play(); //Joue du sons 
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            this._s.Play(); //Joue du sons 


        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this._s.Play(); //Joue du sons 
        }


    }
}
