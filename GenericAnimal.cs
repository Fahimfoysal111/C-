using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_18_GenericApproch
{
    public class GenericAnimal<T>:Igenericbehaviour<T>
    {
      public  string GenericBehaviour(T obj)
        {
            string behavior = string.Empty;
            if (obj is Animal)
            {
                Animal A = obj as Animal;
                switch (A.type)
                {
                    case AnimalType.Carnivore:
                        behavior = "Two feet";
                        break;
                    case AnimalType.Harnivore:
                        behavior = "Eat meat";
                        break;
                    case AnimalType.Omnivore:
                        behavior = "Adaptable";
                        break;
                    default:
                        behavior = "Not an animal";
                        break;

                }
            }
            else
            {
                behavior = "This is not a animal";
            }
            return behavior;
        }
    }
}
