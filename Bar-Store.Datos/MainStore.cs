using Bar_Store.Clases;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;


namespace Bar_Store.Datos
{
    public class MainStore
    {
        private string ConectionString = Properties.Resources.cad;

        public void runQuery(string q)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand(q, oCon);
            oCmd.CommandType = CommandType.Text;
            oCon.Open();
            oCmd.ExecuteNonQuery();
            oCon.Close();
            oCon.Dispose();
        }
        #region login
        public User UserLogin(string login, string pass)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = 
                new SqlCommand
                ($"select userLogin,pass, userName, CASE WHEN role = 1 THEN 'ADMIN' ELSE 'NORMAL' END AS isAdmin from users where userLogin = '{login}' and pass = '{pass}'", oCon);
            oCmd.CommandType = CommandType.Text;
            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            dr.Read();
            User user = new User();
            if (dr.HasRows)
            {
                user.Login = dr["userLogin"].ToString();
                user.Pass = dr["pass"].ToString();
                user.Name = dr["userName"].ToString();
                user.Role = dr["isAdmin"].ToString();
            }
            oCon.Close();
            oCon.Dispose();
            return user;
        }

        public User getUser(string login)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd =
                new SqlCommand
                ($"select userLogin,pass, userName, CASE WHEN role = 1 THEN 'ADMIN' ELSE 'NORMAL' END AS isAdmin from users where userLogin = '{login}'", oCon);
            oCmd.CommandType = CommandType.Text;
            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            dr.Read();
            User user = new User();
            if (dr.HasRows)
            {
                user.Login = dr["userLogin"].ToString();
                user.Pass = dr["pass"].ToString();
                user.Name = dr["userName"].ToString();
                user.Role = dr["isAdmin"].ToString();
            }
            oCon.Close();
            oCon.Dispose();
            return user;
        }
        #endregion
        #region getters
        public List<User> getUsers()
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = new SqlCommand("select userLogin,pass, userName, CASE WHEN role = 1 THEN 'ADMIN' ELSE 'NORMAL' END AS isAdmin from users ", oCon);
            oCmd.CommandType = CommandType.Text;

            oCon.Open();
            SqlDataReader dr = oCmd.ExecuteReader();
            List<User> users = new List<User>();
            while (dr.Read())
            {
                User vUser = new User();
                vUser.Login = dr["userLogin"].ToString();
                vUser.Pass = dr["pass"].ToString();
                vUser.Name = dr["userName"].ToString();
                vUser.Role = dr["isAdmin"].ToString();
                users.Add(vUser);
            }
            oCon.Close();
            oCon.Dispose();
            return users;
        }

      
        #endregion
    }
}
