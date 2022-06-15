using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int Back = 0;
            int Chest = 0;
            int Abs = 0;
            int ProteinShake = 0;
            int ProteinBar = 0;
            int legs = 0;
            int training = 0;
            int shopping = 0;


            for (int i = 1; i <= numberPeople; i++)
            {
                string activity = Console.ReadLine();
                if (activity == "Back")
                {
                    Back++;
                    training++;
                }
                else if (activity == "Chest")
                {
                    Chest++;
                    training++;
                }
                else if (activity == "Abs")
                {
                    Abs++;
                    training++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                    training++;
                }
                else if (activity == "Protein bar")
                {
                    ProteinBar++;
                    shopping++;
                }
                else if (activity == "Protein shake")
                {
                    ProteinShake++;
                    shopping++;
                }
                
            }
            Console.WriteLine($"{Back} - back");
            Console.WriteLine($"{Chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{Abs} - abs");
            Console.WriteLine($"{ProteinShake} - protein shake");
            Console.WriteLine($"{ProteinBar} - protein bar");
            Console.WriteLine($"{training  / (training + shopping) * 100}% - work out");
            Console.WriteLine();


        }




            


        
    }
}
