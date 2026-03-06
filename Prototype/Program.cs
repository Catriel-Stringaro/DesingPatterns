/*
 * PROTOTYPE PATTERN
 *
 * What it is:
 *   A creational pattern that creates new objects by copying (cloning) an existing one,
 *   instead of building a new instance from scratch.
 *
 * What it's used for:
 *   Duplicating complex objects efficiently, especially when construction is expensive
 *   or when you need many similar objects with slight variations.
 *
 * When to use it:
 *   - When creating an object is costly (e.g. DB calls, heavy computation).
 *   - When you need copies of an object with small differences.
 *   - When you want to avoid subclassing just to configure objects differently.
 *
 * Key concept — Shallow vs Deep copy:
 *   Shallow copy: copies primitive fields but shares reference-type fields (e.g. Lists).
 *   Deep copy: creates fully independent copies of every field, including references.
 *   The Prototype pattern solves this by implementing a Clone() that does a deep copy.
 */

// ─────────────────────────────────────────────
// WITHOUT PROTOTYPE — The Problem (Shallow Copy)
// ─────────────────────────────────────────────
using Prototype;
using System.Runtime.Serialization.Formatters.Binary;

Console.WriteLine("=== WITHOUT PROTOTYPE (Problem) ===");

var original = new PlayerConfig("Rodrigo", 10, new List<string> { "Fireball", "Shield" });

// Looks like a copy, but Skills still points to the same list in memory.
var copy = new PlayerConfig(original.Name, original.Level, original.Skills);
copy.Name = "Carlos";
copy.Skills.Add("Sword"); // This also modifies original.Skills!

Console.WriteLine($"Original : {original.Name} | Skills: {string.Join(", ", original.Skills)}");
Console.WriteLine($"Copy     : {copy.Name} | Skills: {string.Join(", ", copy.Skills)}");
Console.WriteLine("Problem  : 'Sword' was added to the copy but it also appeared in the original.\n");

// ─────────────────────────────────────────────
// WITH PROTOTYPE — The Solution (Deep Copy)
// ─────────────────────────────────────────────
Console.WriteLine("=== WITH PROTOTYPE (Solution) ===");

var baseConfig = new PlayerConfigPrototype("Rodrigo", 10, new List<string> { "Fireball", "Shield" });

// Clone() creates a new independent Skills list — no shared references.
var cloned = baseConfig.Clone();
cloned.Name = "Carlos";
cloned.Skills.Add("Sword"); // Only affects the clone.

Console.WriteLine($"Original : {baseConfig.Name} | Skills: {string.Join(", ", baseConfig.Skills)}");
Console.WriteLine($"Clone    : {cloned.Name} | Skills: {string.Join(", ", cloned.Skills)}");
Console.WriteLine("Solution : 'Sword' was only added to the clone. The original remains intact.");

// ─────────────────────────────────────────────
// SAMPLE 2 — Abstract prototype with Shape hierarchy
// ─────────────────────────────────────────────
Console.WriteLine("\n=== SAMPLE 2: Shape Prototype ===");

var app = new ShapeApplication();
var copies = app.BusinessLogic();

foreach (var shape in copies)
{
    if (shape is Circle c)
        Console.WriteLine($"Circle  clone — X: {c.X}, Y: {c.Y}, Radius: {c.Radius}");
    else if (shape is Rectangle r)
        Console.WriteLine($"Rectangle clone — Width: {r.Width}, Height: {r.Height}");
}

// ─────────────────────────────────────────────
// SAMPLE 3 — With serealization
// ─────────────────────────────────────────────

var notebook1 = new Product("MacBook Pro", new Category("Computers"));

var dell = notebook1.DeepCopy();
dell.Category.Name = "Notebooks";
dell.Name = "Dell";
Console.WriteLine(notebook1);
Console.WriteLine(dell);
Console.ReadLine();
    

Console.ReadLine();
