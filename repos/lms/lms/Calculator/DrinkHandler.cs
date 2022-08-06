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
            AttackUpLarge = new Drink("Attk Up L", 7);
            AttackUpMedium = new Drink("Attk Up M", 5);
            AttackUpSmall = new Drink("Attk Up S", 3);
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
