using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Poition 
    {
        public int Amplification;
        public int Amount;
        


    }
    class HealingPoition : Poition {
        public HealingPoition() {
            Amplification = 7;
            Amount = 2;


        } }

        class ManaPoition : Poition {
            public ManaPoition()
            {
                Amplification = 5;
                Amount = 2;
            }

        
        }
    
    
    }


