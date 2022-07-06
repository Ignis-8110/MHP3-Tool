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
            this.lblSkillHeroics = new System.Windows.Forms.Label();
            this.chkBoxSkillHeroics = new System.Windows.Forms.CheckBox();
            this.lblSkillAffinity = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.radBtnSkillAUM = new System.Windows.Forms.RadioButton();
            this.radBtnSkillAUL = new System.Windows.Forms.RadioButton();
            this.radBtnSkillAUS = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDamage = new System.Windows.Forms.Label();
            this.titleDamage = new System.Windows.Forms.Label();
            this.panelDrinks.SuspendLayout();
            this.panelSkills.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(382, 239);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 90);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // radBtnAUS
            // 
            this.radBtnAUS.Location = new System.Drawing.Point(3, 30);
            this.radBtnAUS.Name = "radBtnAUS";
            this.radBtnAUS.Size = new System.Drawing.Size(94, 19);
            this.radBtnAUS.TabIndex = 3;
            this.radBtnAUS.TabStop = true;
            this.radBtnAUS.Text = "Atk Up S";
            this.radBtnAUS.UseVisualStyleBackColor = true;
            // 
            // radBtnAUM
            // 
            this.radBtnAUM.Location = new System.Drawing.Point(3, 55);
            this.radBtnAUM.Name = "radBtnAUM";
            this.radBtnAUM.Size = new System.Drawing.Size(94, 19);
            this.radBtnAUM.TabIndex = 4;
            this.radBtnAUM.TabStop = true;
            this.radBtnAUM.Text = "Atk Up M";
            this.radBtnAUM.UseVisualStyleBackColor = true;
            // 
            // radBtnAUL
            // 
            this.radBtnAUL.Location = new System.Drawing.Point(3, 80);
            this.radBtnAUL.Name = "radBtnAUL";
            this.radBtnAUL.Size = new System.Drawing.Size(94, 19);
            this.radBtnAUL.TabIndex = 5;
            this.radBtnAUL.TabStop = true;
            this.radBtnAUL.Text = "Atk Up L";
            this.radBtnAUL.UseVisualStyleBackColor = true;
            // 
            // panelDrinks
            // 
            this.panelDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrinks.Controls.Add(this.lblDrinks);
            this.panelDrinks.Controls.Add(this.radBtnAUM);
            this.panelDrinks.Controls.Add(this.radBtnAUL);
            this.panelDrinks.Controls.Add(this.radBtnAUS);
            this.panelDrinks.Location = new System.Drawing.Point(12, 228);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(102, 119);
            this.panelDrinks.TabIndex = 6;
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(3, 7);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(40, 15);
            this.lblDrinks.TabIndex = 6;
            this.lblDrinks.Text = "Drinks";
            // 
            // panelSkills
            // 
            this.panelSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panelSkills.Location = new System.Drawing.Point(12, 5);
            this.panelSkills.Name = "panelSkills";
            this.panelSkills.Size = new System.Drawing.Size(364, 217);
            this.panelSkills.TabIndex = 7;
            // 
            // txtBoxEle
            // 
            this.txtBoxEle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEle.Location = new System.Drawing.Point(148, 69);
            this.txtBoxEle.Name = "txtBoxEle";
            this.txtBoxEle.Size = new System.Drawing.Size(100, 23);
            this.txtBoxEle.TabIndex = 20;
            // 
            // lblEle
            // 
            this.lblEle.AutoSize = true;
            this.lblEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEle.Location = new System.Drawing.Point(148, 51);
            this.lblEle.Name = "lblEle";
            this.lblEle.Size = new System.Drawing.Size(59, 15);
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
            this.comboBoxWeaponType.Location = new System.Drawing.Point(12, 25);
            this.comboBoxWeaponType.Name = "comboBoxWeaponType";
            this.comboBoxWeaponType.Size = new System.Drawing.Size(66, 23);
            this.comboBoxWeaponType.TabIndex = 18;
            // 
            // lblWeaponType
            // 
            this.lblWeaponType.AutoSize = true;
            this.lblWeaponType.Location = new System.Drawing.Point(12, 7);
            this.lblWeaponType.Name = "lblWeaponType";
            this.lblWeaponType.Size = new System.Drawing.Size(78, 15);
            this.lblWeaponType.TabIndex = 17;
            this.lblWeaponType.Text = "Weapon Type";
            // 
            // txtBoxRaw
            // 
            this.txtBoxRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRaw.Location = new System.Drawing.Point(12, 69);
            this.txtBoxRaw.Name = "txtBoxRaw";
            this.txtBoxRaw.Size = new System.Drawing.Size(100, 23);
            this.txtBoxRaw.TabIndex = 16;
            this.txtBoxRaw.TextChanged += new System.EventHandler(this.txtBoxRaw_TextChanged);
            // 
            // lblRaw
            // 
            this.lblRaw.AutoSize = true;
            this.lblRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRaw.Location = new System.Drawing.Point(12, 51);
            this.lblRaw.Name = "lblRaw";
            this.lblRaw.Size = new System.Drawing.Size(66, 15);
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
            this.comboBoxSharpness.Location = new System.Drawing.Point(148, 25);
            this.comboBoxSharpness.Name = "comboBoxSharpness";
            this.comboBoxSharpness.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSharpness.TabIndex = 14;
            // 
            // txtBoxHitzoneValues
            // 
            this.txtBoxHitzoneValues.Location = new System.Drawing.Point(12, 157);
            this.txtBoxHitzoneValues.Name = "txtBoxHitzoneValues";
            this.txtBoxHitzoneValues.Size = new System.Drawing.Size(100, 23);
            this.txtBoxHitzoneValues.TabIndex = 11;
            this.txtBoxHitzoneValues.TextChanged += new System.EventHandler(this.txtBoxHitzoneValues_TextChanged);
            // 
            // lblHitzoneValues
            // 
            this.lblHitzoneValues.AutoSize = true;
            this.lblHitzoneValues.Location = new System.Drawing.Point(12, 139);
            this.lblHitzoneValues.Name = "lblHitzoneValues";
            this.lblHitzoneValues.Size = new System.Drawing.Size(79, 15);
            this.lblHitzoneValues.TabIndex = 9;
            this.lblHitzoneValues.Text = "Hitzone Value";
            // 
            // txtBoxMotionValues
            // 
            this.txtBoxMotionValues.Location = new System.Drawing.Point(12, 113);
            this.txtBoxMotionValues.Name = "txtBoxMotionValues";
            this.txtBoxMotionValues.Size = new System.Drawing.Size(100, 23);
            this.txtBoxMotionValues.TabIndex = 10;
            this.txtBoxMotionValues.TextChanged += new System.EventHandler(this.txtBoxMotionValues_TextChanged);
            // 
            // lblSharpness
            // 
            this.lblSharpness.AutoSize = true;
            this.lblSharpness.Location = new System.Drawing.Point(148, 7);
            this.lblSharpness.Name = "lblSharpness";
            this.lblSharpness.Size = new System.Drawing.Size(60, 15);
            this.lblSharpness.TabIndex = 13;
            this.lblSharpness.Text = "Sharpness";
            // 
            // lblMotionValues
            // 
            this.lblMotionValues.AutoSize = true;
            this.lblMotionValues.Location = new System.Drawing.Point(12, 95);
            this.lblMotionValues.Name = "lblMotionValues";
            this.lblMotionValues.Size = new System.Drawing.Size(77, 15);
            this.lblMotionValues.TabIndex = 8;
            this.lblMotionValues.Text = "Motion Value";
            // 
            // lblSkillHeroics
            // 
            this.lblSkillHeroics.AutoSize = true;
            this.lblSkillHeroics.Location = new System.Drawing.Point(94, 53);
            this.lblSkillHeroics.Name = "lblSkillHeroics";
            this.lblSkillHeroics.Size = new System.Drawing.Size(47, 15);
            this.lblSkillHeroics.TabIndex = 9;
            this.lblSkillHeroics.Text = "Heroics";
            // 
            // chkBoxSkillHeroics
            // 
            this.chkBoxSkillHeroics.AutoSize = true;
            this.chkBoxSkillHeroics.Location = new System.Drawing.Point(94, 71);
            this.chkBoxSkillHeroics.Name = "chkBoxSkillHeroics";
            this.chkBoxSkillHeroics.Size = new System.Drawing.Size(59, 19);
            this.chkBoxSkillHeroics.TabIndex = 10;
            this.chkBoxSkillHeroics.Text = "Active";
            this.chkBoxSkillHeroics.UseVisualStyleBackColor = true;
            // 
            // lblSkillAffinity
            // 
            this.lblSkillAffinity.AutoSize = true;
            this.lblSkillAffinity.Location = new System.Drawing.Point(90, 8);
            this.lblSkillAffinity.Name = "lblSkillAffinity";
            this.lblSkillAffinity.Size = new System.Drawing.Size(46, 15);
            this.lblSkillAffinity.TabIndex = 11;
            this.lblSkillAffinity.Text = "Affinity";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(3, 8);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(33, 15);
            this.lblSkills.TabIndex = 6;
            this.lblSkills.Text = "Skills";
            // 
            // radBtnSkillAUM
            // 
            this.radBtnSkillAUM.Location = new System.Drawing.Point(3, 51);
            this.radBtnSkillAUM.Name = "radBtnSkillAUM";
            this.radBtnSkillAUM.Size = new System.Drawing.Size(79, 19);
            this.radBtnSkillAUM.TabIndex = 4;
            this.radBtnSkillAUM.TabStop = true;
            this.radBtnSkillAUM.Text = "Atk Up M";
            this.radBtnSkillAUM.UseVisualStyleBackColor = true;
            // 
            // radBtnSkillAUL
            // 
            this.radBtnSkillAUL.Location = new System.Drawing.Point(3, 76);
            this.radBtnSkillAUL.Name = "radBtnSkillAUL";
            this.radBtnSkillAUL.Size = new System.Drawing.Size(79, 19);
            this.radBtnSkillAUL.TabIndex = 5;
            this.radBtnSkillAUL.TabStop = true;
            this.radBtnSkillAUL.Text = "Atk Up L";
            this.radBtnSkillAUL.UseVisualStyleBackColor = true;
            // 
            // radBtnSkillAUS
            // 
            this.radBtnSkillAUS.Location = new System.Drawing.Point(3, 26);
            this.radBtnSkillAUS.Name = "radBtnSkillAUS";
            this.radBtnSkillAUS.Size = new System.Drawing.Size(79, 19);
            this.radBtnSkillAUS.TabIndex = 3;
            this.radBtnSkillAUS.TabStop = true;
            this.radBtnSkillAUS.Text = "Atk Up S";
            this.radBtnSkillAUS.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblSkills);
            this.panel1.Controls.Add(this.radBtnSkillAUM);
            this.panel1.Controls.Add(this.radBtnSkillAUL);
            this.panel1.Controls.Add(this.radBtnSkillAUS);
            this.panel1.Controls.Add(this.lblSkillHeroics);
            this.panel1.Controls.Add(this.chkBoxSkillHeroics);
            this.panel1.Controls.Add(this.lblSkillAffinity);
            this.panel1.Location = new System.Drawing.Point(382, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 217);
            this.panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Negative",
            "None",
            "Positive"});
            this.comboBox1.Location = new System.Drawing.Point(90, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDamage.Location = new System.Drawing.Point(229, 259);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDamage.Size = new System.Drawing.Size(32, 37);
            this.lblDamage.TabIndex = 9;
            this.lblDamage.Text = "0";
            // 
            // titleDamage
            // 
            this.titleDamage.AutoSize = true;
            this.titleDamage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleDamage.Location = new System.Drawing.Point(143, 265);
            this.titleDamage.Name = "titleDamage";
            this.titleDamage.Size = new System.Drawing.Size(89, 28);
            this.titleDamage.TabIndex = 10;
            this.titleDamage.Text = "Damage:";
            // 
            // Form_DamageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.titleDamage);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSkills);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.btnCalculate);
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
        private Label lblSkills;
        private RadioButton radBtnSkillAUM;
        private RadioButton radBtnSkillAUL;
        private RadioButton radBtnSkillAUS;
        private Label lblSharpness;
        private Label lblSkillAffinity;
        private CheckBox chkBoxSkillHeroics;
        private Label lblSkillHeroics;
        private Label lblMotionValues;
        private Label lblHitzoneValues;
        private TextBox txtBoxMotionValues;
        private TextBox txtBoxHitzoneValues;
        private ComboBox comboBoxSharpness;
        private TextBox txtBoxRaw;
        private Label lblRaw;
        private Panel panel1;
        private ComboBox comboBoxWeaponType;
        private Label lblWeaponType;
        private TextBox txtBoxEle;
        private Label lblEle;
        private ComboBox comboBox1;
        private Label lblDamage;
        private Label titleDamage;
    }
}