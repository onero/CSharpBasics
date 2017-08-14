﻿using ConsoleApp4Menu.BE;
using System;

namespace ConsoleApp4Menu.BLL
{
    public static class CustomerManager
    {

        public static void EditCustomer(Customer customerToEdit)
        {

            customerToEdit.DisplayInfo();


            Console.WriteLine("Please select one of following options:");
            Console.WriteLine("1: Change full name");
            Console.WriteLine("2: Change address");

            var selection = MenuManager.GetUserMenuSelection(2);

            if (selection == 1)
            {
                Console.Write("Please write full name: ");
                customerToEdit.FullName = MenuManager.GetValidString();
            }
            else if (selection == 2)
            {
                Console.Write("Please write address: ");
                customerToEdit.Address = Console.ReadLine();
            }
        }
    }
}