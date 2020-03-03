namespace Pets
{
    public class Dog : Pet
    {
         public Dog(string dogName, 
         string dogOwner, double dogWeight) : base("dog", dogName, dogOwner, dogWeight) 
         {
             //typeName = "dog";
             name = dogName;
             owner = dogOwner;
             weight = dogWeight;
         }

         public string bark(int count)
         {
             string barks = "";
             for(int i = 0; i <= count - 1; i++){
                 barks += "Bark! ";

             }
             return barks;
         }

    }
}