using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _14_Lady_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Siamese> cat1 = new List<Siamese>();
            List<Cymric> cat2 = new List<Cymric>();
            List<StreetExtraordinaire> cat3 = new List<StreetExtraordinaire>();


            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string breed = parameters[0];
                string name = parameters[1];
                double specificCharacteristics = double.Parse(parameters[2]);

                if (breed == "Siamese")
                {
                    cat1.Add(new Siamese(breed, name, Convert.ToInt32(specificCharacteristics)));
                }
                else if (breed == "Cymric")
                {
                    cat2.Add(new Cymric(breed, name, specificCharacteristics));
                }
                else if (breed == "StreetExtraordinaire")
                {
                    cat3.Add(new StreetExtraordinaire(breed, name, Convert.ToInt32(specificCharacteristics)));
                }
            }

            string enterName = Console.ReadLine();
            
            for(int i = 0;i<cat1.Count; i++){
                if(cat1[i].breed == "Siamese" && cat1[i].name == enterName)
                {
                    Console.WriteLine($"{cat1[i].breed} {cat1[i].name} {cat1[i].specificCharacteristics}");
                }
                else if (cat2[i].breed == "Cymric" && cat2[i].name == enterName)
                {
                    Console.WriteLine($"{cat2[i].breed} {cat2[i].name} {cat2[i].specificCharacteristics}");
                }
                else  if (cat3[i].breed == "StreetExtraordinaire" && cat3[i].name == enterName)
                {
                    Console.WriteLine($"{cat3[i].breed} {cat3[i].name} {cat3[i].specificCharacteristics}");
                }
            }
            

        }
    }
}
