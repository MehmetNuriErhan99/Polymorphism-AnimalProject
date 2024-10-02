

namespace PolymorphismPet.Model;

public class Cat : Animal
{

    public bool Scratches { get; set; }
    public override void Voice()
    {
        Console.WriteLine($"Name : {Name}, Type : {Type}, Age : {Age}, Price : {Price}, scratches? : {Scratches} Voice : MIYAW MIYAW MIYAW MIYAW MIYAW MIYAW MIYAW MIYAW");
    }
}
