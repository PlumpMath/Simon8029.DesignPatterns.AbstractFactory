// **********************************************************************
// SOLUTION: DesignPatterns.AbstractFactory
// PROJECT: DesignPatterns.AbstractFactory 
// FILE NAME: Cpu.cs 
// CREATED ON 2015-06-26 9:41 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
namespace DesignPatterns.AbstractFactory
{
    public abstract class Cpu:ICpu
    {
        public string Model { get; set; }
    }
}