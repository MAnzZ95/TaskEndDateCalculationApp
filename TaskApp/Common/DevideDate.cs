using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Common
{
    public class DevideDate :IDevideDate
    {
        DateTime currentDate = DateTime.Now;
        
        public int getDayfromDate(DateTime date)
        {
            try
            {
                var tday = 0;

                if (date == DateTime.MinValue)
                {

                    tday = currentDate.Day;
                    return tday;
                }
                else
                {

                    currentDate = Convert.ToDateTime(date);
                    tday = currentDate.Day;
                    return tday;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            
        }
        public int getMonthfromDate(DateTime date)
        {

            try
            {
                var tmonth = 0;

                if (date == DateTime.MinValue)
                {
                    tmonth = currentDate.Month;
                    return tmonth;
                }
                else
                {
                    currentDate = Convert.ToDateTime(date);
                    tmonth = currentDate.Month;
                    return tmonth;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public int getYearfromDate(DateTime date)
        {
            try
            {
                var tyear = 0;

                if (date == DateTime.MinValue)
                {
                    tyear = currentDate.Year;
                    return tyear;
                }
                else
                {
                    currentDate = Convert.ToDateTime(date);
                    tyear = currentDate.Year;
                    return tyear;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
