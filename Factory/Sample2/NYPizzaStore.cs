public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(TypeOfPizza type)
    {
        return (Pizza)Activator.
            CreateInstance(Type.GetType($"NY{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
    }
}
