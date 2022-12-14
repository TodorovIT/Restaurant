using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        private List<Item> salad = new List<Item>();
        private List<Item> mainDish = new List<Item>();
        private List<Item> dessert = new List<Item>();
        private List<Item> alcoholicDrink = new List<Item>();
        private List<Item> softDrink = new List<Item>();

        public Menu()
        {
            fillMenu();
        }

        private void fillMenu()
        {
            salad.Add(new Item("Руска салата", "food", 0.450, 5.50));
            salad.Add(new Item("Зелена салата", "food", 0.500, 4.00));
            salad.Add(new Item("Гръцка салата", "food", 0.400, 6.00));
            salad.Add(new Item("Италианска салата", "food", 0.430, 5.50));
            salad.Add(new Item("Овчарска салата", "food", 0.300, 5.00));

            mainDish.Add(new Item("Пица", "food", 1, 6.00));
            mainDish.Add(new Item("Свинска пържола", "food", 0.200, 5.00));
            mainDish.Add(new Item("Телешка пържола", "food", 0.200, 5.50));
            mainDish.Add(new Item("Калмари", "food", 0.200, 12.00));
            mainDish.Add(new Item("Риба", "food", 0.200, 3.00));

            dessert.Add(new Item("Сладолед", "food", 0.100, 0.99));
            dessert.Add(new Item("Мекици", "food", 0.100, 1.00));
            dessert.Add(new Item("Торта", "food", 0.300, 4.00));
        }
    }
}
