using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        int count = 0;
        public RoverList ()
        {

        }

        public override int Count => count;

        public override void Add(object data)
        {

            if (head == null)
            {
                head = new Node(data);
                current = head;
            }
            else
            {
                current.Next = new Node(data);
                current = current.Next;
            }
            count++;
        }

        public override void Add(int Position, object data)
        {
            int a = 0;
            current = head;

            while (current.Next != null)
            {

                current = current.Next;
                Node cNext = current.Next;
                a++;
                if (a == Position)
                {
                    current.Next = new Node(data);
                    current.Next.Next = cNext;
                    a++;

                }

            }     

        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            
            if (current!=null)
            {
                current = head;
                for (int i = 0; i<count; i++)
                {
                    
                    System.Console.WriteLine(current.Data);
                    if (current.Next != null)
                    {
                        current = current.Next;
                    }

                }
            }
        }

        public override bool RemoveAt(int Position)
        {
            //Position -1
            int a = 0;
            current = head;
            Node prev, next;
            while (current.Next != null)
            {
                //prev is prev a
                prev = current;
                //current = prev.Next b
                current = current.Next;
                //next is prev.Next.Next c
                next = current.Next;
                if (Position == a)
                {
                    //a = c
                    
                    prev.Next = next;
                    
                    
                    return true;
                }
               
                   
                
                
                a++;
            }
            return false;
        }
    }
}
