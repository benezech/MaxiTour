using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Dirigeant : Personne
    {
        

        public List<Client> ListeClient { get; set; }
        public List<Camion> ListeCamion { get; set; }
        public List<Devis> ListeDevis { get; set; }
        public List<Administratif> ListeAdministratif { get; set; }
        public List<Chauffeur> ListeChauffeur { get; set; }
        #region constructeurs

        public Dirigeant( int id, string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email)
            : base( id, nom, prenom, numsecu, adresse, codepostal, ville, telephone, email)
        {
            this.ListeClient = new List<Client>();
            this.ListeCamion = new List<Camion>();
            this.ListeDevis = new List<Devis>();
            this.ListeChauffeur = new List<Chauffeur>();
            this.ListeAdministratif = new List<Administratif>();
        }

        public Dirigeant (string nom, string prenom)
            : base( nom, prenom)
        {

        }

        #endregion

        #region Methodes CRUD Devis

        public Devis AjouterDevis(Devis devis)
        {
            Devis dTrouve = RechercherDevis(devis.Id);
            if (dTrouve == null)
            {
                ListeDevis.Add(devis);
                dTrouve = devis;
            }
            return devis;
        }

        public bool SupprimerDevis(int numero)
        {
            Devis devis = RechercherDevis(numero);
            if (devis == null)
                return false;

            ListeDevis.Remove(devis);
            return true;
        }

        public Devis RechercherDevis(int numero)
        {
            return ListeDevis.Find(delegate (Devis devis)
            {
                return devis.Id == numero;
            });
        }

        #endregion

        #region Methodes CRUD Client
        public void AjouterClient(Client clientToAdd)
        {
            ListeClient.Add(clientToAdd);
            /*return clientToAdd;*/
        }


        public void SupprimerClient(Client clientToDelet)
        {
            ListeClient.Remove(clientToDelet);
            /*return clientToDelet*/
        }
        public void ModifierClient()
        {

        }
        public Client RechercherClient(int id)
        {
            return ListeClient.Find(t => t.Id == id);
        }
        #endregion

        #region Methodes CRUD Camion
        public void ajouterCamion(Camion camionToAdd)
        {
            ListeCamion.Add(camionToAdd);
        }
        public void supprimerCamion(Camion camionToRemove)
        {
            ListeCamion.Remove(camionToRemove);
        }
        public void modifierCamion()
        {

        }
        public Camion rechercherCamion(int id)
        {
            return ListeCamion.Find(t => t.Id == id);
        }
        #endregion

        #region Methodes CRUD Administratif
        public void AjouterAdministratif(Administratif administratifToAdd)
        {
            ListeAdministratif.Add(administratifToAdd);
        }
        public void SupprimerAdministratif(Administratif administratifToDelet)
        {
            ListeAdministratif.Remove(administratifToDelet);
        }
        public void ModifierAdministratif()
        {

        }
        public Administratif RechercherAdministratif(int id)
        {
            return ListeAdministratif.Find(t => t.Id == id);
        }

        #endregion

        #region Methodes CRUD Chauffeur
        public void AjouterChauffeur(Chauffeur chauffeurToAdd)
        {
            ListeChauffeur.Add(chauffeurToAdd);
        }
        public void SupprimerChauffeur(Chauffeur chauffeurToDelet)
        {
            ListeChauffeur.Remove(chauffeurToDelet);
        }
        public void ModifierChauffeur()
        {

        }
        public Chauffeur RechercherChauffeur(int id)
        {
            return ListeChauffeur.Find(t => t.Id == id);
        }

        #endregion
        /*fonction à faire : valide()*/
    }
}
