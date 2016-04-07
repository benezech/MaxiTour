using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Camion
    {

        #region GetSet
        public int Id { get; private set; }
        public string Marque { get; private set; }
        public string Immatriculation { get; private set; }
        public bool Etat { get; set; }
        public double Km { get; set; }
        public string Modele { get; private set; }
        public double Consommation { get; set; }
        public string Carburant { get; set; }
        public DateTime DateAchat { get; private set; }
        public DateTime DateCirculation { get; private set; }
        public bool Hayon { get; set; }
        public int HayonPuissance { get; set; }
        public string Type { get; set; }
        public double Poid { get; private set; }
        public double LongueurExtRem { get; private set; }
        public double HauteurExtRem { get; private set; }
        public double LargeurExtRem { get; private set; }
        public double LongueurIntRem { get; private set; }
        public double HauteurIntRem { get; private set; }
        public double LargeurIntRem { get; private set; }
        public List<Chauffeur> ListeChauffeur = new List<Chauffeur>();
        public List<Client> ListeClient = new List<Client>();
        public List<Tournee> ListeTournee = new List<Tournee>();
        #endregion

        #region Constructeur
        public Camion(string immat, string marque, bool etat, double km, string modele, double conso, string carbu, DateTime dateAchat, DateTime dateCirculation, bool hayon, int hayonPuissance, string type, double longueurExtRem, double hauteurExtRem, double largeurExtRem, double longueurIntRem, double hauteurIntRem, double largeurIntRem)
        {
            Immatriculation = immat;
            Marque = marque;
            Etat = etat;
            Km = km;
            Modele = modele;
            Consommation = conso;
            Carburant = carbu;
            DateAchat = dateAchat;
            Hayon = hayon;
            HayonPuissance = hayonPuissance;
            Type = type;
            LongueurExtRem = longueurExtRem;
            HauteurExtRem = hauteurExtRem;
            LargeurExtRem = largeurExtRem;
            LongueurIntRem = longueurIntRem;
            HauteurIntRem = hauteurIntRem;
            LargeurIntRem = largeurIntRem;
        }

        public Camion(string immat, string marque, bool etat)
        {
            Immatriculation = immat;
            Marque = marque;
            Etat = etat;
        }
        #endregion
        
        #region Fonction
        public int AgeCamion()
        {
            int age = DateTime.Now.Year - DateAchat.Year;
            return age;
        }


        public double calculVolume()
        {
            double volumeTotal = LongueurIntRem * HauteurIntRem * LargeurIntRem;
            return volumeTotal;
        }

        public double calculVolumeLibre()
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

        }
        #endregion

    }
}
