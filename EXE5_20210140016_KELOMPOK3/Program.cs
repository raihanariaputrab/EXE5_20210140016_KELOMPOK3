using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140016_KELOMPOK3
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node raihan, aria;
        public queue()
        {
            raihan = null;
            aria = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (raihan == null)
            {
                raihan = newnode;
                aria = newnode;
                return;
            }
            raihan.next = newnode;
            aria = newnode;
        }
        public void delete()
        {
            if (raihan == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            raihan = raihan.next;
            if (raihan == null)
                aria = null;
        }
        public void display()
        {
            if (raihan == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Node display;
            for (display = raihan; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {

            }
        }
    }
}
