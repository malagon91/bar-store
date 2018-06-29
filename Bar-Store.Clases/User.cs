using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Store.Clases
{
   public class User
    {
       private string login;
        private string pass;
        private string name;
        private string role;

        public string Login { get => login; set => login = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
    }
}
