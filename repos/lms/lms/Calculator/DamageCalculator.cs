using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Calculator
{
    public class DamageCalculator
    {

        #region Raw
        public WeaponType wepType;
        public float rAttack = 0f;
        public float rMotion = 1.0f;
        public float rHitzone = 1.0f;
        public float rAffinity = 1.0f;
        public WeaponSharpness rSharp = WeaponSharpness.Red;
        public float rConnect = 1.0f;
        public float rSpecial = 1.0f;
        #endregion
        
        #region Element
        public float eAttack = 0;
        public float eMotion = 0;
        public float eHitzone = 0;
        public float eSkills = 0;
        public float eSpecial = 0;
        #endregion

        #region Modifiers
        private float defensePercentage = 1.0f;
        private float monsterRage = 1.0f;
        private float monsterStatus = 1.0f;
        #endregion

        #region Add
        public float attkCharm = 6;
        public float attkTalon = 9;
        public float attkSeed = 10;
        public float attkDemonDrug = 5;
        public DrinkHandler attkDrink = DrinkHandler.Instance;
        #endregion
        private float SharpnessRawConversion(WeaponSharpness sharp)
        {
            switch (sharp)
            {
                case WeaponSharpness.Red:
                    return SharpnessRawModifier.Red;
                case WeaponSharpness.Orange:
                    return SharpnessRawModifier.Orange;
                case WeaponSharpness.Yellow:
                    return SharpnessRawModifier.Yellow;
                case WeaponSharpness.Green:
                    return SharpnessRawModifier.Green;
                case WeaponSharpness.Blue:
                    return SharpnessRawModifier.Blue;
                case WeaponSharpness.White:
                    return SharpnessRawModifier.White;
                default:
                    return 0f;

            }
        }
        private float SharpnessEleConversion(WeaponSharpness sharp)
        {
            switch (sharp)
            {
                case WeaponSharpness.Red:
                    return SharpnessEleModifier.Red;
                case WeaponSharpness.Orange:
                    return SharpnessEleModifier.Orange;
                case WeaponSharpness.Yellow:
                    return SharpnessEleModifier.Yellow;
                case WeaponSharpness.Green:
                    return SharpnessEleModifier.Green;
                case WeaponSharpness.Blue:
                    return SharpnessEleModifier.Blue;
                case WeaponSharpness.White:
                    return SharpnessEleModifier.White;
                default:
                    return 0f;

            }
        }

        private void AddRaw()
        {
            if (InputHandler.bAttkUpDrink)
            {
                rAttack += attkDrink.ActiveDrink.AddedRaw;
            }
        }
        private float CalculateRaw()
        {
            AddRaw();
            return rAttack * rMotion * rHitzone * rAffinity * SharpnessRawConversion(rSharp) * rConnect * rSpecial;
        }

        private float CalculateEle()
        {
            return eAttack * eMotion * eHitzone * SharpnessEleConversion(rSharp) * eSkills * eSpecial;
        }
        //[ (ATTACK X MOTION X HITZONE X AFFINITY X SHARP X CONNECT X SPECIAL) + (ELEMENT X EMOTION X EHITZONE X ESHARP X ESKILLS X ESPECIAL) ]

        public float CalculateDamage()
        {
            return (CalculateRaw() + CalculateEle()) * (defensePercentage * monsterRage * monsterStatus);
        }
    }
}
