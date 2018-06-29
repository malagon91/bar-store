namespace Bar_Store.Clases
{
    public class Product
    {
        private int id;
        private string name;
        private double cost;
        private string desc;
        private int inventory;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Cost { get => cost; set => cost = value; }
        public string Desc { get => desc; set => desc = value; }
        public int Inventory { get => inventory; set => inventory = value; }
    }
}
