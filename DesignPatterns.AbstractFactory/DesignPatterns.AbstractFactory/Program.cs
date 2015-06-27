// **********************************************************************
// SOLUTION: DesignPatterns.AbstractFactory
// PROJECT: DesignPatterns.AbstractFactory 
// FILE NAME: Program.cs 
// CREATED ON 2015-06-26 9:32 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computerA = new Computer(new AbstractFactoryA(), "Company A","A-2015-I");
            Computer computerB = new Computer(new AbstractFactoryB(), "Company B","B-2015-II");
            computerA.ShowInfo();
            Console.WriteLine("================");
            computerB.ShowInfo();
        }
    }
}
