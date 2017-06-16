using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLife
{
    public class Tiger : Animal, IAnimal
    {
        Field inField = new Field();
        public bool ToEat(Field inField)
        {
            if (inField.Rabbits.Count > 0)
            {
                inField.Rabbits.RemoveRange(0, 1);
                return true;
            }
            return false;
        }
        public void ToFuck(int animalQuantity, Field someField)
        {
            for (int i = 0; i < animalQuantity; i++)
            {
                someField.TigerBabies.Add(new Tiger(i, Gender.TigerGirl));
            }
        }
        public Tiger(int ID, Gender myGender) : base(ID, myGender)
        {
        }
    }
}
