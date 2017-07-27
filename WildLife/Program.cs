using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Field myField = new Field();
            Rabbit bobRabbit = new Rabbit(1, Gender.RabbitBoy);
            int deadRabbitsQuantity = 0;
            int deadTigersQuantity = 0;
            int initiallyHungryRabbits = 0;
            int randForGrass = myField.rand.Next(2, 100);
            int randForGirlRabbits = myField.rand.Next(3, 50);
            int randForBoyRabbits = myField.rand.Next(3, 50);
            int randForGirlTigers = myField.rand.Next(25, 100);
            int randForBoyTigers = myField.rand.Next(25, 25);
            int positionInArray = 0;
            int initiallyHungryTigers = 0;
            void AddGrass()
            {
                for (int i = 0; i < randForGrass; i++)
                {
                    myField.GrassFood.Add(new Grass());
                }
            }

            void AddGirlRabbits()
            {
                for (int i = 0; i < randForGirlRabbits; i++)
                {
                    myField.HungryRabbits.Add(new Rabbit(i, Gender.RabbitGirl));
                }
            }

            void AddBoyRabbits()
            {
                for (int i = 0; i < randForBoyRabbits; i++)
                {
                    myField.HungryRabbits.Add(new Rabbit(i, Gender.RabbitBoy));
                }
            }

            AddGrass();
            AddGirlRabbits();
            AddBoyRabbits();
            initiallyHungryRabbits = myField.HungryRabbits.Count;
            while (myField.HungryRabbits.Count > 0)
            {
                if (bobRabbit.ToEat(myField) && myField.HungryRabbits.Count > 0)
                {
                    positionInArray = myField.rand.Next(0, myField.HungryRabbits.Count - 1);

                    // знаю, вы говорили про тернарный оператор 100500 раз, но в этом случае у меня 
                    // выскакивает ошибка, не пойму из-за чего:
                    //myField.HungryRabbits[positionInArray].MyGender == Gender.RabbitGirl ? 
                    //myField.GirlRabbits.Add(myField.HungryRabbits[positionInArray]) : 
                    //myField.BoyRabbits.Add(myField.HungryRabbits[positionInArray]);

                    if (myField.HungryRabbits[positionInArray].MyGender == Gender.RabbitGirl)
                        myField.GirlRabbits.Add(myField.HungryRabbits[positionInArray]);
                    else
                        myField.BoyRabbits.Add(myField.HungryRabbits[positionInArray]);

                    myField.HungryRabbits.Remove(myField.HungryRabbits[positionInArray]);
                    deadRabbitsQuantity = myField.HungryRabbits.Count;
                }
                else
                    break;
            }
            bobRabbit.ToFuck(myField.GirlRabbits.Count < myField.BoyRabbits.Count ? myField.GirlRabbits.Count :
                myField.BoyRabbits.Count, myField);

            myField.Rabbits.AddRange(myField.BoyRabbits);
            myField.Rabbits.AddRange(myField.GirlRabbits);
            myField.Rabbits.AddRange(myField.RabbitBabies);

            Tiger jimTiger = new Tiger(1, Gender.TigerBoy);

            void AddGirlTigers()
            {
                for (int i = 0; i < randForGirlTigers; i++)
                {
                    myField.HungryTigers.Add(new Tiger(i, Gender.TigerGirl));
                }
            }

            void AddBoyTigers()
            {
                for (int i = 0; i < randForBoyTigers; i++)
                {
                    myField.HungryTigers.Add(new Tiger(i, Gender.TigerBoy));
                }
            }

            AddGirlTigers();
            AddBoyTigers();
            initiallyHungryTigers = myField.HungryTigers.Count;

            while (myField.HungryTigers.Count > 0)
            {
                if (jimTiger.ToEat(myField) && myField.HungryTigers.Count > 0)
                {
                    positionInArray = myField.rand.Next(0, myField.HungryTigers.Count - 1);
                    if (myField.HungryTigers[positionInArray].MyGender == Gender.TigerGirl)
                        myField.GirlTigers.Add(myField.HungryTigers[positionInArray]);
                    else
                        myField.BoyTigers.Add(myField.HungryTigers[positionInArray]);

                    myField.HungryTigers.Remove(myField.HungryTigers[positionInArray]);
                    deadTigersQuantity = myField.HungryTigers.Count;
                }
                else
                    break;
            }
            jimTiger.ToFuck(myField.GirlTigers.Count < myField.BoyTigers.Count ? myField.GirlTigers.Count :
                myField.BoyTigers.Count, myField);


            string headLine = new string('#', 60);
            StringBuilder header = new StringBuilder();
            header.Append(headLine);
            header.Append("\n\t\t\tWildLife fairytale\n");
            header.Append(headLine);
            header.Append("\nOnce upon a time there were {0} rabbits. All of them were hungry. \nThere were {1} grass for rabbits. \nSome " +
                 "{2} rabbit-girls and {3} rabbit-boys \nwere able to find some food and were able to make {4} " +
                 "rabbit-kids. \nUnfortunately other {5} rabbits, that didn`t find food died of hunger :( \n" +
                 " because there were only {6} food left.\nThen {7} hungry tigers appeared.Every single one of them \nate 1 rabbit." +
                "\nBut there were not enough food for each tiger and {8} of them died of hunger.\n" +
                "The rest {9} tiger-girls and {10} tiger-boys has made {11} " +
                "tiger-kids.\nAs a result, at the end there were {12} rabbits left and {13} tigers left");

            Console.WriteLine(header.ToString(),
                 initiallyHungryRabbits,
                 randForGrass,
                 myField.GirlRabbits.Count,
                 myField.BoyRabbits.Count,
                 myField.RabbitBabies.Count,
                 deadRabbitsQuantity,
                 myField.GrassFood.Count,
            initiallyHungryTigers,
                deadTigersQuantity,
                myField.GirlTigers.Count,
                myField.BoyTigers.Count,
                myField.TigerBabies.Count,
                myField.Rabbits.Count,
                myField.GirlTigers.Count+ myField.BoyTigers.Count+ myField.TigerBabies.Count);
                
            Console.ReadLine();
        }
    }
}
