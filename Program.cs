var user = User.Factory.CreateWithDefaultCountry("Rodrigo", "rodrigo@gmail.com");

Console.WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais: {user.Country}");
Console.ReadLine();

public class User
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Country { get; private set; }

    private User(string name, string email, string country)
    {
        Name = name;
        Email = email;
        Country = country;
    }

    public static class Factory
    {
        public static User CreateWithDefaultCountry(string name, string email)
        {
            return new User(name, email, "Chile");
        }

        public static User CreateWithDefaultEmail(string name, string country)
        {
            return new User(name, "rodrigo@gmail.com", country);
        }
    }
}
