namespace RecordKeeperWinForm
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.GRecordSummary = new System.Windows.Forms.DataGridView();
            this.GPartyList = new System.Windows.Forms.DataGridView();
            this.GPresidentList = new System.Windows.Forms.DataGridView();
            this.tblConnection = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNewPresident = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRecordSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPartyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPresidentList)).BeginInit();
            this.tblConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.GRecordSummary, 0, 1);
            this.tblMain.Controls.Add(this.GPartyList, 1, 1);
            this.tblMain.Controls.Add(this.GPresidentList, 0, 2);
            this.tblMain.Controls.Add(this.tblConnection, 0, 0);
            this.tblMain.Controls.Add(this.btnNewPresident, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.Size = new System.Drawing.Size(1704, 1333);
            this.tblMain.TabIndex = 0;
            // 
            // GRecordSummary
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRecordSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRecordSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRecordSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRecordSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRecordSummary.Location = new System.Drawing.Point(3, 124);
            this.GRecordSummary.Name = "GRecordSummary";
            this.GRecordSummary.RowHeadersWidth = 102;
            this.GRecordSummary.RowTemplate.Height = 49;
            this.GRecordSummary.Size = new System.Drawing.Size(846, 599);
            this.GRecordSummary.TabIndex = 0;
            // 
            // GPartyList
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GPartyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GPartyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GPartyList.DefaultCellStyle = dataGridViewCellStyle4;
            this.GPartyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPartyList.Location = new System.Drawing.Point(855, 124);
            this.GPartyList.Name = "GPartyList";
            this.GPartyList.RowHeadersWidth = 102;
            this.GPartyList.RowTemplate.Height = 49;
            this.GPartyList.Size = new System.Drawing.Size(846, 599);
            this.GPartyList.TabIndex = 1;
            // 
            // GPresidentList
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GPresidentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GPresidentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GPresidentList.DefaultCellStyle = dataGridViewCellStyle6;
            this.GPresidentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPresidentList.Location = new System.Drawing.Point(3, 729);
            this.GPresidentList.Name = "GPresidentList";
            this.GPresidentList.RowHeadersWidth = 102;
            this.GPresidentList.RowTemplate.Height = 49;
            this.GPresidentList.Size = new System.Drawing.Size(846, 601);
            this.GPresidentList.TabIndex = 2;
            // 
            // tblConnection
            // 
            this.tblConnection.ColumnCount = 5;
            this.tblMain.SetColumnSpan(this.tblConnection, 2);
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.Controls.Add(this.label1, 0, 0);
            this.tblConnection.Controls.Add(this.label2, 1, 0);
            this.tblConnection.Controls.Add(this.label3, 2, 0);
            this.tblConnection.Controls.Add(this.label4, 3, 0);
            this.tblConnection.Controls.Add(this.txtServer, 0, 1);
            this.tblConnection.Controls.Add(this.txtDB, 1, 1);
            this.tblConnection.Controls.Add(this.txtUsername, 2, 1);
            this.tblConnection.Controls.Add(this.txtPassword, 3, 1);
            this.tblConnection.Controls.Add(this.btnConnect, 4, 0);
            this.tblConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConnection.Location = new System.Drawing.Point(3, 3);
            this.tblConnection.Name = "tblConnection";
            this.tblConnection.RowCount = 2;
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.52174F));
            this.tblConnection.Size = new System.Drawing.Size(1698, 115);
            this.tblConnection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(342, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(681, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(1020, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(3, 53);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(333, 47);
            this.txtServer.TabIndex = 4;
            // 
            // txtDB
            // 
            this.txtDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDB.Location = new System.Drawing.Point(342, 53);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(333, 47);
            this.txtDB.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(681, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(333, 47);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(1020, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 47);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(1359, 3);
            this.btnConnect.Name = "btnConnect";
            this.tblConnection.SetRowSpan(this.btnConnect, 2);
            this.btnConnect.Size = new System.Drawing.Size(336, 109);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnNewPresident
            // 
            this.btnNewPresident.AutoSize = true;
            this.btnNewPresident.Location = new System.Drawing.Point(855, 729);
            this.btnNewPresident.Name = "btnNewPresident";
            this.btnNewPresident.Size = new System.Drawing.Size(220, 58);
            this.btnNewPresident.TabIndex = 4;
            this.btnNewPresident.Text = "New President";
            this.btnNewPresident.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 1333);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRecordSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPartyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPresidentList)).EndInit();
            this.tblConnection.ResumeLayout(false);
            this.tblConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView GRecordSummary;
        private DataGridView GPartyList;
        private DataGridView GPresidentList;
        private TableLayoutPanel tblConnection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtDB;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnConnect;
        private Button btnNewPresident;
    }
}