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
    public class Heros
    {
        #region ATTRIBUTS

        /// <summary>
        /// Retourne l'identifiant de l'héro
        /// </summary>
        private string _identifiant;
         
        /// <summary>
        /// Retourne le nom de l'héro
        /// </summary>
        private string _nom;

        /// <summary>
        /// Retourne l'extension de l'héro
        /// </summary>
        private string _extension;

        /// <summary>
        /// Retourne la rareté de l'héro
        /// </summary>
        private string _rarete;

        /// <summary>
        /// Retourne la classe de l'héro
        /// </summary>
        private string _classHero;

        /// <summary>
        /// Retourne les points de vie de l'héro
        /// </summary>
        private byte _ptsVie;

        #endregion


        #region ACESSEURS
        
        /// <summary>
        /// Retourne l'identifiant de l'héro
        /// </summary>
        public string Identifiant
        {
            get { return this._identifiant; }
            set { this._identifiant = value; }
        }

        /// <summary>
        /// Retourne le nom de l'unité
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// Retourne l'extension de l'héro
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        /// <summary>
        /// Retourne la rareté de l'héro
        /// </summary>
        public string Rarete
        {
            get { return this._rarete; }
            set { this._rarete = value; }
        }

        /// <summary>
        /// Retourne la classe de l'héro
        /// </summary>
        public string Class
        {
            get { return this._classHero; }
            set { this._classHero = value; }
        }

        /// <summary>
        /// Retourne les points de vie de l'héro
        /// </summary>
        public byte PtsVie
        {
            get { return this._ptsVie; }
            set { this._ptsVie = value; }
        }

        #endregion


        #region CONSTRUCTEUR

        /// <summary>
        /// Constructeur de la class héros 
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="nom">Nom de l'héro</param>
        /// <param name="extension">Extension de l'héro</param>
        /// <param name="rarete">Rareté de l'héro</param>
        /// <param name="classHero">Classe de l'héro</param>
        /// <param name="ptsVie">Points de Vie de l'héro</param>
        public Heros(string identifiant, string nom, string extension, string rarete, string classHero, byte ptsVie)
        {
            this._identifiant = identifiant;
            this._nom = nom;
            this._extension = extension;
            this._rarete = rarete;
            this._classHero = classHero;
            this._ptsVie = ptsVie;
        }
       #endregion


    }
}
