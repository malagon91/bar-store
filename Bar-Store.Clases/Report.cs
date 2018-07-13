using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Store.Clases
{
   public class Report
    {
        //select idSale, Notes,totalProducts , total, u.userName

        private int id;
        private string notes;
        private int items;
        private double total;
        private string user;

        public string User { get => user; set => user = value; }
        public double Total { get => total; set => total = value; }
        public int Items { get => items; set => items = value; }
        public string Notes { get => notes; set => notes = value; }
        public int Id { get => id; set => id = value; }
    }
    public class Date
    {
        private int y;
        private int m;
        private int d;

        public int D { get => d; set => d = value; }
        public int M { get => m; set => m = value; }
        public int Y { get => y; set => y = value; }
    }

    public class ProductReportDto
    {
        private string product;
        private int items;
        private string tipo;

        public string Product { get => product; set => product = value; }
        public int Items { get => items; set => items = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
