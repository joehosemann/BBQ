using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Threading;
using BBQ.Properties;

namespace BBQ
{
    class DispatchTimerWorker : DispatcherObject
    {

        public DataSet DoSomething()
        {
            var ds = new DataSet();
            try
            {


//#if DEBUG
//            {
//                ds.ReadXml("ProductQueues.xml", XmlReadMode.InferSchema);
//            }
//#else
                //{
                    var xml = WebRequest.Create(Settings.Default.ProductPath) as HttpWebRequest;
                    if (xml != null) ds.ReadXml(xml.GetResponse().GetResponseStream(), XmlReadMode.InferSchema);

//                }
//#endif

                var arrayList = new ArrayList();

                EnumerableRowCollection<string> productNames = MainWindow.DSQueuePreferences.QueuePreferences.Select(x => x.ProductName);

                foreach (DataRow row in ds.Tables["Product"].Rows)
                {
                    if (!productNames.Contains(row["ProductName"]))
                    {
                        arrayList.Add(row);
                    }
                }

                foreach (DataRow r in arrayList)
                    ds.Tables["Product"].Rows.Remove(r);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            return ds;
        }
    }


}

