using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeviceTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;



namespace DeviceTester.Tests
{
    [TestClass()]
    public class FactoryClassTests
    {
        [TestMethod()]
        public void SelectTest()
        {
            FactoryClass f = new FactoryClass();

            // get the entire table 
            DataTable dt = f.Select();

            // if null, somethings wrong
            Assert.IsNotNull(dt);

            // ensure the serial number field is ok
            DataRow lastRow = dt.Rows[dt.Rows.Count - 1];
            string serialn = lastRow.ItemArray[1].ToString();

            Assert.IsFalse(serialn == "");
            Assert.IsFalse(serialn == null);
            Assert.IsTrue(UInt32.Parse(serialn, System.Globalization.NumberStyles.HexNumber) > 0);
        }

        [TestMethod()]
        public void GetRecordBySerialNumberTest()
        {
            // get a record from the DB
            FactoryClass f = new FactoryClass();
            FactoryClass record = f.GetRecordBySerialNumber("02000001");
            Assert.IsNotNull(record);
        }

        [TestMethod()]
        public FactoryClass GetLastRecordTest()
        {
            // get the last record in the DB
            FactoryClass f = new FactoryClass();
            FactoryClass lastrecord = f.GetLastRecord();

            Assert.IsNotNull(lastrecord);
            Assert.IsNotNull(lastrecord.SerialNumber);
            Assert.IsTrue(UInt32.Parse(lastrecord.SerialNumber, System.Globalization.NumberStyles.HexNumber) > 0);
            return lastrecord;
        }

        [TestMethod()]
        public void InsertTest()
        {
            FactoryClass f = new FactoryClass();
            f.SerialNumber = "02111111";
            f.Product = "Micro contact";
            f.TemperatureOffset = "0";
            f.Variant = "1";
            f.Frequency = "2";
            f.Country = "Ireland";
            Assert.IsTrue(f.Insert(f));
        }

        [TestMethod()]
        public void UpdateTest()
        {
            InsertTest();
            FactoryClass f = GetLastRecordTest();
            f.SerialNumber = "02222222";
            Assert.IsTrue(f.Update(f));
        }

        [TestMethod()]
        public void DeleteTest()
        {
            FactoryClass f = GetLastRecordTest();
            Assert.IsTrue(f.Delete(f));
        }
    }
}