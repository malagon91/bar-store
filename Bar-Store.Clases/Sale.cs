using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Store.Clases
{
    public class Sale
    {
        private int id;
        private int total;
        private double mount;
        private string date;
        private int status;
        private string notes;
        private string user;

        public int Id { get => id; set => id = value; }
        public int Total { get => total; set => total = value; }
        public double Mount { get => mount; set => mount = value; }
        public string Date { get => date; set => date = value; }
        public int Status { get => status; set => status = value; }
        public string Notes { get => notes; set => notes = value; }
        public string User { get => user; set => user = value; }
    }

    public class SaleDto
    {
        private int id;
        private string notes;

        public int Id { get => id; set => id = value; }
        public string Notes { get => notes; set => notes = value; }
    }
    public class TotalsDto
    {
        private int id;

        private int items;
        private double total;

        public int Id { get => id; set => id = value; }

        public int Items { get => items; set => items = value; }
        public double Total { get => total; set => total = value; }
    }

    public class SalesDetails
    {
        private int idSale;
        private int idProdct;
        private int total;
      
        public int IdSale { get => idSale; set => idSale = value; }
        public int IdProdct { get => idProdct; set => idProdct = value; }
        public int Total { get => total; set => total = value; }
     
    }

    public class SalesDetailsDto
    {
      
        private int idProdct;
        private string product;
        private int total;

       
        public int IdProdct { get => idProdct; set => idProdct = value; }
        public string Product { get => product; set => product = value; }
        public int Total { get => total; set => total = value; }
    }
}
