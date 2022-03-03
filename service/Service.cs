using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesCom.dao;
using GesCom.dto;


namespace GesCom.service
{
    class Service : IService
    {
        private IUserDao userDao;
        private IProduitDao produitDao;
        private ICommandeDao commandeDao;

        Model1Container model = new Model1Container();

        public Service()
        {
        }


        //Injection de Dépendance
        public Service(IUserDao userDao, IProduitDao produitDao, ICommandeDao commandeDao)
        {
            this.userDao = userDao;
            this.produitDao = produitDao;
            this.commandeDao = commandeDao;
            

        }

        public IUserDao UserDao { get => userDao; set => userDao = value; }
        public IProduitDao ProduitDao { get => produitDao; set => produitDao = value; }
        public ICommandeDao CommandeDao { get => commandeDao; set => commandeDao = value; }



        public void addCommande(int userId, int produitId, Commande commande, List<Panier> pan)
        {
            Commande cmd = commande;
            //int id = cmd.Client.Id;
            cmd.Client = (Client)searchUserById(userId);
            model.Commande.Add(cmd);

            foreach(Panier p in pan)
            {
                DetailCommande dtl = new DetailCommande();
                int id = p.ProduitCommande.Id;
                dtl.Montant = p.Prix;
                dtl.Quantite = p.QteCommande;
                dtl.Commande = cmd;
                dtl.Produit = produitDao.getProduitById(id);
                model.DetailCommande.Add(dtl);
                
            }

            model.SaveChanges();
        }

        public void addLivraison(Livraison li)
        {
            int idli = li.Livreur.Id;
            int idCmd = li.Commande.Id;
            Commande cmd = model.Commande.Find(idCmd);
            Livreur liv = (Livreur)model.User.Find(idli);
            li.Livreur = liv;
            li.Commande = cmd;
            model.Livraison.Add(li);


            updateToOkayCommande(idCmd);

            model.SaveChanges();

        }

        public int addProduct(Produit produit)
        {
            return produitDao.insert(produit);
        }

        public int ajoutClient(User user)
        {
            return userDao.addClient(user);
        }

        public List<Produit> getAllProduct()
        {
            return produitDao.selectAll();
        }

        public List<CommandeDto> getCommandeDto()
        {
            List<CommandeDto> cmdDtoList = new List<CommandeDto>(250);
            
            List<Commande> cmdList = model.Commande.ToList();
            foreach(var c in cmdList)
            {
                string idStr = Convert.ToString(c.Id);
                string refeference = "REF-CMD - ";
                for(int i = 0;  i < (3-idStr.Length); i++)
                {
                    refeference += "0";
                }
                refeference += idStr;

                
                CommandeDto cmdDto = new CommandeDto();
                cmdDto.Id = c.Id;
                cmdDto.Reference = refeference;
                cmdDto.Etat = c.Etat;
                cmdDto.Date = c.Date;
                cmdDto.CmdUser = c.Client;

                cmdDtoList.Add(cmdDto);
            }

            return cmdDtoList;
        }

        public List<CommandeDto> getCommandeDtoByEtat(string etat)
        {
            List<CommandeDto> cmdDtoList = new List<CommandeDto>(250);

            List<Commande> cmdList = model.Commande.Where(s=> s.Etat == etat).ToList();
            foreach (var c in cmdList)
            {
                string idStr = Convert.ToString(c.Id);
                string refeference = "REF-CMD - ";
                for (int i = 0; i < (3 - idStr.Length); i++)
                {
                    refeference += "0";
                }
                refeference += idStr;


                CommandeDto cmdDto = new CommandeDto();
                cmdDto.Id = c.Id;
                cmdDto.Reference = refeference;
                cmdDto.Etat = c.Etat;
                cmdDto.Date = c.Date;
                cmdDto.CmdUser = c.Client;

                cmdDtoList.Add(cmdDto);
            }

            return cmdDtoList;
        }

        public List<CommandeDto> getCommandeDtoToRs()
        {
            List<CommandeDto> cmdDtoList = new List<CommandeDto>(250);
            List<Commande> cmdList = model.Commande.Where(s => s.Etat != "Demande" && s.Etat != "En attente").ToList();
            foreach (var c in cmdList)
            {
                string idStr = Convert.ToString(c.Id);
                string refeference = "REF - CMD - ";
                for (int i = 0; i < (3 - idStr.Length); i++)
                {
                    refeference += "0";
                }
                refeference += idStr;


                CommandeDto cmdDto = new CommandeDto();
                cmdDto.Id = c.Id;
                cmdDto.Reference = refeference;
                cmdDto.Etat = c.Etat;
                cmdDto.Date = c.Date;
                cmdDto.CmdUser = c.Client;

                cmdDtoList.Add(cmdDto);
            }

            return cmdDtoList;
        }

        public List<DetailCommandeDto> getDetailCommande(int idCmd)
        {
            List<DetailCommandeDto> detailsCommandeList = new List<DetailCommandeDto>(200);

            List<DetailCommande> details = model.DetailCommande.Where(s=> s.Commande.Id == idCmd).ToList();
            foreach(var d in details)
            {
                DetailCommandeDto dtl = new DetailCommandeDto();
                dtl.Id = d.Id;
                dtl.Libelle = d.Produit.Libelle;
                dtl.Qte = d.Quantite;
                dtl.Prix = d.Montant;
                dtl.Details = d;

                detailsCommandeList.Add(dtl);
            }

            return detailsCommandeList;
        }

        public List<LivraisonDto> getLivraisonById(int id)
        {
            List<Livraison> livraisons = model.Livraison.Where(u => u.Livreur.Id == id).ToList();

            List<LivraisonDto> livraisonsDto = new List<LivraisonDto>(500);
            
            foreach(var liv in livraisons)
            {
                

                string idStr = Convert.ToString(liv.Id);
                string refeference = "REF-LIV-";
                for (int i = 0; i < (3 - idStr.Length); i++)
                {
                    refeference += "0";
                }
                refeference += idStr;

                LivraisonDto livDto = new LivraisonDto();
                livDto.Id = liv.Id;
                livDto.Reference = refeference;
                livDto.Prix = liv.Commande.Montant;
                livDto.DateX = Convert.ToDateTime(liv.Date);
                livDto.Commande = liv.Commande;

                livraisonsDto.Add(livDto);


            }
            return livraisonsDto;
        }

        public User searchUserById(int id)
        {
            return userDao.findUserById(id);
        }

        public User searchUserLoginAndPassword(string login, string password)
        {
            return userDao.findUserByLoginAndPassword(login, password);
        }

        public List<User> showAllLivreurs()
        {
            List<User> users =  model.User.Where( s=>s.Role == "ROLE_LIVREUR").ToList();
            //Console.WriteLine(users.Count);
            return users;
        }

        public void updateToOkayCommande(int id)
        {
            Commande cmd = model.Commande.Find(id);
            cmd.Etat = "Valide";
            model.SaveChanges();
        }

        public void updateToOkayWaitingCommande(int id)
        {
            Commande cmd = model.Commande.Find(id);
            cmd.Etat = "Attente de confirmation";
            model.SaveChanges();
        }

        public void updateToValideCommande(int id)
        {
            Commande cmd = model.Commande.Find(id);
            cmd.Etat = "En cours";
            model.SaveChanges();
        }

        public void updateToWaitCommande(int id)
        {
            Commande cmd = model.Commande.Find(id);
            cmd.Etat = "En attente";
            model.SaveChanges();
        }
    }
}
