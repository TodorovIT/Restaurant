using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Restaurant
    {
        private static string name;
        private List<Staff> staff;
        private List<Client> client;
        private Menu menu;
        private BigDecimal sum;
        private int capacity;
        private int tablesCount;
        private List<Table> tables;
        private Bar bar;
        private Storage storage;
    }
}
