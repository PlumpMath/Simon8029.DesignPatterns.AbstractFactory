﻿// **********************************************************************
// SOLUTION: DesignPatterns.AbstractFactory
// PROJECT: DesignPatterns.AbstractFactory 
// FILE NAME: CpuA.cs 
// CREATED ON 2015-06-26 9:43 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************

using System.Runtime.CompilerServices;

namespace DesignPatterns.AbstractFactory
{
    public class CpuA:Cpu

    {
        public CpuA()
        {
            Model = "CPU-A";

        }
    }
}