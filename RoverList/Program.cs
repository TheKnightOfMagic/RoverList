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
            list.Add(null);
            // TODO:  Create a RoverList and then fill it with 16 words
            list.Add("A");//
            list.Add("To");
            list.Add("Fad");//
           
            list.Add("Quaff");//
            list.Add("Mental");
            list.Add("Pyramid");//
            list.Add("Enamored");
            list.Add("Planetary");//
            list.Add("Beleagured");
            list.Add("Candy");//
            list.Add("Candor");
            list.Add("Cadence");//
            list.Add("Seratonin");//
            list.Add("Implementation");
            list.Add(3, "Fungi");//
            list.Add(6, "Abdicate");
            
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
            list.RemoveAt(5);
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            bool cont = true;
            while (cont == true)
            {
                string userInput = Console.ReadLine();
                if (userInput.Equals("done"))
                {
                    break;
                }
                list.Add(userInput);
            }
            // TODO:  Print out the list
            list.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            cont = true;
            while (cont == true)
            {
                string inpt = Console.ReadLine();
               
                if (inpt.Equals("done"))
                {
                    break;
                }
                list.Add(0, inpt);
            }
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Remove every word with an odd length
            for (int i = 1; i < list.Count+1; i++)
            {
                string great = (string)list.ElementAt(i).Data;
                int len = great.Length;
                if (len%2 != 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Clear the list
            list.Clear();
            // TODO:  Print out the list
        
            list.ListNodes();

        }
    }
}
