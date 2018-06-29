using Bar_Store.Clases;
using Bar_Store.Datos;
using System.Data;
using System;
using System.Collections.Generic;

namespace Bar_Store.Negocios
{
   public class Negocio
    {
        MainStore store = new MainStore();
        public User login (string user, string pass)
        {
            return store.UserLogin(user, pass);
        }

        public User getUser(string login)
        {
            return store.getUser(login);
        }

        #region users crud 
        public List<User> getUsers()
        {
            return store.getUsers();
        }

        public void saveUser(User vUser, bool isNew)
        {
            string q = isNew ?
               $"insert into users (userLogin,pass,userName,role) values ('{vUser.Login}','{vUser.Pass}','{vUser.Name}',{vUser.Role})" :
               $"update users set pass = '{vUser.Pass}',userName ='{vUser.Name}',role ={vUser.Role} where userLogin = '{vUser.Login}'";
            store.runQuery(q);
        }

        public void deleteUser(string vUser)
        {
            string q = $"delete from users where userLogin = '{vUser}'";
            store.runQuery(q);
        }
        #endregion
    }
}
