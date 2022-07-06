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
    public partial class Form_DamageCalculator : Form
    {
        private DamageCalculator dmgCalc;
        public Form_DamageCalculator()
        {
            InitializeComponent();
            comboBoxWeaponType.DataSource = Enum.GetValues(typeof(WeaponType));
            comboBoxSharpness.DataSource = Enum.GetValues(typeof(WeaponSharpness));
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

                lblDamage.Text = dmgCalc.CalculateDamage().ToString();

            }


        }

        private void AffinityHandler()
        {
            
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


    }

  

}
