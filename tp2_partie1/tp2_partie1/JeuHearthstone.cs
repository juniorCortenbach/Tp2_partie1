#region MÉTADONNÉES
/* Nom du fichier         : JeuHearthstone
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
    public class JeuHearthstone
    {
        #region CONSTANTES
        /// <summary>
        /// Constante qui contient le fichier xml qui contient les cartes et les héros
        /// </summary>
        public const string FichierCartesHeros = "cards-collectible.xml";  
        #endregion

        #region ATTRIBUTS

        /// <summary>
        /// Tableaux de decks
        /// </summary>
        private Deck[] _lesDecksDuJeu;

        /// <summary>
        /// Tableaux d'héros
        /// </summary>
        private Heros[] _lesHerosDeReference;

        /// <summary>
        /// Tableaux de carte
        /// </summary>
        private Cartes[] _lesCartesDeReferences;

        #endregion

        #region CONSTRUCTEUR
        /// <summary>
        /// Constructeur non paramétrés 
        /// </summary>
        public JeuHearthstone()
        {

        }


       #endregion

        #region ACCESSEURS
        /// <summary>
        /// Retourne un Tableaux d'héros 
        /// </summary>
        public Heros[] LesHeros
        {
            get { return this._lesHerosDeReference; }
            private set { this._lesHerosDeReference = value; }
        }
        /// <summary>
        /// Retourne un Tableaux de Cartes
        /// </summary>
        public Deck[] LesDecks
        {
            get { return this._lesDecksDuJeu; }
            private set { this._lesDecksDuJeu = value; }
        }

        /// <summary>
        /// Tableaux de carte
        /// </summary>
        public Cartes[] LesCartes
        {
            get { return this._lesCartesDeReferences; }
            set { this._lesCartesDeReferences = value; }
        }

        #endregion

       #region MÉTHODE

        /// <summary>
        /// Au démarrage, les données sur les héros doivent être chargées dans des tableaux d’objets, et ce, à partir du fichier XML fourni.
        /// </summary>
        /// <returns></returns>
        public Heros[] ChargerXmlHeros()
        {
            return null;
        }
        /// <summary>
        /// Au démarrage, les données sur les cartes de Hearthstone doivent être chargées dans des tableaux d’objets, et ce, à partir du fichier XML fourni.
        /// </summary>
        /// <returns></returns>
        public Cartes[] ChargeXmlCartes()
        {
            return null;
        }

        /// <summary>
        /// Créer un nouveau deck en respectant les règles de conception décrites
        /// </summary>
        /// <returns></returns>
        public Deck[] AjouterUnDeck()
        {
            return null;
        }

        #endregion
    }
}
