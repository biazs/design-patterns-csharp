﻿using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            Iterator i = a.CreateIterator();

            Console.WriteLine("Iteragindo com a colecao: ");
            object item = i.First();

            int x = 0;
            while(item != null)
            {
                Console.WriteLine(item);
                if (x == 2)
                    item = i.CurrentItem();

                item = i.Next();
                x++;
            }

            Console.ReadKey();
        }
    }
}
