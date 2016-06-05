using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Camion
    {

        #region GetSet
        public int Id { get; private set; }
        public string Etat { get; set; }
        public string Immatriculation { get; private set; }
        public double Km { get; set; }
        public string Modele { get; private set; }
        public string Marque { get; private set; }
        public double Consommation { get; set; }
        public string Carburant { get; set; }
        public string DateAchat { get; private set; }
        public string DateCirculation { get; private set; }
        public string Hayon { get; set; }
        public string PoidVide { get; set; }
        public double PoidTAC { get; private set; }
        public double LongueurIntRem { get; private set; }
        public double LargeurIntRem { get; private set; }
        public double HauteurIntRem { get; private set; }

        public List<Chauffeur> ListeChauffeur = new List<Chauffeur>();
        public List<Client> ListeClient = new List<Client>();
        public List<Tournee> ListeTournee = new List<Tournee>();
        #endregion

        #region Constructeur
        public Camion(int id, string etat, string immat, double km, string modele, string marque, double conso, string carbu, string dateAchat, string dateCirculation, string hayon, string poidVide, double poidTAC,  double longueurIntRem, double largeurIntRem, double hauteurIntRem)
        {
            Id = id;
            Etat = etat;
            Immatriculation = immat;
            Km = km;
            Modele = modele;
            Marque = marque;
            Consommation = conso;
            Carburant = carbu;
            DateAchat = dateAchat;
            DateCirculation = dateCirculation;
            Hayon = hayon;
            PoidVide = poidVide;
            PoidTAC = poidTAC;
            LongueurIntRem = longueurIntRem;
            HauteurIntRem = hauteurIntRem;
            LargeurIntRem = largeurIntRem;
        }


        public Camion()
        {

        }

        #endregion
        
        #region Fonction
        /*public int AgeCamion()
        {
            int age = DateTime.Now.Year - DateAchat.Year;
            return age;
        }*/


        public double calculVolume( double longueur, double largeur, double hauteur)
        {
            double volumeTotal = longueur * largeur * hauteur;
            return volumeTotal;
        }

       /* public double calculVolumeLibre()
        {

            double VolumeLibre = 0;


            foreach (Chauffeur chauffeur in ListeChauffeur)
            {

                List<TourneePrevi> ltp = chauffeur.ListeTourneePrevi;

                foreach (TourneePrevi tourneeprevi in ltp)
                {


                    List<Devis> ld = tourneeprevi.ListeDevis;

                    foreach (Devis devis in ld)
                    {
                        double MonVolume = calculVolume();
                        VolumeLibre += MonVolume - devis.VolumeMarchandise;
                    }


                }

            }

            return VolumeLibre;

        }*/
        #endregion

    }
}
