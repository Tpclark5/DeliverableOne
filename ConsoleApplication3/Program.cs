using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string destination = "";
                string transportType = "";
                Console.Write("What type of vacation would you like to take, musical, tropical, or adventurous: ");
                string vacation = Console.ReadLine();
                Console.Write("How many are in your group: ");
                int groupSize = int.Parse(Console.ReadLine());

                {


                    if (vacation == "musical")
                    {
                       destination = ("New Orleans");
                    }
                    else if (vacation == "tropical")
                    {
                        destination = ("a beach vacation in Mexico");
                    }
                    else if (vacation == "adventurous")
                    {
                        destination = ("Whitewater rafting in the Grand Canyon");
                    }

                     if (groupSize <= 2)
                    {
                        transportType = "a first class flight";
                            }
                    else if (groupSize <= 5)
                    {
                        transportType = "a helicopter";
                            }
                    else if (groupSize >= 6)
                    {
                        transportType = ("a charter flight");
                            }
                    string results = ("Since you're a group of " + groupSize + " going on a " + vacation + " vacation, you should take " + transportType + " to " + destination + ".");
                    Console.WriteLine(results);

                }
            }
        }
    }
}
    

