using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    interface ISingletonContainer
    {
        int GetPopulation(string name);
    }

    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();
        private SingletonDataContainer()
        {
            Console.WriteLine("Nueva instancia SingletonDataContainer");
            var elements = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }

        }
        // lazy solo va a instanciarlo cuando se utilize
        private static Lazy<SingletonDataContainer> instance = new Lazy<SingletonDataContainer>(()  => new SingletonDataContainer());
        public static SingletonDataContainer Instance => instance.Value;

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var capitals = SingletonDataContainer.Instance;
            var capitals1 = SingletonDataContainer.Instance;
            var capitals3 = SingletonDataContainer.Instance;
            Console.WriteLine($"Los habitantes de londres:  {capitals.GetPopulation("London")}");
            Console.ReadLine();
        }
    }


    /*
     Dada la siguiente clase Person, debes crear un método llamado Instance que implemente un Singleton.
     */

    public class Person
    {
        public string Name { get; set; }
        private static Person instance = new Person();
        public static Person Instance => instance;
    }
}
