namespace lms
{
    public partial class Form1 : Form
    {
        private Button? currentBtn;
        private Form?activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private Color SelectColor()
        {
            return ColorTranslator.FromHtml(Colors.clickedColor);
        }

        private void OnButtonEnable(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentBtn != (Button)btnSender)
                {
                    OnButtonDisable();
                    Color color = SelectColor();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
        }

        private void OnButtonDisable()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(47, 79, 79);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            OnButtonEnable(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskPane.Controls.Add(childForm);
            this.panelDeskPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = TitleConversion(childForm);
            
        }
        private string TitleConversion(Form childForm)
        {
            switch (childForm.Text)
            {
                case "Form_DamageCalculator":
                    return "Damage Calculator";
                    break;
                case "Form_CharmFinder":
                    return "Charm Finder";
                    break;
                case "Form_MonsterDB":
                    return "Monster Database";
                    break;
            }
            return "";
        }
        // btn for damage calc
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_DamageCalculator(), sender); ;
        }
        private void btnFindCharm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_CharmFinder(), sender);
        }
        // btn for monster db
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_MonsterDB(), sender);
        }

      
    }
}