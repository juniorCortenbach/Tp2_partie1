using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_partie1
{
    class Utilitaire
    {
        #region ATTRIBUTS
        
        #endregion

        #region PROPRIÉTÉS

        #endregion

        #region  CONSTANTE

        const string fichierCartes = "cards-collectible.xml";

        #endregion

        #region CONSTRUCTEUR

        #endregion

        #region MÉTHODES

        public static Cartes[] ChargerCartes(String cheminFichier)
        {
            //Création du flux en lecture du fichier dont le chemin d'accès est "FichierCartes".
            StreamReader fluxLectureCartes = new StreamReader(cheminFichier);

            //Lecture du fichier qui contient les cartes.
            String fichierTexteCartes = fluxLectureCartes.ReadToEnd();

            //Retrait des retours de chariot potentiels.
            fichierTexteCartes = fichierTexteCartes.Replace("\r", "");

            //Tableau de chaines de caractères qui contient chaque ligne.
            String[] tabLignesUnites = fichierTexteCartes.Split('\n');

            // Nombre de lignes non vides dans le fichier.
            int nbLignesCartes;

            if (tabLignesUnites[tabLignesUnites.Length - 1] == "")
                nbLignesCartes = tabLignesUnites.Length - 1;
            else
                nbLignesCartes = tabLignesUnites.Length;

            //Tableau d'unités, taille = nombre de lignes non vides.
            Cartes[] tabCartes = new Cartes[nbLignesCartes];

            //Tableau pour conserver les champs sur une ligne.
            String[] tabChamps;

            //Variables utilitaires pour la création d'un objet "Carte".
           

            //Traitement de chaque ligne du fichier.
            for (int k = 0; k < tabCartes.Length; k++)
            {
                //Séparation des champs.
                tabChamps = tabLignesUnites[k].Split(',');

                //Récupération du type, de l'identifiant, du nom, de l'extension,
                //de la rareté, du coût, du texte, de la classe, des mécaniques,
                //des points d'attaque, des points de vie, de la race et la durabilité.
               

                //Création de l'objet "StatsCarte" pour l'ajout au tableau de joueurs.*
                Cartes uneStatsCarte = new Cartes();

                //Création de l'objet "Cartes" et ajout au tableau de joueurs.*
                tabCartes[k] = new Cartes();

                //Fermeture du flux vers le fichier.
                fluxLectureCartes.Close();

            }
            //Retour du tableau d'unités.
            return tabCartes;
        }
        #endregion

    }
}
