/* Nom du fichier         : JeuHearthstone
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 30 mars 2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_partie1
{
    class JeuHearthstone
    {
        #region CONSTANTES
        /// <summary>
        /// Constante qui contient le fichier xml qui contient les cartes et les héros
        /// </summary>
        public const string FichierCartesHeros = "cards-collectible.xml";  
        #endregion

        #region ATTRIBUTS

        /// <summary>
        /// Tableaux d'héros
        /// </summary>
        private Heros[] _lesHeros;

        /// <summary>
        /// Tableaux de cartes
        /// </summary>
        private Cartes[] _lesCartes;


        #endregion

        #region CONSTRUCTEUR
        /// <summary>
        /// Constructeur non paramétrés 
        /// </summary>
        public JeuHearthstone()
        {
            this._lesCartes = Utilitaire.ChargerCartes("cards-collectible.xml");
        //    this._lesHeros = Utilitaire.ChargerHeros("cards-collectible.xml");

        }


       #endregion

        #region ACCESSEURS
        /// <summary>
        /// Retourne un Tableaux d'héros 
        /// </summary>
        public Heros[] LesHeros
        {
            get { return this._lesHeros; }
            private set { this._lesHeros = value; }
        }
        /// <summary>
        /// Retourne un Tableaux de Cartes
        /// </summary>
        public Cartes[] LesCartes
        {
            get { return this._lesCartes; }
            private set { this._lesCartes = value; }
        }


       #endregion
    }
}
