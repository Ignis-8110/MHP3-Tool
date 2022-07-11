namespace lms.Forms
{
    partial class Form_DamageCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radBtnAUS = new System.Windows.Forms.RadioButton();
            this.radBtnAUM = new System.Windows.Forms.RadioButton();
            this.radBtnAUL = new System.Windows.Forms.RadioButton();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.panelSkills = new System.Windows.Forms.Panel();
            this.comboBoxAffinity = new System.Windows.Forms.ComboBox();
            this.lblSkillAffinity = new System.Windows.Forms.Label();
            this.txtBoxEle = new System.Windows.Forms.TextBox();
            this.lblEle = new System.Windows.Forms.Label();
            this.comboBoxWeaponType = new System.Windows.Forms.ComboBox();
            this.lblWeaponType = new System.Windows.Forms.Label();
            this.txtBoxRaw = new System.Windows.Forms.TextBox();
            this.lblRaw = new System.Windows.Forms.Label();
            this.comboBoxSharpness = new System.Windows.Forms.ComboBox();
            this.txtBoxHitzoneValues = new System.Windows.Forms.TextBox();
            this.lblHitzoneValues = new System.Windows.Forms.Label();
            this.txtBoxMotionValues = new System.Windows.Forms.TextBox();
            this.lblSharpness = new System.Windows.Forms.Label();
            this.lblMotionValues = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.titleDamage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDefMod = new System.Windows.Forms.ComboBox();
            this.lblDefMod = new System.Windows.Forms.Label();
            this.panelDrinks.SuspendLayout();
            this.panelSkills.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(437, 319);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(195, 120);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // radBtnAUS
            // 
            this.radBtnAUS.Location = new System.Drawing.Point(3, 40);
            this.radBtnAUS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBtnAUS.Name = "radBtnAUS";
            this.radBtnAUS.Size = new System.Drawing.Size(107, 25);
            this.radBtnAUS.TabIndex = 3;
            this.radBtnAUS.TabStop = true;
            this.radBtnAUS.Text = "Atk Up S";
            this.radBtnAUS.UseVisualStyleBackColor = true;
            this.radBtnAUS.CheckedChanged += new System.EventHandler(this.radBtnAUS_CheckedChanged);
            // 
            // radBtnAUM
            // 
            this.radBtnAUM.Location = new System.Drawing.Point(3, 73);
            this.radBtnAUM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBtnAUM.Name = "radBtnAUM";
            this.radBtnAUM.Size = new System.Drawing.Size(107, 25);
            this.radBtnAUM.TabIndex = 4;
            this.radBtnAUM.TabStop = true;
            this.radBtnAUM.Text = "Atk Up M";
            this.radBtnAUM.UseVisualStyleBackColor = true;
            this.radBtnAUM.CheckedChanged += new System.EventHandler(this.radBtnAUM_CheckedChanged);
            // 
            // radBtnAUL
            // 
            this.radBtnAUL.Location = new System.Drawing.Point(3, 107);
            this.radBtnAUL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBtnAUL.Name = "radBtnAUL";
            this.radBtnAUL.Size = new System.Drawing.Size(107, 25);
            this.radBtnAUL.TabIndex = 5;
            this.radBtnAUL.TabStop = true;
            this.radBtnAUL.Text = "Atk Up L";
            this.radBtnAUL.UseVisualStyleBackColor = true;
            this.radBtnAUL.CheckedChanged += new System.EventHandler(this.radBtnAUL_CheckedChanged);
            // 
            // panelDrinks
            // 
            this.panelDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrinks.Controls.Add(this.lblDrinks);
            this.panelDrinks.Controls.Add(this.radBtnAUM);
            this.panelDrinks.Controls.Add(this.radBtnAUL);
            this.panelDrinks.Controls.Add(this.radBtnAUS);
            this.panelDrinks.Location = new System.Drawing.Point(14, 304);
            this.panelDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(116, 158);
            this.panelDrinks.TabIndex = 6;
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(3, 9);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(50, 20);
            this.lblDrinks.TabIndex = 6;
            this.lblDrinks.Text = "Drinks";
            // 
            // panelSkills
            // 
            this.panelSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSkills.Controls.Add(this.comboBoxAffinity);
            this.panelSkills.Controls.Add(this.lblSkillAffinity);
            this.panelSkills.Controls.Add(this.txtBoxEle);
            this.panelSkills.Controls.Add(this.lblEle);
            this.panelSkills.Controls.Add(this.comboBoxWeaponType);
            this.panelSkills.Controls.Add(this.lblWeaponType);
            this.panelSkills.Controls.Add(this.txtBoxRaw);
            this.panelSkills.Controls.Add(this.lblRaw);
            this.panelSkills.Controls.Add(this.comboBoxSharpness);
            this.panelSkills.Controls.Add(this.txtBoxHitzoneValues);
            this.panelSkills.Controls.Add(this.lblHitzoneValues);
            this.panelSkills.Controls.Add(this.txtBoxMotionValues);
            this.panelSkills.Controls.Add(this.lblSharpness);
            this.panelSkills.Controls.Add(this.lblMotionValues);
            this.panelSkills.Location = new System.Drawing.Point(14, 7);
            this.panelSkills.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSkills.Name = "panelSkills";
            this.panelSkills.Size = new System.Drawing.Size(416, 289);
            this.panelSkills.TabIndex = 7;
            // 
            // comboBoxAffinity
            // 
            this.comboBoxAffinity.FormattingEnabled = true;
            this.comboBoxAffinity.Items.AddRange(new object[] {
            "Negative",
            "Positive"});
            this.comboBoxAffinity.Location = new System.Drawing.Point(169, 160);
            this.comboBoxAffinity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAffinity.Name = "comboBoxAffinity";
            this.comboBoxAffinity.Size = new System.Drawing.Size(114, 28);
            this.comboBoxAffinity.TabIndex = 21;
            this.comboBoxAffinity.SelectedIndexChanged += new System.EventHandler(this.comboBoxAffinity_SelectedIndexChanged);
            // 
            // lblSkillAffinity
            // 
            this.lblSkillAffinity.AutoSize = true;
            this.lblSkillAffinity.Location = new System.Drawing.Point(169, 136);
            this.lblSkillAffinity.Name = "lblSkillAffinity";
            this.lblSkillAffinity.Size = new System.Drawing.Size(57, 20);
            this.lblSkillAffinity.TabIndex = 11;
            this.lblSkillAffinity.Text = "Affinity";
            // 
            // txtBoxEle
            // 
            this.txtBoxEle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEle.Location = new System.Drawing.Point(169, 92);
            this.txtBoxEle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEle.Name = "txtBoxEle";
            this.txtBoxEle.Size = new System.Drawing.Size(114, 27);
            this.txtBoxEle.TabIndex = 20;
            // 
            // lblEle
            // 
            this.lblEle.AutoSize = true;
            this.lblEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEle.Location = new System.Drawing.Point(169, 68);
            this.lblEle.Name = "lblEle";
            this.lblEle.Size = new System.Drawing.Size(75, 20);
            this.lblEle.TabIndex = 19;
            this.lblEle.Text = "Elemental";
            // 
            // comboBoxWeaponType
            // 
            this.comboBoxWeaponType.FormattingEnabled = true;
            this.comboBoxWeaponType.Items.AddRange(new object[] {
            "Greatsword",
            "Longsword",
            "Sword And Shield",
            "Dual Blades",
            "Hammer",
            "Hunting Horn",
            "Lance",
            "Gunlance",
            "Switch Axe"});
            this.comboBoxWeaponType.Location = new System.Drawing.Point(14, 33);
            this.comboBoxWeaponType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxWeaponType.Name = "comboBoxWeaponType";
            this.comboBoxWeaponType.Size = new System.Drawing.Size(75, 28);
            this.comboBoxWeaponType.TabIndex = 18;
            // 
            // lblWeaponType
            // 
            this.lblWeaponType.AutoSize = true;
            this.lblWeaponType.Location = new System.Drawing.Point(14, 9);
            this.lblWeaponType.Name = "lblWeaponType";
            this.lblWeaponType.Size = new System.Drawing.Size(99, 20);
            this.lblWeaponType.TabIndex = 17;
            this.lblWeaponType.Text = "Weapon Type";
            // 
            // txtBoxRaw
            // 
            this.txtBoxRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRaw.Location = new System.Drawing.Point(14, 92);
            this.txtBoxRaw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRaw.Name = "txtBoxRaw";
            this.txtBoxRaw.Size = new System.Drawing.Size(114, 27);
            this.txtBoxRaw.TabIndex = 16;
            this.txtBoxRaw.TextChanged += new System.EventHandler(this.txtBoxRaw_TextChanged);
            // 
            // lblRaw
            // 
            this.lblRaw.AutoSize = true;
            this.lblRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRaw.Location = new System.Drawing.Point(14, 68);
            this.lblRaw.Name = "lblRaw";
            this.lblRaw.Size = new System.Drawing.Size(83, 20);
            this.lblRaw.TabIndex = 15;
            this.lblRaw.Text = "Raw Attack";
            // 
            // comboBoxSharpness
            // 
            this.comboBoxSharpness.FormattingEnabled = true;
            this.comboBoxSharpness.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "White"});
            this.comboBoxSharpness.Location = new System.Drawing.Point(169, 33);
            this.comboBoxSharpness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSharpness.Name = "comboBoxSharpness";
            this.comboBoxSharpness.Size = new System.Drawing.Size(114, 28);
            this.comboBoxSharpness.TabIndex = 14;
            // 
            // txtBoxHitzoneValues
            // 
            this.txtBoxHitzoneValues.Location = new System.Drawing.Point(14, 209);
            this.txtBoxHitzoneValues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxHitzoneValues.Name = "txtBoxHitzoneValues";
            this.txtBoxHitzoneValues.Size = new System.Drawing.Size(114, 27);
            this.txtBoxHitzoneValues.TabIndex = 11;
            this.txtBoxHitzoneValues.TextChanged += new System.EventHandler(this.txtBoxHitzoneValues_TextChanged);
            // 
            // lblHitzoneValues
            // 
            this.lblHitzoneValues.AutoSize = true;
            this.lblHitzoneValues.Location = new System.Drawing.Point(14, 185);
            this.lblHitzoneValues.Name = "lblHitzoneValues";
            this.lblHitzoneValues.Size = new System.Drawing.Size(101, 20);
            this.lblHitzoneValues.TabIndex = 9;
            this.lblHitzoneValues.Text = "Hitzone Value";
            // 
            // txtBoxMotionValues
            // 
            this.txtBoxMotionValues.Location = new System.Drawing.Point(14, 151);
            this.txtBoxMotionValues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxMotionValues.Name = "txtBoxMotionValues";
            this.txtBoxMotionValues.Size = new System.Drawing.Size(114, 27);
            this.txtBoxMotionValues.TabIndex = 10;
            this.txtBoxMotionValues.TextChanged += new System.EventHandler(this.txtBoxMotionValues_TextChanged);
            // 
            // lblSharpness
            // 
            this.lblSharpness.AutoSize = true;
            this.lblSharpness.Location = new System.Drawing.Point(169, 9);
            this.lblSharpness.Name = "lblSharpness";
            this.lblSharpness.Size = new System.Drawing.Size(75, 20);
            this.lblSharpness.TabIndex = 13;
            this.lblSharpness.Text = "Sharpness";
            // 
            // lblMotionValues
            // 
            this.lblMotionValues.AutoSize = true;
            this.lblMotionValues.Location = new System.Drawing.Point(14, 127);
            this.lblMotionValues.Name = "lblMotionValues";
            this.lblMotionValues.Size = new System.Drawing.Size(97, 20);
            this.lblMotionValues.TabIndex = 8;
            this.lblMotionValues.Text = "Motion Value";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDamage.Location = new System.Drawing.Point(283, 349);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDamage.Size = new System.Drawing.Size(38, 46);
            this.lblDamage.TabIndex = 9;
            this.lblDamage.Text = "0";
            // 
            // titleDamage
            // 
            this.titleDamage.AutoSize = true;
            this.titleDamage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleDamage.Location = new System.Drawing.Point(163, 353);
            this.titleDamage.Name = "titleDamage";
            this.titleDamage.Size = new System.Drawing.Size(114, 35);
            this.titleDamage.TabIndex = 10;
            this.titleDamage.Text = "Damage:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxDefMod);
            this.panel1.Controls.Add(this.lblDefMod);
            this.panel1.Location = new System.Drawing.Point(437, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 289);
            this.panel1.TabIndex = 8;
            // 
            // comboBoxDefMod
            // 
            this.comboBoxDefMod.FormattingEnabled = true;
            this.comboBoxDefMod.Items.AddRange(new object[] {
            "Negative",
            "Positive"});
            this.comboBoxDefMod.Location = new System.Drawing.Point(16, 33);
            this.comboBoxDefMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDefMod.Name = "comboBoxDefMod";
            this.comboBoxDefMod.Size = new System.Drawing.Size(178, 28);
            this.comboBoxDefMod.TabIndex = 23;
            // 
            // lblDefMod
            // 
            this.lblDefMod.AutoSize = true;
            this.lblDefMod.Location = new System.Drawing.Point(16, 9);
            this.lblDefMod.Name = "lblDefMod";
            this.lblDefMod.Size = new System.Drawing.Size(124, 20);
            this.lblDefMod.TabIndex = 22;
            this.lblDefMod.Text = "Defense Modifier";
            // 
            // Form_DamageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 600);
            this.Controls.Add(this.titleDamage);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSkills);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_DamageCalculator";
            this.Text = "Form_DamageCalculator";
            this.panelDrinks.ResumeLayout(false);
            this.panelDrinks.PerformLayout();
            this.panelSkills.ResumeLayout(false);
            this.panelSkills.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalculate;
        private RadioButton radBtnAUS;
        private RadioButton radBtnAUM;
        private RadioButton radBtnAUL;
        private Panel panelDrinks;
        private Label lblDrinks;
        private Panel panelSkills;
        private Label lblSharpness;
        private Label lblSkillAffinity;
        private Label lblMotionValues;
        private Label lblHitzoneValues;
        private TextBox txtBoxMotionValues;
        private TextBox txtBoxHitzoneValues;
        private ComboBox comboBoxSharpness;
        private TextBox txtBoxRaw;
        private Label lblRaw;
        private ComboBox comboBoxWeaponType;
        private Label lblWeaponType;
        private TextBox txtBoxEle;
        private Label lblEle;
        private ComboBox comboBoxAffinity;
        private Label lblDamage;
        private Label titleDamage;
        private Panel panel1;
        private ComboBox comboBoxDefMod;
        private Label lblDefMod;
    }
}