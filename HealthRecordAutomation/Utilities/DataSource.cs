using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.HealthRecordAutomation.Utilities
{
    public class DataSource
    {

        public static object[] ValidLoginData()

        {
            object[] dataset1 = new object[3];
            dataset1[0] = "admin";
            dataset1[1] = "pass";
            dataset1[2] = "OpenEMR";
            object[] dataset2 = new object[3];
            dataset2[0] = "physician";
            dataset2[1] = "physician";
            dataset2[2] = "OpenEMR";
            Object[] allData = new object[2];
            allData[0] = dataset1;
            allData[1] = dataset2;
            return allData;

        }
        public static object[] InValidLoginTest()
        {
            object[] dataset1 = new object[3];
            dataset1[0] = "John";
            dataset1[1] = "John123";
            dataset1[2] = "Invalid username or password";
            object[] dataset2 = new object[3];
            dataset2[0] = "Saul";
            dataset2[1] = "Saul123";
            dataset2[2] = "Invalid username or password";

            object[] dataset3 = new object[3];
            dataset3[0] = "peter";
            dataset3[1] = "peter123";
            dataset3[2] = "Invalid username or password";


            Object[] allData = new object[3];
            allData[0] = dataset1;
            allData[1] = dataset2;
            allData[2] = dataset3;      
            return allData;
        }    
    }
}
