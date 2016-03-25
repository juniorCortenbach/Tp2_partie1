using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_partie1
{
    class Deck
    {
        #region ATTRIBUTS

        /// <summary>
        /// 
        /// </summary>
        private string _nomDeck;

        private string _hero;

        private string[] _tabCartes;

        #endregion

        #region PROPRIÉTÉS

        public string NomDeck
        {
            get { return this._nomDeck; }
            set { this._nomDeck = value; }
        }

        public string Hero
        {
            get { return this._hero; }
            set { this._hero = value; }
        }

        public string[] TabCartes
        {
            get { return this._tabCartes; }
            set { this._tabCartes = value; }
        }

        #endregion
    }
}
