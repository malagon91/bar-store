using Bar_Store.Clases;
using Bar_Store.Datos;

namespace Bar_Store.Negocios
{
   public class Negocio
    {
        public User login (string user, string pass)
        {
            MainStore store = new MainStore();
            return store.UserLogin(user, pass);
        }
    }
}
