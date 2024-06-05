using System;
using System.Collections.Generic;
using MyLibrary;

class Program
{
    static void Main(string[] args)
    {
        SingleLinkedList list = new SingleLinkedList();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);
        list.AddFirst(6);
        list.AddFirst(7);
        list.AddFirst(8);
        list.AddFirst(1);
        Console.WriteLine(list.GetNumberBy3());
        Console.WriteLine(list.ProductOfElementsLessThanAverage());
        SingleLinkedList newlist = list.GetListBy3();
        list.RemoveElementsLessThanAverage();
        Console.WriteLine(list.GetNumberBy3());
    }
}