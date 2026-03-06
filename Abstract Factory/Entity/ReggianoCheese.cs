using Abstract_Factory.Interfaces;
using System;
using static System.Console;
namespace Abstract_Factory.Entity
{
    internal class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Write("Agregando queso parmesano"  +Environment.NewLine);
        }
    }
}