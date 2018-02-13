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

        public override int Count => count = 0;

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
            Node cNext = current.Next;
            while (current.Next != null)
            {
                if (a == Position)
                {
                    current.Next = new Node(data);
                    current.Next.Next = cNext;
                    current = current.Next;
                    current.Next = cNext;
                    

                }
                current = current.Next;
                cNext = current.Next;
                a++;

            }     

        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override Node ElementAt(int Position)
        {
            int a = 0;
            current = head;
            while (a!=Position)
            {
                current = current.Next;
                a++;
            }

            return current;
        }
         
        public override void ListNodes()
        {
            
            if (head!=null)
            {
                current = head;
                for (int i = 0; i<count; i++)
                {
                    
                    
                    if (current.Next != null)
                    {
                        System.Console.WriteLine(current.Data);
                        current = current.Next;
                    }

                }
                System.Console.WriteLine(current.Data);
            }
        }
     
        public override bool RemoveAt(int Position)
        {
            //Position -1
            int a = 0;
            current = head;
            Node prev, next;
            while (current.Next != null && head!=null)
            {
                //prev is prev a
                prev = current;
                //current = prev.Next b
                current = current.Next;
                //next is prev.Next.Next c
                next = current.Next;
                if (Position-1 == a)
                {
                    //a = c
                    current = null;
                    prev.Next = next;
                    return true;
                }  
                
                a++;
            }
            return false;
        }
    }
}
