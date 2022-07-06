namespace lms.Forms
{
    partial class Form_CharmFinder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSkill1 = new System.Windows.Forms.Label();
            this.lblSkill2 = new System.Windows.Forms.Label();
            this.btnFindCharm = new System.Windows.Forms.Button();
            this.lblSlot = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtbxSkill1 = new System.Windows.Forms.TextBox();
            this.txtbxSkill2 = new System.Windows.Forms.TextBox();
            this.txtbxSlot = new System.Windows.Forms.TextBox();
            this.txtbxTable = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxAnySkill = new System.Windows.Forms.TextBox();
            this.lblAnySkill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(211, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(577, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "cm_id";
            this.ID.Name = "ID";
            // 
            // lblSkill1
            // 
            this.lblSkill1.AutoSize = true;
            this.lblSkill1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSkill1.Location = new System.Drawing.Point(7, 50);
            this.lblSkill1.Name = "lblSkill1";
            this.lblSkill1.Size = new System.Drawing.Size(48, 20);
            this.lblSkill1.TabIndex = 1;
            this.lblSkill1.Text = "Skill 1";
            this.lblSkill1.Click += new System.EventHandler(this.lblSkill1_Click);
            // 
            // lblSkill2
            // 
            this.lblSkill2.AutoSize = true;
            this.lblSkill2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSkill2.Location = new System.Drawing.Point(7, 83);
            this.lblSkill2.Name = "lblSkill2";
            this.lblSkill2.Size = new System.Drawing.Size(48, 20);
            this.lblSkill2.TabIndex = 2;
            this.lblSkill2.Text = "Skill 2";
            this.lblSkill2.Click += new System.EventHandler(this.lblSkill2_Click);
            // 
            // btnFindCharm
            // 
            this.btnFindCharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCharm.Location = new System.Drawing.Point(0, 192);
            this.btnFindCharm.Name = "btnFindCharm";
            this.btnFindCharm.Size = new System.Drawing.Size(200, 46);
            this.btnFindCharm.TabIndex = 3;
            this.btnFindCharm.Text = "Find Charm";
            this.btnFindCharm.UseVisualStyleBackColor = true;
            this.btnFindCharm.Click += new System.EventHandler(this.btnFindCharm_Click);
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSlot.Location = new System.Drawing.Point(20, 116);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(35, 20);
            this.lblSlot.TabIndex = 4;
            this.lblSlot.Text = "Slot";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTable.Location = new System.Drawing.Point(11, 149);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 20);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table";
            this.lblTable.Click += new System.EventHandler(this.lblTable_Click);
            // 
            // txtbxSkill1
            // 
            this.txtbxSkill1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxSkill1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxSkill1.Location = new System.Drawing.Point(61, 48);
            this.txtbxSkill1.Name = "txtbxSkill1";
            this.txtbxSkill1.Size = new System.Drawing.Size(130, 27);
            this.txtbxSkill1.TabIndex = 6;
            this.txtbxSkill1.TextChanged += new System.EventHandler(this.txtbxSkill1_TextChanged);
            // 
            // txtbxSkill2
            // 
            this.txtbxSkill2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxSkill2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxSkill2.Location = new System.Drawing.Point(61, 81);
            this.txtbxSkill2.Name = "txtbxSkill2";
            this.txtbxSkill2.Size = new System.Drawing.Size(130, 27);
            this.txtbxSkill2.TabIndex = 7;
            this.txtbxSkill2.TextChanged += new System.EventHandler(this.txtbxSkill2_TextChanged);
            // 
            // txtbxSlot
            // 
            this.txtbxSlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxSlot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxSlot.Location = new System.Drawing.Point(61, 114);
            this.txtbxSlot.Name = "txtbxSlot";
            this.txtbxSlot.Size = new System.Drawing.Size(130, 27);
            this.txtbxSlot.TabIndex = 8;
            this.txtbxSlot.TextChanged += new System.EventHandler(this.txtbxSlot_TextChanged);
            // 
            // txtbxTable
            // 
            this.txtbxTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxTable.Location = new System.Drawing.Point(61, 147);
            this.txtbxTable.Name = "txtbxTable";
            this.txtbxTable.Size = new System.Drawing.Size(130, 27);
            this.txtbxTable.TabIndex = 9;
            this.txtbxTable.TextChanged += new System.EventHandler(this.txtbxTable_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbxAnySkill);
            this.panel1.Controls.Add(this.lblAnySkill);
            this.panel1.Controls.Add(this.btnFindCharm);
            this.panel1.Controls.Add(this.txtbxTable);
            this.panel1.Controls.Add(this.txtbxSkill1);
            this.panel1.Controls.Add(this.lblSlot);
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Controls.Add(this.txtbxSlot);
            this.panel1.Controls.Add(this.lblSkill1);
            this.panel1.Controls.Add(this.txtbxSkill2);
            this.panel1.Controls.Add(this.lblSkill2);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtbxAnySkill
            // 
            this.txtbxAnySkill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxAnySkill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxAnySkill.Location = new System.Drawing.Point(61, 15);
            this.txtbxAnySkill.Name = "txtbxAnySkill";
            this.txtbxAnySkill.Size = new System.Drawing.Size(130, 27);
            this.txtbxAnySkill.TabIndex = 11;
            this.txtbxAnySkill.TextChanged += new System.EventHandler(this.txtbxAnySkill_TextChanged);
            // 
            // lblAnySkill
            // 
            this.lblAnySkill.AutoSize = true;
            this.lblAnySkill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnySkill.Location = new System.Drawing.Point(3, 19);
            this.lblAnySkill.Name = "lblAnySkill";
            this.lblAnySkill.Size = new System.Drawing.Size(60, 19);
            this.lblAnySkill.TabIndex = 10;
            this.lblAnySkill.Text = "Any Skill";
            // 
            // Form_CharmFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_CharmFinder";
            this.Text = "Form_CharmFinder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private Label lblSkill1;
        private Label lblSkill2;
        private Button btnFindCharm;
        private Label lblSlot;
        private Label lblTable;
        private TextBox txtbxSkill1;
        private TextBox txtbxSkill2;
        private TextBox txtbxSlot;
        private TextBox txtbxTable;
        private Panel panel1;
        private TextBox txtbxAnySkill;
        private Label lblAnySkill;
    }
}