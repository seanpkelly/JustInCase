using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    class Town
    {
        //public List<Villager> Villagers;

        List<Villager> Villagers = new List<Villager> ()
        {
            new Farmer("Sean the farmer", 1),
            new Slacker("Robbie the slacker", 2),
            new Slacker("Connor the slacker", 3),
            new Slacker("Steph the slacker", 4),
        };
        
        public Town(List<Villager> villagers)
        {
            this.Villagers = villager;
        }

        public static int Harvest()
        {

            int sum1 = Villager.Sum();
            Console.WriteLine(sum1);
            
            
        }

        public static int CalcFoodConsumption()
        {
            int Hunger = Villagers.Sum();
            Console.WriteLine(Hunger);
        }

        public static bool SurviveTheWinter()
        {
            Harvest();
            CalcFoodConsumption();

            if (CalcFoodConsumption() <= Harvest())
            {
                return true;
            }
            if (CalcFoodConsumption() >= Harvest())
            {
                return false;
            }

            
        }
    }
}
