using lms.Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms.Forms
{
    enum Affinity
    {
        None, Positive, Negative
    }
    public partial class Form_DamageCalculator : Form
    {
        private DamageCalculator dmgCalc;
        public Form_DamageCalculator()
        {
            InitializeComponent();
            comboBoxWeaponType.DataSource = Enum.GetValues(typeof(WeaponType));
            comboBoxSharpness.DataSource = Enum.GetValues(typeof(WeaponSharpness));
            comboBoxAffinity.DataSource = Enum.GetValues(typeof(Affinity));
            dmgCalc = new DamageCalculator();
        }
      
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (InputHandler.AllInputsCorrect())
            {
                dmgCalc.rAttack = float.Parse(txtBoxRaw.Text);
                dmgCalc.rMotion = float.Parse(txtBoxMotionValues.Text) / 100;
                dmgCalc.rHitzone = float.Parse(txtBoxHitzoneValues.Text) / 100;
                dmgCalc.rSharp = (WeaponSharpness)comboBoxSharpness.SelectedItem;
                dmgCalc.rAffinity = AffinityHandler((Affinity)comboBoxAffinity.SelectedItem);

                lblDamage.Text = String.Format("{0:0.00}", dmgCalc.CalculateDamage());
            }
        }
        private void OnButtonDisable()
        {
            foreach (Control previousBtn in panelDrinks.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(47, 79, 79);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        private float AffinityHandler(Affinity aff)
        {
            if(aff == Affinity.Positive)
            {
                return 1.25f;
            }else if (aff == Affinity.Negative)
            {
                return 0.75f;
            }
            return 1.0f;
        }

        private void txtBoxRaw_TextChanged(object sender, EventArgs e)
        {
            InputHandler.CheckInput(sender, ref InputHandler.bAttack);
        }

        private void txtBoxMotionValues_TextChanged(object sender, EventArgs e)
        {
            InputHandler.CheckInput(sender, ref InputHandler.bMotion);

        }

        private void txtBoxHitzoneValues_TextChanged(object sender, EventArgs e)
        {
            InputHandler.CheckInput(sender, ref InputHandler.bHitzone);

        }

        private void comboBoxAffinity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radBtnAUS_CheckedChanged(object sender, EventArgs e)
        {
            InputHandler.CheckDrinkInput(sender, ref InputHandler.bAttkUpDrink);
            if (InputHandler.bAttkUpDrink)
            {
                DrinkHandler.Instance.ActiveDrink = DrinkHandler.Instance.AttackUpSmall;
            }
        }

        private void radBtnAUM_CheckedChanged(object sender, EventArgs e)
        {
            InputHandler.CheckDrinkInput(sender, ref InputHandler.bAttkUpDrink);
            if (InputHandler.bAttkUpDrink)
            {
                DrinkHandler.Instance.ActiveDrink = DrinkHandler.Instance.AttackUpMedium;
            }
        }

        private void radBtnAUL_CheckedChanged(object sender, EventArgs e)
        {
            InputHandler.CheckDrinkInput(sender, ref InputHandler.bAttkUpDrink);
            if (InputHandler.bAttkUpDrink)
            {
                DrinkHandler.Instance.ActiveDrink = DrinkHandler.Instance.AttackUpLarge;
            }
        }
    }

  

}
