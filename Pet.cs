namespace Pets
{

public class Pet
{
    public string type = "";
    public string name = "";
     public string owner = "";
     public double weight = 0;
    
    public Pet(string typeName, string petName, string ownerName, double petWeight)//constructor?
    {
        type = typeName;
        name = petName;
        owner = ownerName;
        weight = petWeight;

    }

    public string getTag()
    {
        //string finaltag = ""; 
        return "If lost, call " + owner;
    }

}
}