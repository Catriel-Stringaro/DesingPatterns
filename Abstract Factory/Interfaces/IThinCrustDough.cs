using System;
using static System.Console;
namespace Abstract_Factory.Interfaces
{
    internal class IThinCrustDough : IDough
    {
        public IThinCrustDough()
        {
            Write("Agregando masa delgada" + Environment.NewLine);
        }
    }
}