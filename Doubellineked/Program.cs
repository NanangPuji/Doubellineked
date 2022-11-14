using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Doubellineked
{
    class Node
    {
        /*Node class represents the mode of doubly Linked List.
         * it consists of the information part and links to
         * its succeding and preceeding
         * in terms of next and previous */
        public int noMhs;
        public string name;
        //point to the succeeding node
        public Node next;
        //point to the preceeding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;

        //constructor
    }

    public DoublelinkedList()
    {
        START = null;
    }

    public void addNode()
    {
        int nim;
        string nm;
        Console.Write("\nEnter the roll number of the student: ")
        nim = Console.ReadLine();
        Node newNode = new Node();
        newNode.noMhs = nim;
        newNode.name = nm;

        //check if the LIst empty
        if (START == null) || nim <== START.noMHs)
                if ((START != null) && (nim == START.noMhs)
        {
            Console.WriteLine("\nDuplicate number  not allowed");
            return;
        }
        newNode.next = START;
        if (START != null)
            START.prev = null;
        return true;
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
