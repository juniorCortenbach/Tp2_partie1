using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_partie1
{
    class Cartes
    {
        #region ATTRIBUTS

        /// <summary>
        /// Retourne le nom de la carte
        /// </summary>
        private string _nom;


        /// <summary>
        /// Retourne le cout de la carte
        /// </summary>
        private ushort _cout;

        #endregion



        #region ACESSEURS

        /// <summary>
        /// Retourne le nom de la carte
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// Retourne le cout de la carte
        /// </summary>
        public ushort Cout
        {
            get { return this._cout; }
            set { this._cout = value; }
        }

        #endregion

        #region CONSTRUCTEUR


        /// <summary>
        /// Constructeur de la classe carte.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="cout"></param>
        public Cartes(string nom, ushort cout)
        {
            this._nom = nom;
            this._cout = cout;
        }
       #endregion

    }
}
