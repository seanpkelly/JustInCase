using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    class Farmer : Villager
    {
        
        public string Name { get; set; }

        int Farmer = 1;
        private string v1;
        private int v2;

        public Farmer(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override int Farm()
        {
            return 2;
        }
    }


}
