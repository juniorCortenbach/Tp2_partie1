using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_partie1
{
    class Heros
    {
        #region ATTRIBUTS

        /// <summary>
        /// Retourne le type de la carte
        /// </summary>
        private Type _type;

        //Doit ajouté l'ID 
         

        /// <summary>
        /// Retourne le nom de l'unité
        /// </summary>
        private string _nom;


        #endregion


        #region ACESSEURS
        /// <summary>
        /// Retourne le nom de l'unité
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// Retourne le type de la carte
        /// </summary>
        public Type Type1
        {
            get { return this._type; }
            set { this._type = value; }
        }



        #endregion


         #region CONSTRUCTEUR


        /// <summary>
        /// Constructeur de la class héros 
        /// </summary>
        /// <param name="nom"></param>
        public Heros(string nom,Type type)
        {
            this._nom = nom;
            this._type = type;
        }
       #endregion


    }
}
