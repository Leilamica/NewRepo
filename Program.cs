using System;
using System.Collections.Generic;
using BusinessLogic;
using Model;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Menu menuData = new Data.Menu();
            List<Models> menuItems = Data.Menu.Ulams();

            Console.WriteLine("Welcome to the Canteen!");
            Console.WriteLine("Here are the menu items:");
            Console.WriteLine("1. Adobong manok ---> Php 50.00");
            Console.WriteLine("2. Tinola ---> Php 50.00");
            Console.WriteLine("3. Sinigang ---> Php 60.00");
            Console.WriteLine("4. Bicol express ---> Php 60.00");
            Console.WriteLine("5. Kaldereta ---> Php 50.00");
            Console.WriteLine("6. Bopis ---> Php 50.00");
            Console.WriteLine("7. Chopsuy ---> Php 30.00");
            Console.WriteLine("8. Rice ---> Php 10.00");

            Console.WriteLine("Enter the numbers of the items you want to order (separated by commas):");
            string input = Console.ReadLine();
            string[] itemNumbers = input.Split(',');

            List<Models> selectedItems = new List<Models>();

            foreach (var itemNumber in itemNumbers)
            {
                if (int.TryParse(itemNumber, out int index) && index >= 1 && index <= menuItems.Count)
                {
                    Models selectedItem = menuItems[index - 1];
                    selectedItems.Add(selectedItem);
                }
                else
                {
                    Console.WriteLine($"Invalid item number:"+itemNumber);
                }
            }

            MenuService menuService = new MenuService();
            double totalPrice = menuService.CalculateTotalPrice(selectedItems);

            Console.WriteLine($"Total: Php "+ totalPrice);
            Console.WriteLine("Thank you for your order!Please come again:)");
        }
    }
}
