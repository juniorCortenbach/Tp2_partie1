#region MÉTADONNÉES
/* Nom du fichier         : A CHANGER
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 30 mars 2016
 */
#endregion

#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace tp2_partie1
{
    public class Deck
    {
        #region ATTRIBUTS

        /// <summary>
        /// 
        /// </summary>
        private string _nomDeck;


        private Heros _hero;

        private Cartes[] _tabCartes;

        #endregion

        #region PROPRIÉTÉS

        public string NomDeck
        {
            get { return this._nomDeck; }
            set { this._nomDeck = value; }
        }

        public Heros Hero
        {
            get { return this._hero; }
            set { this._hero = value; }
        }

        public Cartes[] TabCartes
        {
            get { return this._tabCartes; }
            set { this._tabCartes = value; }
        }

        #endregion


        #region MÉTHODE

        /// <summary>
        /// Enregistrer un deck dans un fichier au format XML.
        /// </summary>
        public void EnregistrerDeck()
        {

        }

        public void ModifierNom()
        {

        }

        public void AjouterNouvelleCarte()
        {

        }

        public void SupprimerToutesLesCartes()
        {
            ModifierQuantiteCarte(0);
        }


        public void ModifierQuantiteCarte(int nbCartes)
        {

        }


        /// <summary>
        /// Faire une recherche de cartes en limitant automatiquement celle-ci aux cartes pouvant être incluses dans le deck et, à partir du résultat de la recherche, permettre l’ajout d’une carte dans le deck si c’est encore possible (nombre maximal de copies non atteint).
        /// </summary>
        /// <returns></returns>
        public Cartes[] RechercheCartes()
        {
            return null;
        }


        #endregion

    }
}
