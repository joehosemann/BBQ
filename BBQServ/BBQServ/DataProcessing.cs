using System;

namespace BBQServ
{
    public class DataProcessing
    {

        public double ServiceLevel(int serviceLevelCallsToday, int serviceLevelCallsOfferedToday)
        {
            if (serviceLevelCallsToday != 0 && serviceLevelCallsOfferedToday != 0)
            {
                return ((float) serviceLevelCallsToday/(float) serviceLevelCallsOfferedToday);
            }
            return 0;
        }

        public string HoldTimes(DateTime routerLongestCallQ)
        {
            if (routerLongestCallQ != null)
            {
                return (DateTime.Now - routerLongestCallQ).ToString();
            }
            return "0";
           
        }




    }
}
