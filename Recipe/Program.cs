using coos;
using System.ComponentModel;
using System.Transactions;

namespace Excelsior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n Recipes Tracker");
                Console.WriteLine("1. Add Recipe");   //add
                Console.WriteLine("2. View recipes"); //done
                Console.WriteLine("3. Update");       //update
                Console.WriteLine("4. Delete");

                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                var option = Console.ReadLine();
                Rec1 rec = new Rec1();
                JsonR ta = new JsonR();

                switch (option)
                {

                    // havent finished

                    case "1":
                        Console.WriteLine("Title of new transaction: ");
                        string dis = Console.ReadLine();
                        Console.WriteLine("Category: ");
                        string cat = Console.ReadLine();
                        Console.WriteLine("instruction:");
                        string instr = Console.ReadLine();
                        Console.WriteLine("ingredients");
                        string ino = Console.ReadLine();

                        Console.WriteLine("ingredients");
                        var oo = Console.ReadLine();

                        rec.Add(dis, cat, instr, ino, oo);


                        break;
                    case "2":
                        rec.View();

                        break;
                    case "3":
                        rec.Update();
                        break;
                    case "4":
                        rec.Delete();
                        break;

                    case "5":
                        // Exit application
                        Console.WriteLine("Exiting application...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}

