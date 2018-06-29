using Bar_Store.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Bar_Store.Datos
{
    public class MainStore
    {
        private string ConectionString = Properties.Resources.cad;

        public User UserLogin(string login, string pass)
        {
            SqlConnection oCon = new SqlConnection(ConectionString);
            SqlCommand oCmd = 
                new SqlCommand
                ($"select userLogin,pass, userName from users where userLogin = '{login}' and pass = '{pass}'", oCon);
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
            }
            return user;
        }


    }
}
