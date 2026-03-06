using Abstract_Factory.Interfaces;
using System;
using static System.Console;
namespace Abstract_Factory.Entity
{
    internal class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Write("Agregando salsa marinara" + Environment.NewLine);
        }
    }
}