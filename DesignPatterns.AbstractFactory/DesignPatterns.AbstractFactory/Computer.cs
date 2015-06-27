// **********************************************************************
// SOLUTION: DesignPatterns.AbstractFactory
// PROJECT: DesignPatterns.AbstractFactory 
// FILE NAME: Computer.cs 
// CREATED ON 2015-06-26 9:52 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************

using System;

namespace DesignPatterns.AbstractFactory
{
    public class Computer
    {
        public ICpu Cpu { get; set; }
        public IMemory Memory { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Computer(IAbstractFactory abstractFactory,string brand,string model)
        {
            Cpu = abstractFactory.CreateCpu();
            Memory = abstractFactory.CreateMemory();
            Brand = brand;
            Model = model;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Cpu: {0}", Cpu.Model);
            Console.WriteLine("Memory: {0}", Memory.Model);
        }
    }
}