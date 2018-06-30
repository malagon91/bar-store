using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Store.Clases
{
    public class Purchase
    {
        private int id;
        private int idProd;
        private int total;
        private string userLogin;
        private string date;

        public int Id { get => id; set => id = value; }
        public int IdProd { get => idProd; set => idProd = value; }
        public int Total { get => total; set => total = value; }
        public string UserLogin { get => userLogin; set => userLogin = value; }
        public string Date { get => date; set => date = value; }
    }
    public class PurchaseDTO
    {
        private int id;
        private string product;
        private int total;
        private string name;
        private string date;

        public int Id { get => id; set => id = value; }
        public string Product { get => product; set => product = value; }
        public int Total { get => total; set => total = value; }
        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
    }
}
