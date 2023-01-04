using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using CPUFramework;
using RecordKeeperBizObjects;
using System.Data;
using NUnit.Framework;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    internal class DapperTest
    {
        int totalprez = 0;
        int maxpreznum = 0;
        int maxprezid = 0;
        int maxpartyid = 0;
        int prezwithexecorderid = 0;
        string connstring = "";

        [SetUp]
        public void Setup()
        {

            connstring = DataUtility.SetSQLExpressConnectionString("RecordKeeperDB");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select Total = count(*) from president");
            totalprez = (int)dt.Rows[0]["Total"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p order by p.num desc");
            maxpreznum = (int)dt.Rows[0]["Num"];
            maxprezid = (int)dt.Rows[0]["PresidentId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p join ExecutiveOrder e on p.PresidentId = e.PresidentId order by p.num desc");
            prezwithexecorderid = (int)dt.Rows[0]["PresidentId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 * from party order by partyId desc");
            maxpartyid = (int)dt.Rows[0]["PartyId"];
        }
        private bizPresident LoadPrez(int Id)
        {

            bizPresident prez = bizPresident.Get(Id);

            return prez;
                //using anonymous parameter
                //return conn.Query<bizPresident>("PresidentGet", new { All = true}, commandType: CommandType.StoredProcedure).ToList();
            
        }
        private bizPresident InsertNewPrez()
        {
            bizPresident prez = bizPresident.Get(0);// new bizPresident();
            prez.FirstName = "Yonason";
            prez.LastName = "Adams";
            prez.DateBorn = DateTime.Now.AddMonths(-450);
            prez.DateDied = DateTime.Now.AddMonths(24);
            prez.TermStart = DateTime.Now.Year;
            prez.PartyId = maxpartyid;

            prez.Save();
            return prez;
        }
        private int DeletePrez(int Id = 0) 
        {
            bizPresident p;
            if(Id == 0)
            {
                p = this.InsertNewPrez();
            }
            else
            {
                p = this.LoadPrez(Id);
            }
            Id = p.PresidentId;

            p.Delete();

            return Id;
        }
        private void SwapPrezFirstName(bizPresident prez)
        {
            string lastname = prez.LastName;
            string firstname = prez.FirstName;
            prez.LastName = firstname;
            prez.FirstName = lastname;
            prez.Save();

  
        }
        private void ChangePrezNum()
        {
            bizPresident prez = this.LoadPrez(maxprezid);
            prez.Num += 1;
            prez.Save();

            //DynamicParameters dp = new(prez);
            //dp.Add("Message", "",direction: ParameterDirection.InputOutput);
            //dp.Add("return_value", "", direction: ParameterDirection.ReturnValue);

            //using (SqlConnection conn = GetConnection())
            //{
            //    conn.Execute("PresidentUpdate", dp, commandType: CommandType.StoredProcedure);
            //}
            //int ret = dp.Get<int>("return_value");
            //string msg = dp.Get<string>("Message");

            //if (ret == 1)
            //{
            //    throw new CPUException(msg);
            //}

        }
        private List<bizPresident> LoadListPrez()
        {
            using (SqlConnection conn = new(DataUtility.ConnectionString))
            {
                List<bizPresident> prez = bizPresident.GetAll();

                return prez;
                
                //using anonymous parameter
                //return conn.Query<bizPresident>("PresidentGet", new { All = true}, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        [Test]

        public void TestLoadPrezList()
        {
            List<bizPresident> lst = this.LoadListPrez();
            TestContext.WriteLine("num of prez " + lst.Count);
            Assert.IsTrue(lst.Count == totalprez);
        }
        [Test]
        public void TestLoadPrez()
        {
            bizPresident p = this.LoadPrez(maxprezid);
            TestContext.WriteLine(p.FullDescription());
            Assert.IsTrue(p.Num == maxpreznum);
        }
        [Test]
        public void TestInsertNewPrez()
        {
            bizPresident p = this.InsertNewPrez();
            TestContext.WriteLine("Expected PresidenId > " + maxprezid + " Value = " + p.PresidentId);
            TestContext.WriteLine("Expected = " + (maxpreznum + 1) + " Value = " + p.Num);
            Assert.IsTrue(p.Num == maxpreznum + 1 && p.PresidentId > maxprezid);
            this.DeletePrez(p.PresidentId);
        }
        [Test]

        public void TestUpdatePrez()
        {
            bizPresident prez = this.LoadPrez(maxprezid);
            string lastname = prez.LastName;
            string firstname = prez.FirstName;
            this.SwapPrezFirstName(prez);
            prez = this.LoadPrez(maxprezid);
            TestContext.WriteLine("Original: " + firstname + " " + lastname + " Current: " + prez.FirstName + " " + prez.LastName);
            Assert.IsTrue(prez.LastName == firstname && prez.FirstName == lastname);
        }
        [Test]

        public void TestDeleteNewPrez()
        {
            int id = this.DeletePrez();
            bizPresident p = this.LoadPrez(id);
            Assert.IsTrue(p.PresidentId == 0);
        }
        [Test]

        public void TestDeletePrezWithExecOrder()
        {
            CPUException? ex = Assert.Throws<CPUException>(() => this.DeletePrez(prezwithexecorderid));
            TestContext.WriteLine(ex?.FriendlyMessage);
        }
        [Test]
        public void TestChangePrezNumber()
        {
            CPUException? ex = Assert.Throws<CPUException>(() => this.ChangePrezNum());
            TestContext.WriteLine(ex?.Message);
        }
        [Test]
        public void TestSearchPrez()
        {
            List<bizPresident> lst = bizPresident.Search("bush");
            TestContext.WriteLine("List count = " + lst.Count.ToString());
            Assert.IsTrue(lst.Count == 2);
        }
    }
}
