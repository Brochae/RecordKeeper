using NUnit.Framework;
using RecordKeeperBizObjects;
using System.Data;
using CPUFramework;
using System;
using Dapper;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    public class Tests
    {
        int totalprez = 0;
        int maxpreznum = 0;
        int maxprezid = 0;
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
        }
        [Test]
        public void TestLoadPresidentDapper()
        {
            using (SqlConnection conn = new(connstring))
            {
                bizPresident prez = conn.QueryFirstOrDefault<bizPresident>("select top 1 * from president order by num");
                TestContext.WriteLine(prez.FullDescription);
            }
        }

        [Test]
        public void TestPresidentList()
        {
            DataTable dt = DataService.GetPresidentList();
            TestContext.WriteLine("Num Presidents " + dt.Rows.Count.ToString());
            Assert.IsTrue(dt.Rows.Count == totalprez);
            
             
        }
        //[Test]
        //public void TestPartyList()
        //{
        //    DataTable dt = DataService.GetPartyList();
        //    TestContext.WriteLine("Num Parties " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == 7);
           

        //}
        //[Test]
        //public void TestUSGovSummary()
        //{
        //    DataTable dt = DataService.GetUSGovRecordSummary();
        //    TestContext.WriteLine("Num Records From Summary " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == 3);
            

        //}
        [Test]
        public void TestLoadPresident()
        {
            bizPresident prez = bizPresident.Get(maxprezid);
            TestContext.WriteLine("Prez FullDescription = " + prez.FullDescription());
            Assert.IsTrue(prez.Num == maxpreznum);
        }
        [Test]
        public void TestLoadPresidentByNum()
        {
            bizPresident prez = bizPresident.Get("Num", maxpreznum);
            TestContext.WriteLine("Prez FullDescription = " + prez.FullDescription());
            Assert.IsTrue(prez.PresidentId == maxprezid);
        }
        [Test]
        public void TestNewPresident()
        {
            bizPresident prez = new bizPresident();
            prez.FirstName = "Yonason";
            prez.LastName = "Adams";
            prez.DateBorn = DateTime.Now.AddMonths(-450);
            prez.DateDied = DateTime.Now.AddMonths(24);
            prez.TermStart = DateTime.Now.Year;
            prez.PartyId = 1;
            prez.Save();
            TestContext.WriteLine("New President Num = " + prez.Num + ". Should be " + (maxpreznum + 1));
            TestContext.WriteLine("Expected Code not blank. Code = " + prez.Code);
            Assert.IsTrue(prez.Num == maxpreznum + 1 && string.IsNullOrEmpty(prez.Code)==false);
            prez.Delete();
        }
        [Test]
        public void TestChangePresidentNumber()
        {
            bizPresident prez = bizPresident.Get(maxprezid);
            prez.Num = prez.Num + 1;
            Assert.Throws<CPUException>(() => prez.Save(), "President Num cannot be changed.");
        }
        [Test]
        public void TestDeletePresidentWithExecutiveOrder()
        {
            bizPresident prez = bizPresident.Get(prezwithexecorderid);
            Assert.Throws<CPUException>(() => prez.Delete());
        }
    }
}