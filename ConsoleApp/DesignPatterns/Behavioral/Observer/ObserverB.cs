﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Observer
{
    public class ObserverB : Observer<int>
    {
        public override void OnNext(int value)
        {
            if(value % 2 == 0)
                Console.WriteLine($"{nameof(ObserverB)}: reacts");
        }
    }
}
