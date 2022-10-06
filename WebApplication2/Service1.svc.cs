using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Azure_Rest_API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string GetBill(string PayId)
        {
            //return "Transaction having PayId " + PayId + " was successful";
            //qqqqqqqqqq
            try
            {
                string JSONresult;
                DataTable dt = new DataTable();
                dt.Columns.Add("DATA-1");
                dt.Columns.Add("DATA-2");
                dt.Columns.Add("DATA-3");
                dt.Columns.Add("DATA-4");
                dt.Rows.Add("1", "1", "1", "1");
                dt.Rows.Add("2", "2", "2", "2");
                dt.Rows.Add("3", "3", "3", "3");
                dt.Rows.Add("4", "4", "4", "4");
                dt.Rows.Add("5", "5", "5", "5");

                JSONresult = JsonConvert.SerializeObject(dt);
                return JSONresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //pppppppppppppppppppppppppp
        }

        public string PostBill(string PayId)
        {
            try
            {
                StreamWriter SW = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "//PostBill.txt", true);
                SW.WriteLine(PayId);
                SW.Close();
                SW.Dispose();
                return "Update";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
