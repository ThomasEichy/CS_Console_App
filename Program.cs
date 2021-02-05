using System;

namespace CS_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuInst = new Menu();

            menuInst.Intro();
            
        }
    }

    class Menu
    {

        public void Intro()
        {
            Console.WriteLine("Hello! Please enter the application name you would" +
            " like to use. \nYour choices are below. \n\nName Greeting | Rectagle Area" +
             " Calculator | Gas Mileage Calculator | Alice Search");

            string menuSelect = Console.ReadLine().ToLower();
            
            if (menuSelect == "name greeting")
            {
                Name();
            }
            else if (menuSelect == "rectagle area calculator")
            {
                RectArea();
            }
            else if (menuSelect == "gas mileage calculator")
            {
                GasMiles();
            }
            else if (menuSelect == "alice search")
            {
                Alice();
            }
            else if (menuSelect == "quit")
            {
                Quit();
            }
            else
            {
                Err();
            }
        }

        public void Name()
        {
            Console.WriteLine("Name");
        }

        public void RectArea()
        {
            Console.WriteLine("Area");
        }

        public void GasMiles()
        {
            Console.WriteLine("Miles");
        }

        public void Alice()
        {
            Console.WriteLine("Alice");
        }
        
        public void Quit()
        {
            Console.WriteLine("Thank you for using our app. Goodbye!");
            return;
        }

        public void Err()
        {
            Console.WriteLine("\nI'm sorry, this option is not valid. \nPlease try typing again.\n");
            Intro();

        }
    
    }
}
