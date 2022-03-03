using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesCom.utils;

namespace GesCom.dao
{
    class UserDao : IUserDao
    {
        Model1Container modelUser = new Model1Container();

        public int addClient(User user)
        {
            modelUser.User.Add(user);
            return modelUser.SaveChanges();
        }

        public User findUserById(int id)
        {
            return modelUser.User.Where(s => s.Id == id).FirstOrDefault();
        }

        public User findUserByLoginAndPassword(string login, string password)
        {
           var user =  modelUser.User.Where(s => s.Login == login && s.Password == password).FirstOrDefault();
            return user;
        }
    }
}
