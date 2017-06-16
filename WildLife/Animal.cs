using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLife
{
    public abstract class Animal 
    {
        private int ID;
        public int id 
        {
            set
            {
                if (value < 0)
                   Console.WriteLine("Cannot set correct ID");
                this.ID = value;
            }
            get
            {
                return this.ID;
            }
        }
        public Gender MyGender;
        // простите за глупый вопрос, для enum-ов свойств не нужно?
        public Animal(int myID, Gender gender)
        {
            this.id = myID;
            this.MyGender = gender;
        }
    }
}
