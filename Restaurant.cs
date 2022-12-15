using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Restaurant
    {
        private string name;
        private List<Staff> staff;
        private List<Client> clients;
        private Menu menu;
        private long sum;
        private int capacity;
        private int tablesCount;
        private List<Table> tables;
        private Bar bar;
        private Storage storage;

        public Restaurant()
        {
            this.name = "Rex";
            this.staff = new List<Staff>();
            this.clients = new List<Client>();
            this.tables = new List<Table>();
            this.menu = new Menu();
            this.bar = new Bar();
            this.storage = new Storage();
            this.sum = new long();
            this.capacity = 30;
            this.tablesCount = 5;


        }
    }
}
