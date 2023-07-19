namespace BOL
{
    public class Manager
    {
        private int id;
        private string name;
        private string role;
        private string address;
        private double salary;


        public Manager(int id,string name, string role, string address,double sal)
        {   
            this.id = id;
            this.name = name;
            this.role = role;
            this.address = address;
            this.salary = sal;
        }

        public int mid
        {
            get { return id; }
            set { id = value; }
        }
        public string mname
        {
            get { return name; }
            set { name = value; }
        }

        public string mrole
        {
            get { return role; }
            set { role = value; }
        }

        public string maddress
        {
            get { return address; }
            set { address = value; }
        }

        public double msal
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}",id,name,role,address,msal);
        }
    }
}