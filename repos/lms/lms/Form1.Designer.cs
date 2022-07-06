namespace lms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMonDB = new System.Windows.Forms.Button();
            this.btnFindCharm = new System.Windows.Forms.Button();
            this.btnDamageCalc = new System.Windows.Forms.Button();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDeskPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.btnMonDB);
            this.panelMenu.Controls.Add(this.btnFindCharm);
            this.panelMenu.Controls.Add(this.btnDamageCalc);
            this.panelMenu.Controls.Add(this.panelMenuTop);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMonDB
            // 
            this.btnMonDB.FlatAppearance.BorderSize = 0;
            this.btnMonDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonDB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMonDB.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonDB.Image = global::lms.Properties.Resources.database1;
            this.btnMonDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonDB.Location = new System.Drawing.Point(0, 220);
            this.btnMonDB.Name = "btnMonDB";
            this.btnMonDB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnMonDB.Size = new System.Drawing.Size(220, 60);
            this.btnMonDB.TabIndex = 3;
            this.btnMonDB.Text = "  Monster Database";
            this.btnMonDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonDB.UseVisualStyleBackColor = true;
            this.btnMonDB.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFindCharm
            // 
            this.btnFindCharm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFindCharm.FlatAppearance.BorderSize = 0;
            this.btnFindCharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCharm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindCharm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFindCharm.Image = global::lms.Properties.Resources.decoration1;
            this.btnFindCharm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCharm.Location = new System.Drawing.Point(0, 160);
            this.btnFindCharm.Name = "btnFindCharm";
            this.btnFindCharm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnFindCharm.Size = new System.Drawing.Size(220, 60);
            this.btnFindCharm.TabIndex = 2;
            this.btnFindCharm.Text = "  Charm Finder";
            this.btnFindCharm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCharm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCharm.UseVisualStyleBackColor = false;
            this.btnFindCharm.Click += new System.EventHandler(this.btnFindCharm_Click);
            // 
            // btnDamageCalc
            // 
            this.btnDamageCalc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDamageCalc.FlatAppearance.BorderSize = 0;
            this.btnDamageCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDamageCalc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDamageCalc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDamageCalc.Image = global::lms.Properties.Resources.icon_weapon_052;
            this.btnDamageCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDamageCalc.Location = new System.Drawing.Point(0, 100);
            this.btnDamageCalc.Name = "btnDamageCalc";
            this.btnDamageCalc.Size = new System.Drawing.Size(220, 60);
            this.btnDamageCalc.TabIndex = 1;
            this.btnDamageCalc.Text = "Damage Calculator";
            this.btnDamageCalc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDamageCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDamageCalc.UseVisualStyleBackColor = false;
            this.btnDamageCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(220, 100);
            this.panelMenuTop.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(580, 100);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Source Code Pro", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(237, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDeskPane
            // 
            this.panelDeskPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskPane.Location = new System.Drawing.Point(220, 100);
            this.panelDeskPane.Name = "panelDeskPane";
            this.panelDeskPane.Size = new System.Drawing.Size(580, 350);
            this.panelDeskPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDeskPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelMenuTop;
        private Button btnDamageCalc;
        private Button btnMonDB;
        private Button btnFindCharm;
        private Panel panelTitle;
        public Label lblTitle;
        private Panel panelDeskPane;
    }
}