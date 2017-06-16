using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLife
{
    public class Rabbit : Animal, IAnimal
    {
        public bool ToEat(Field inField)
        {
            if (inField.GrassFood.Count > 0)
            {
                inField.GrassFood.RemoveRange(0, 1);
                return true;
            }
                return false;
        }

        public void ToFuck(int num, Field inField)
        {
            for (int i = 0; i<num; i++)
            { 
            inField.RabbitBabies.Add(new Rabbit(i, Gender.RabbitBoy));
            }
        }
        public Rabbit (int myId, Gender myGender) : base (myId, myGender)
        {
        }
     }
}
