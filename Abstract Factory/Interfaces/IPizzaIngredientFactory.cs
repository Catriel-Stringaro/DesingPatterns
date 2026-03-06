using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        List<IVeggie> CreateVeggies();
    }
}
