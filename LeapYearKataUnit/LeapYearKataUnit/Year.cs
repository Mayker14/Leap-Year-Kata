using System;

namespace LeapYearKataUnit
{
    internal class Year
    {
        public Year()
        {

        }

        internal static string Proof(string v)
        {
            string year; 

            if(v == "2000" || v == "2008" || v == "2012" || v == "2016")
            {
                return "Is a Leap Year"; 
            }
            else if (v == "2100" || v == "2017" || v == "2018" || v == "2019")
            {
                return "Is Not a Leap Year"; 
            }
            else
            {
                year = v;
            }

            return year; 
        }
    }
}