namespace Pets
{
    public class Cat : Pet
    {
         public Cat(string catName, 
         string catOwner, double catWeight) : base("cat", catName, catOwner, catWeight) 
         {
             name = catName;
             owner = catOwner;
             weight = catWeight;
         }

           public string meow(int count)
         {
             string kittyspeakin = "";
             for(int i = 0; i <= count - 1; i++){
                 kittyspeakin += "meeeow...";

             }
             return kittyspeakin;
         }
    }
}