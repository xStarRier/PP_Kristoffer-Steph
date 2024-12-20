using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Oppgave
{
    internal class Main
    {
        List<Character> character = new List<Character>()
        {
        new Character("Gryffindor","Ron"),
        new Character("Slytherin","Draco")

        };


        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.Visit the magicshop");
            Console.WriteLine("2.Cast a spell");
            Console.WriteLine("3.Choose a different wizard");
            Console.WriteLine("****************************");
            var menuInput = Console.ReadLine();


            switch (menuInput)
            {
                case "1":
                    VisitShop();
                    break;
                case "2":
                    CastSpell();
                    break;
                case "3":
                    ChooseWizard();
                    break;
            }
       
        }
            public void VisitShop()
            {
             Console.WriteLine("Welcome to the Magical shop!");
             Console.WriteLine("What would you like to buy?");
            var inputShop = Console.ReadLine();
              switch (inputShop)
               {
                case "4":
    
                    break;
                case "5":

                    break;
            }
            }
            
            
            public void CastSpell()
            {
              Console.Clear();
              Console.WriteLine("Type a spell to cast");
              var inputSpell = Console.ReadLine();
            if (inputSpell == "vingardium leviosa")
            {
                Console.WriteLine("You feel your feet get off the ground");
            }
            else if (inputSpell == "Hocus pocus")
            {
                Console.WriteLine("You set the school on fire");
            }
            else 
            {
                Console.WriteLine("Spell is incorrect");
                Menu();
            }
            }

        public void ChooseWizard()
        {
            Console.WriteLine("Choose a wizard");
            for (int i = 0; i < character.Count; i++)
            {
                Console.WriteLine($"{character[i].Name}");
            }
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"you have chosen {character[0].Name}");
                    Console.WriteLine($"{character[0].Name} belongs to house {character[0].House}");
                    Menu();
                    break;
                case "2":
                    Console.WriteLine($"you have chosen {character[1].Name}");
                    Console.WriteLine($"{character[1].Name} belongs to house {character[1].House}");
                    Menu();
                    break;
                case "3":
                    Console.WriteLine("Transfer Characters");
                    AddCharacter();
                    break;
              
            }
        }

        public void AddCharacter() 
        { 
            Console.WriteLine("What is your name?");
            var nameInput = Console.ReadLine();
            Console.WriteLine("What house do you belong to?");
            var houseInput = Console.ReadLine();
            character.Add(new Character(houseInput, nameInput));
            ChooseWizard();

        }
    
    }
}








