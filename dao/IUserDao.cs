using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.dao
{
    interface IUserDao
    {
            //connexion
            User findUserByLoginAndPassword(String login, String password);

        // ajout de client 
        int addClient(User user);

        //get user by id
        User findUserById(int id);
    }
}
