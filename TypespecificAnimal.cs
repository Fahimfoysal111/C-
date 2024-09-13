using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_18_GenericApproch
{
    public class TypespecificAnimal<T>:ITypeSpecificBehaviour<T>
    {
        public string Gettypespecificbehaviour<T>(T data) where T : Animal
        {
            string behavior = string.Empty;
            switch (data.type)
            {
                case AnimalType.Carnivore:
                    behavior = "two feet";
                    break;
                case AnimalType.Harnivore:
                    behavior = "Four feet";
                    break;
                case AnimalType.Omnivore:
                    behavior = "Adaptale";
                    break;
            
            }
            return behavior;
        }

    }
}
