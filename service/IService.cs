using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesCom.dto;

namespace GesCom.service
{
    public interface IService
    {
        //Se Connecter
        User searchUserLoginAndPassword(string login, string password);
        int ajoutClient(User user);
        User searchUserById(int id);


        //Ajout de produit
        int addProduct(Produit produit);
        List<User> showAllLivreurs();


        //Lister les produits
        List<Produit> getAllProduct();

        //ajout de commande
          void addCommande(int userId, int produitId, Commande commande, List<Panier> pan);

        //Dto commande
        List<CommandeDto> getCommandeDto();
        List<DetailCommandeDto> getDetailCommande(int idCmd);

        void updateToValideCommande(int id);
        void updateToWaitCommande(int id);
        void updateToOkayCommande(int id);
        void updateToOkayWaitingCommande(int id);

        List<CommandeDto> getCommandeDtoByEtat(String etat);

        List<CommandeDto> getCommandeDtoToRs();



        //add livraison
        void addLivraison(Livraison li);
        List<LivraisonDto> getLivraisonById(int id);


    }
}
