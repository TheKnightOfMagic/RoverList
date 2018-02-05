using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  Implement the RoverList class
            RoverList list = new RoverList();
            // TODO:  Create a RoverList and then fill it with 16 words
            list.Add("A");
            list.Add("To");
            list.Add("Fad");
            list.Add("Food");
            list.Add("Quaff");
            list.Add("Mental");
            list.Add("Pyramid");
            list.Add("Enamored");
            list.Add("Planetary");
            list.Add("Beleagured");
            list.Add("Candy");
            list.Add("Candor");
            list.Add("Cadence");
            list.Add("Seratonin");
            list.Add("Implementation");
            list.Add(3, "Fungi");
            
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Remove every 3rd word
            /*for (int i = 0; i<list.Count; i++)
            {
                if ((i+1) %3==0)
                {
                    list.RemoveAt(i);
                }

            }*/
            list.RemoveAt(3);
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            bool cont = true;
            while (cont == true)
            {
                string userInput = Console.ReadLine();
                if (userInput.Equals("done"))
                {
                    cont = false;
                    break;
                }
                list.Add(userInput);
            }
            // TODO:  Print out the list
            list.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
