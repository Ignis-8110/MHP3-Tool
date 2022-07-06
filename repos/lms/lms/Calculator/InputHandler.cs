using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Calculator
{
    internal static class InputHandler
    {
        public static bool bAttack;
        public static bool bMotion;
        public static bool bHitzone;
        private static TextBox currentTextBox;

        public static bool AllInputsCorrect()
        {
            if(bAttack && bMotion && bHitzone)
            {
                return true;
            }
            ShowWarningMessage();
            return false;
        }
        public static void CheckInput(object sender, ref bool type)
        {
            if (sender != null)
            {
                currentTextBox = (TextBox)sender;
                if (currentTextBox.Text.All(char.IsDigit) && currentTextBox.Text.Length > 0)
                {
                    type = true;
                }
                else
                {
                    type = false;
                }
            }
        }

        public static void ShowWarningMessage()
        {
            if (!bAttack || !bHitzone || !bMotion)
            {
                MessageBox.Show($"Warning: Invalid Input");
            }
        }

    }
}
