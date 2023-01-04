using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;
using RecordKeeperBizObjects;

namespace RecordKeeperWinForm
{
    public partial class frmMain : Form
    {
        int numtriestoconnect = 0;
        public frmMain()
        {
            InitializeComponent();
            btnConnect.Click += BtnConnect_Click;
            GPresidentList.CellDoubleClick += GPresidentList_CellDoubleClick;
            btnNewPresident.Click += BtnNewPresident_Click;
            txtServer.Text = "";
            txtDB.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void BtnConnect_Click(object? sender, EventArgs e)
        {
            Connect();
        }
        private void Connect()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                DataUtility.SetConnectionString(txtServer.Text, txtDB.Text, txtUsername.Text, txtPassword.Text);
                numtriestoconnect = 0;
                BindForm();
            }
            catch (SqlException ex) when (ex.Message.StartsWith("Login failed for user"))
            {
                numtriestoconnect++;
                if (numtriestoconnect < 3)
                    MessageBox.Show("Invalid username or password. You have " + (3 - numtriestoconnect).ToString() + " left to try.");

                else
                {
                    MessageBox.Show("You are out of luck. Try hacking somewhere else. Bye Bye!");
                    Application.Exit();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Unable to connect - fix the connection information and try again." + Environment.NewLine + ex.Message, "RecordKeeper");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void BindForm()
        {

            GRecordSummary.DataSource = DataService.GetUSGovRecordSummary();
            GPartyList.DataSource = DataService.GetPartyList(false);
            GPresidentList.DataSource = DataService.GetPresidentList();

            this.FormatGrid(GRecordSummary);
            this.FormatGrid(GPresidentList, "PresidentId");
            this.FormatGrid(GPartyList, "PartyId");
        }
        private void CreateNewPresident()
        {
            frmPresidentDetail f = new frmPresidentDetail();
            this.StartPosition = FormStartPosition.CenterScreen;
            f.ShowForm(0);
        }
        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridobj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridobj.RowHeadersWidth = 25;
            gridobj.AllowUserToAddRows = false;
            if (PrimaryKeyFieldName != "")
            {
                gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }
        }
        private void GPresidentList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)GPresidentList.Rows[e.RowIndex].Cells["PresidentId"].Value;
            frmPresidentDetail f = new frmPresidentDetail();
            this.StartPosition = FormStartPosition.CenterScreen;
            f.ShowForm(id);
        }
        private void BtnNewPresident_Click(object? sender, EventArgs e)
        {
            CreateNewPresident();
        }
    }
}
