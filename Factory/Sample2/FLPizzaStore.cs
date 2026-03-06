public class FLPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(TypeOfPizza type)
    {
        return (Pizza)Activator.
            CreateInstance(Type.GetType($"FL{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
    }
}
