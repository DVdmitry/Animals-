using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLife
{
    interface IAnimal
    {
        bool ToEat(Field someField);
        void ToFuck(int animalQuantity, Field someField);
    }
    
    
    
}
