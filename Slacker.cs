using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    public class Slacker : Villager
    {
        int Hunger = 3;
        private string v1;
        private int v2;

        public Slacker(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Name { get; set; }


        public override int Farm()
        {
            return 0;
        }
    }
}
