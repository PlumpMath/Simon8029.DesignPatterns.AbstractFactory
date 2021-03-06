﻿// **********************************************************************
// SOLUTION: DesignPatterns.AbstractFactory
// PROJECT: DesignPatterns.AbstractFactory 
// FILE NAME: AbstractFactoryB.cs 
// CREATED ON 2015-06-26 9:51 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryB : IAbstractFactory
    {
        public ICpu CreateCpu()
        {
            return new CpuB();
        }

        public IMemory CreateMemory()
        {
            return new MemoryB();
        }
    }
}