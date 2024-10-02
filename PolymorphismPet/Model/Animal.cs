
namespace PolymorphismPet.Model;

public abstract class Animal
{
    public string Name { get; set; }
    public string Type { get; set; }

    public double Price { get; set; }
    public int Age { get; set; }

    public abstract void Voice();


}
