using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Calculator
{

    public class DrinkHandler
    {
        private DrinkHandler()
        {
            AttackUpLarge = new Drink("Attk Up L", 15);
            AttackUpMedium = new Drink("Attk Up M", 10);
            AttackUpSmall = new Drink("Attk Up S", 5);
        }

        private static DrinkHandler instance = new DrinkHandler();
        public static DrinkHandler Instance
        {
            get { return instance; }
        }
        public Drink AttackUpLarge { get; private set; }
        public Drink AttackUpMedium { get; private set; }
        public Drink AttackUpSmall { get; private set; }

        public Drink ActiveDrink { get; set; }
    }
}
