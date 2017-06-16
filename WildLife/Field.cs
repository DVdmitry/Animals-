using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLife
{
    public class Field
    {
        public Random rand = new Random();
        public List<Grass>  GrassFood = new List<Grass>();

        public List<Rabbit> HungryRabbits = new List<Rabbit>();
        public List<Rabbit> GirlRabbits = new List<Rabbit>();
        public List<Rabbit> BoyRabbits = new List<Rabbit>();
        public List<Rabbit> RabbitBabies = new List<Rabbit>();
        public List<Rabbit> Rabbits = new List<Rabbit>();

        public List<Tiger> HungryTigers = new List<Tiger>();
        public List<Tiger> GirlTigers = new List<Tiger>();
        public List<Tiger> BoyTigers = new List<Tiger>();
        public List<Tiger> TigerBabies = new List<Tiger>();
        public List<Tiger> Tigers = new List<Tiger>();
    }
}
