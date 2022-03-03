using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesCom.dao;
using GesCom.service;

namespace GesCom.fabrique
{
    class Fabrique
    {
        public static IService getInstanceService()
        {
            return new Service()
            {

                UserDao = new UserDao(),
                ProduitDao = new ProduitDao(),
                CommandeDao = new CommandeDao()

            };
        }
    }
}
