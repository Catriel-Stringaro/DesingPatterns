// Used in the WITH PROTOTYPE example.
// Implements IPrototype<T> which enforces the Clone() contract.

/* IPrototype<PlayerConfigPrototype>
- El compilador te obliga a implementar Clone(). Si lo
olvidas, error en compilación.
- Puedes trabajar con el tipo genérico IPrototype<T> sin
conocer la clase concreta.
- Es la implementación correcta del patrón.

Sin la interfaz:
  public class PlayerConfigPrototype
  - Clone() sigue existiendo y funcionando exactamente
  igual.
  - Pero nadie te obliga a implementarlo — es solo un
  método más.
  - Pierdes el contrato formal del patrón.

  ---
  En resumen: eliminarla no rompe nada en tiempo de
  ejecución, pero dejas de aplicar el patrón
  correctamente. La interfaz es lo que convierte un método
   Clone() cualquiera en el Prototype Pattern.
*/
public class PlayerConfigPrototype : IPrototype<PlayerConfigPrototype>
{

    public string Name { get; set; }
    public int Level { get; set; }
    public List<string> Skills { get; set; }

    public PlayerConfigPrototype(string name, int level, List<string> skills)
    {
        Name = name;
        Level = level;
        Skills = skills;
    }

    public PlayerConfigPrototype Clone()
    {
        // MemberwiseClone() auto-copies all fields (no manual mapping needed).
        // Value types (int) and immutable types (string) are safe as shallow copies.
        // Reference types (List) must still be deep copied manually.
        var clone = (PlayerConfigPrototype)MemberwiseClone();
        clone.Skills = new List<string>(Skills);
        return clone;
    }
}
