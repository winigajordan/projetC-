using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.dao
{
    interface ICommandeDao
    {
        //ajout d'une commande
        int insertCommande(Commande commande);
    }
}
