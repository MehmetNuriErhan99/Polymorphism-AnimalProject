
namespace PolymorphismPet.Model;

public class Bird : Animal
{

    public bool Beaks { get; set; }
    public override void Voice()
    {
        Console.WriteLine($"Name : {Name}, Type : {Type}, Age : {Age}, Price : {Price}, scratches? : {Beaks} Voice : CIK CIK CIK CIK CIK CIK CIK CIK");
    }
}
