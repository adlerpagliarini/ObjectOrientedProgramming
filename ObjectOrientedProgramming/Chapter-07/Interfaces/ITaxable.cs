using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_07
{
    public interface ITaxable
    {
        List<Item> ItemsToBeTaxable { get; }
    }
}
