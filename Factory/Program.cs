
// ─────────────────────────────────────────────
// SAMPLE 1 — Factory with static named methods
// ─────────────────────────────────────────────
Console.WriteLine("=== SAMPLE 1: User Factory ===");

var user = User.Factory.CreateWithDefaultCountry("Rodrigo", "rodrigo@gmail.com");
Console.WriteLine($"Usuario: {user.Name} | Email: {user.Email} | Pais: {user.Country}");





// ─────────────────────────────────────────────
// SAMPLE 2 — Factory Method with PizzaStore
// ─────────────────────────────────────────────
Console.WriteLine("\n=== SAMPLE 2: PizzaStore Factory Method ===");

PizzaStore nyStore = new NYPizzaStore();
Pizza pizza = nyStore.OrderPizza(TypeOfPizza.Pepperoni);
Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada a Rodrigo");

Console.ReadLine();









//ejercicio:
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
/*
Tienes una clase llamada Student que tiene 2 propiedades Name y Id. 
Debes implementar una clase static llamada StudentFactory que contenga un método Create que reciba por parametro solamente el Name. 
Cada estudiante que sea creado debe tener un Id autoincremental, el cual debe comenzar por 001. 
por ej: Estudiante 1: 001, Estudiante 2: 002.
*/

//Solution
public class StudentTest
{
    private StudentTest(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public static class StudentFactory
    {
        private static int index = 001;
        public static StudentTest Create(string name)
        {
            return new StudentTest(index++, name);
        }
    }
}

StudentTest s1 = StudentTest.StudentFactory.Create("Juan"); // Id = 1
StudentTest s2 = StudentTest.StudentFactory.Create("Ana");  // Id = 2
StudentTest s3 = StudentTest.StudentFactory.Create("Luis"); // Id = 3