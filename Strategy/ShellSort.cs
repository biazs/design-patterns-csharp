using System;
using System.Collections.Generic;

namespace Strategy
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("ShellSorted list ");
        }
    }
}
