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
    public class Cartes
    {
        #region ATTRIBUTS

        /// <summary>
        /// Retourne le type de la créature 
        /// </summary>
        private Type _type;

        /// <summary>
        /// Retourne l'ID de la carte
        /// </summary>
        private string _identifiant;

        /// <summary>
        /// Retourne le nom de la carte
        /// </summary>
        private string _nom;

        /// <summary>
        /// Retourne l'extension de la carte
        /// </summary>
        private string _extension;

        /// <summary>
        /// Retourne la rareté de la carte
        /// </summary>
        private string _rarete;

        /// <summary>
        /// Retourne le cout de la carte
        /// </summary>
        private ushort _cout;

        /// <summary>
        /// Retourne le texte de la carte
        /// </summary>
        private string _texte;

        /// <summary>
        /// Retourne la class de la carte
        /// </summary>
        private string _classCarte;

        /// <summary>
        /// Retourne la mécaniques de la carte
        /// </summary>
        private string _mecaniques;

        /// <summary>
        /// Retourne le nombre de points d'attaque de la carte
        /// </summary>
        private byte _ptsAttaque;

        /// <summary>
        /// Retourne le nombre de points de vie de la carte
        /// </summary>
        private byte _ptsvie; 


        //RACE ENUM??????????????

        /// <summary>
        /// Retourne les points de la durabilités de la carte
        /// </summary>
        private byte _ptsDurablite;

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

        /// <summary>
        /// Retourne le type de la créature 
        /// </summary>
        public Type Type1
        {
            get { return this._type; }
            set { this._type = value; }
        }

        /// <summary>
        /// Retourne l'ID de la carte
        /// </summary>
        public string Identifiant
        {
            get { return this._identifiant; }
            set { this._identifiant = value; }
        }

        /// <summary>
        /// Retourne l'extension de la carte
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        /// <summary>
        /// Retourne la rareté de la carte
        /// </summary>
        public string Rarete
        {
            get { return this._rarete; }
            set { this._rarete = value; }
        }

        /// <summary>
        /// Retourne le texte de la carte
        /// </summary>
        public string Texte
        {
            get { return this._texte; }
            set { this._texte = value; }
        }

        /// <summary>
        /// Retourne la mécaniques de la carte
        /// </summary>
        public string Mecaniques
        {
            get { return this._mecaniques; }
            set { this._mecaniques = value; }
        }

        /// <summary>
        /// Retourne la class de la carte
        /// </summary>
        public string ClassCarte
        {
            get { return this._classCarte; }
            set { this._classCarte = value; }
        }

        /// <summary>
        /// Retourne le nombre de points d'attaque de la carte
        /// </summary>
        public byte PtsAttaque
        {
            get { return this._ptsAttaque; }
            set { this._ptsAttaque = value; }
        }

        /// <summary>
        /// Retourne le nombre de points de vie de la carte
        /// </summary>
        public byte Ptsvie
        {
            get { return this._ptsvie; }
            set { this._ptsvie = value; }
        }

        /// <summary>
        /// Retourne les points de la durabilités de la carte
        /// </summary>
        public byte PtsDurablite
        {
            get { return this._ptsDurablite; }
            set { this._ptsDurablite = value; }
        }

        #endregion

        #region CONSTRUCTEUR

        /// <summary>
        /// Constructeur paramétré avec tous les attributs de la classe carte.
        /// </summary>
        /// <param name="type">Type de la carte</param>
        /// <param name="identifiant">Type de l'identifiant de la carte</param>
        /// <param name="nom">Nom de la carte</param>
        /// <param name="extension">Extension de la carte</param>
        /// <param name="cout">Cout de la carte</param>
        /// <param name="texte">Texte de la carte</param>
        /// <param name="classCarte">Class de la carte</param>
        /// <param name="mecaniques">Mécaniques de la carte</param>
        /// <param name="ptsAttaque">Points d'attaque de la carte</param>
        /// <param name="ptsVie">Points de vie de la carte</param>
        /// <param name="ptsDurabilite">Points de durabilité de la carte</param>
        public Cartes(Type type, string identifiant, string nom, string extension, ushort cout, string texte, string classCarte, string mecaniques, byte ptsAttaque, byte ptsVie, byte ptsDurabilite)
        {
            this._type = type;
            this._identifiant = identifiant;
            this._nom = nom;
            this._extension = extension;
            this._cout = cout;
            this._texte = texte;
            this._classCarte = classCarte;
            this._mecaniques = mecaniques;
            this._ptsAttaque = ptsAttaque;
            this._ptsvie = ptsVie;
            this.PtsDurablite = ptsDurabilite;

        }
       #endregion

    }
}
