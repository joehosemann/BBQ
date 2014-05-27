using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using BBQServ.QueueDataSetTableAdapters;

namespace BBQServ
{
    class Program
    {

        private static QueueDataSet DSQueue = new QueueDataSet();
        private static QueueTableAdapter TAQueue = new QueueTableAdapter();

        private static System.Timers.Timer _timer;

        private static int _iterations;

        static void Main(string[] args)
        {
            const int updateInterval = 5000;

            DSQueue.QueueDetails.ReadXml("QueueDetails.xml");

            // FillQueueDetailsDS();

            _timer = new System.Timers.Timer(updateInterval);
            _timer.Elapsed += UpdateQueueDataSet;

            _timer.Interval = updateInterval;
            _timer.Enabled = true;

            Console.ReadLine();
        }

        static void FillQueueDetailsDS()
        {
            DSQueue.QueueDetails.AddQueueDetailsRow(5240, "apAcct.ENT", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5241, "apAcct.ENT", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5242, "apAcct.ENT", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5243, "Acct.ENT", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5244, "Acct.ENT", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5245, "Acct.ENT", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5021, "apAcct", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5203, "apAcct", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5022, "apAcct", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5017, "Acct", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5016, "Acct", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5018, "Acct", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5298, "apAltru", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5299, "apAltru", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5300, "apAltru", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5301, "Altru", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5302, "Altru", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5303, "Altru", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5026, "AuctionT", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5027, "AuctionT", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5028, "AuctionT", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5150, "BBEC.BBDM", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5151, "BBEC.BBDM", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5152, "BBEC.BBDM", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5156, "BBEC.CRM", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5157, "BBEC.CRM", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5158, "BBEC.CRM", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5162, "BBEC.SDK", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5163, "BBEC.SDK", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5164, "BBEC.SDK", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5246, "BBNC.ENT", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5247, "BBNC.ENT", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5248, "BBNC.ENT_Down", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5249, "BBNC.ENT_Normal", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5146, "BBNC_AB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5147, "BBNC_AB", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5179, "BBNC_Down", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5148, "BBNC_Normal", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5316, "apBBNC", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5317, "apBBNC", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5318, "BBNC", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5319, "BBNC", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5312, "BBPS.ENT", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5313, "BBPS.ENT", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5314, "BBPS.ENT", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5233, "BBPS", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5234, "BBPS", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5232, "BBPS", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5030, "Class_AB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5031, "Class_AB", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5032, "Class_AB", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5046, "Crystal_A", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5035, "Crystal_A", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5036, "Crystal_A", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5289, "apDAES", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5290, "apDAES", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5291, "apDAES", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5038, "DAES", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5039, "DAES", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5040, "DAES", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5042, "DSS_AB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5041, "DSS_AB", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5043, "DSS_AB", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5054, "apEE", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5207, "apEE", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5055, "apEE", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5052, "EE", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5053, "EE", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5056, "EE", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5256, "apFW", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5257, "apFW", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5258, "apFW", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5259, "FW", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5260, "FW", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5261, "FW", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5180, "Hosting", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5181, "Hosting", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5182, "Hosting", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5067, "apInstall", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5213, "apInstall", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5068, "apInstall", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5110, "Install", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5111, "Install", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5112, "Install", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5320, "apPE", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5321, "apPE", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5076, "PE_AB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5075, "PE_AB", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5077, "PE_AB", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5322, "PE", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5323, "PE", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5078, "POS.RMS_AB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5079, "POS.RMS_AB", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5080, "POS.RMS_AB", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5250, "RE7.ENT_AP_CB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5251, "RE7.ENT_AP_CL", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5252, "RE7.ENT_AP_PH", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5253, "RE7.ENT", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5254, "RE7.ENT", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5255, "RE7.ENT", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5084, "RE7_AP_CB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5209, "RE7_AP_CL", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5085, "RE7_AP_PH", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5081, "RE7", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5082, "RE7", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5083, "RE7", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5115, "apSB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5211, "apSB", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5116, "apSB", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5117, "SB", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5118, "SB", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5119, "SB", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5306, "Sphere.ENT", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5307, "Sphere.ENT", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5308, "Sphere.ENT", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5309, "Sphere", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5310, "Sphere", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5311, "Sphere", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5324, "apSphere", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5325, "apSphere", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5326, "Sphere", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5327, "Sphere", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(5092, "TECH", "CB");
            DSQueue.QueueDetails.AddQueueDetailsRow(5093, "TECH", "CL");
            DSQueue.QueueDetails.AddQueueDetailsRow(5094, "TECH", "PH");
            DSQueue.QueueDetails.AddQueueDetailsRow(6532, "BBIS", "A");
            DSQueue.QueueDetails.AddQueueDetailsRow(6533, "BBIS", "B");


            DSQueue.QueueDetails.WriteXml("QueueDetails.xml");
        }

        static void UpdateQueueDataSet(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                TAQueue.GetData();
                TAQueue.Fill(DSQueue.Queue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            var amt = DSQueue.Queue.Count;

            Console.Clear();
            Console.WriteLine("QueueItems: " + amt + ", Iteration: " + _iterations + ", Timestamp: " + DateTime.Now);

            _iterations++;

            DSQueue.ProductQueue.Clear();

            foreach (QueueDataSet.QueueRow row in DSQueue.Queue.Rows)
            {
                if (row != null)
                {
                    var dp = new DataProcessing();

                    double serviceLevel;
                    string holdTimes;

                    //try
                    //{
                    var callersHolding = row.RouterCallsQNow;

                    if (callersHolding != 0)
                    {
                        serviceLevel = dp.ServiceLevel(row.ServiceLevelCallsToday, row.ServiceLevelCallsOfferedToday);
                        holdTimes = dp.HoldTimes(row.RouterLongestCallQ);
                    }
                    else
                    {
                        serviceLevel = 0;
                        holdTimes = "0";
                    }

                    QueueDataSet.QueueDetailsRow queueDetail =
                        DSQueue.QueueDetails.Where(x => x.CallTypeID == row.CallTypeID).FirstOrDefault();

                    if (queueDetail != null)
                    {
                        QueueDataSet.ProductRow productRow =
                            DSQueue.Product.Where(x => x.ProductName == queueDetail.ProductName).FirstOrDefault();

                        if (productRow != null)
                        {
                            DSQueue.ProductQueue.AddProductQueueRow(row.CallTypeID, callersHolding, holdTimes,
                                                                    serviceLevel,
                                                                    productRow, queueDetail.CallType);
                        }
                        else
                        {
                            var z = DSQueue.Product.AddProductRow(queueDetail.ProductName);


                            DSQueue.ProductQueue.AddProductQueueRow(row.CallTypeID, callersHolding, holdTimes,
                                                                   serviceLevel,
                                                                   z, queueDetail.CallType);


                        }
                    }
                    else
                    {
                        DSQueue.ProductQueue.AddProductQueueRow(row.CallTypeID, callersHolding, holdTimes, serviceLevel,
                                                           null, null);
                    }


                    //}
                    //catch (Exception ex)
                    //{
                    //    Console.WriteLine(ex);
                    //    Console.ReadLine();
                    //}

                }


            }

            try
            {
                DSQueue.ProductQueue.WriteXml(@"ProductQueues.xml");
              //  DSQueue.Product.WriteXml(@"Product.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            // Console.WriteLine("Iteration Complete.");
        }


    }
}
