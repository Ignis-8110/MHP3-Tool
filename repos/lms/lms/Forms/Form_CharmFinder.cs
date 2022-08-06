using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace lms.Forms
{
    public partial class Form_CharmFinder : Form
    {
        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private DataTable sqlDT = new DataTable();
        public DataSet  ds = new DataSet();
        private SQLiteDataAdapter database;


        #region textboxbooleans
        bool txtAnySkill;
        bool txtSkill1;
        bool txtSkill2;
        bool txtSlots;
        bool txtTables;
        #endregion
        public Form_CharmFinder()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeSQLConnection()
        {
            sqlConnection = new SQLiteConnection("Data Source = C:\\Users\\E\\OneDrive\\GitHub\\MHP3-Tool\\repos\\lms\\lms\\Resources\\mhp3_charms.db");
        }

        private void LoadData()
        {
            InitializeSQLConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
            string commandText = "SELECT Charm_Name, Skill_1, Skill_2, Charm_Slot, Table_No FROM charms_table";
            database = new SQLiteDataAdapter(commandText, sqlConnection);
            ds.Reset();
            database.Fill(ds);
            sqlDT = ds.Tables[0];
            dataGridView1.DataSource = sqlDT;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[3].Width = 25;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[4].Width = 30;
            sqlConnection.Close();

        }

        private string FindCharm(bool anySkill, bool skill1, bool skill2, bool slot, bool table)
        {
            string command = "";
            if (anySkill && (!skill1 || !skill2))
            {
                command += " AND (Skill_1 LIKE '%" + txtbxAnySkill.Text + "%' OR Skill_2 LIKE '%" + txtbxAnySkill.Text + "%')";
            }

            if (skill1)
            {
                command += " AND Skill_1 LIKE '%" + txtbxSkill1.Text + "%'";
            }

            if (skill2)
            {
                command += " AND Skill_2 LIKE '%" + txtbxSkill2.Text + "%'";
            }

            if (slot)
            {
                command+= " AND Charm_Slot == " + txtbxSlot.Text;
            }

            if (table)
            {
                command += " AND Table_No == " + txtbxTable.Text; 
            }

            
            return command += ";";
        }

        

        private void btnFindCharm_Click(object sender, EventArgs e)
        {
            InitializeSQLConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
            string commandText = "SELECT Charm_Name, Skill_1, Skill_2, Charm_Slot, Table_No FROM charms_table WHERE ID > 0 " + FindCharm(txtAnySkill,txtSkill1, txtSkill2, txtSlots, txtTables);
            database = new SQLiteDataAdapter(commandText, sqlConnection);
            ds.Reset();
            database.Fill(ds);
            sqlDT = ds.Tables[0];
            dataGridView1.DataSource = sqlDT;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[3].Width = 25;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[4].Width = 30;
            sqlConnection.Close();
        }

        private void txtbxTable_TextChanged(object sender, EventArgs e)
        {
            if (txtbxTable.Text.Length > 0)
            {
                txtTables = true;
            }
            else
            {
                txtTables = false;
            }
        }

        private void txtbxSlot_TextChanged(object sender, EventArgs e)
        {

            if (txtbxSlot.Text.Length > 0)
            {
                txtSlots = true;
            }
            else
            {
                txtSlots = false;
            }
        }

        private void txtbxSkill2_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSkill2.Text.Length > 0)
            {
                txtSkill2 = true;
                txtbxAnySkill.Enabled = false;
            }
            else
            {
                txtSkill2 = false;
                txtbxAnySkill.Enabled = true;
            }
        }

        private void txtbxSkill1_TextChanged(object sender, EventArgs e)
        {
  
            if (txtbxSkill1.Text.Length > 0)
            {
                txtSkill1 = true;
                txtbxAnySkill.Enabled = false;
            }
            else
            {
                txtSkill1 = false;
                txtbxAnySkill.Enabled = true;
            }
        }

        private void txtbxAnySkill_TextChanged(object sender, EventArgs e)
        {
            if (txtbxAnySkill.Text.Length > 0)
            {
                txtAnySkill = true;
            }
            else
            {
                txtAnySkill = false;
            }
        }


        private void lblTable_Click(object sender, EventArgs e)
        {

        }

        private void lblSkill2_Click(object sender, EventArgs e)
        {

        }

        private void lblSkill1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
