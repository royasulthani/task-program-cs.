﻿using System;
using task_group_class.Group_class;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Group group = new Group();
            group.no = "AP203";
            Console.WriteLine(group.No);
        }
    }
}