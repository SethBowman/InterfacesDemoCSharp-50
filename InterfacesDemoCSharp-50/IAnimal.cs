namespace InterfacesDemoCSharp_50;

public interface IAnimal
{
    //Cannot have fields in an interface

    public int Age { get; set; }
    public string Diet { get; set; }
    
    //Interface methods will ALWAYS be stubbed out methods
    //Interfaces are completely abstract in the background (even though we never use the keyword 'abstract')
    public void Move();
    public void Breathe();
}