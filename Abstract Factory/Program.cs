using Abstract;
using Abstract_Factory.Entity;

PizzaStore nyStore = new NYPizzaStore();
Pizza pizza = nyStore.OrderPizza(TypeOfPizza.Pepperoni);
Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada a Rodrigo");
Console.ReadLine();