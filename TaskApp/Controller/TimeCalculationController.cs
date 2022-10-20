using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Common;
using TaskApp.IService;
using TaskApp.Model;

namespace TaskApp.Controller
{
    //Controller for calculate the End date. I stored the logic here and return the Task End Date
    //retrive the Holydays from the holyday service
    public class TimeCalculationController
    {
        private readonly IHolydayService_22 _hService22;
        private readonly IDevideDate dDate = new DevideDate();
        private readonly Holyday hd = new Holyday();
        public TimeCalculationController(IHolydayService_22 hService22)
        {
            _hService22 = hService22;
        }

        public string CalculateEndDate(DateTime date, string noOfDays)
        {
            try
            {
                List<Holyday> strHolydays = _hService22.GetAllHolydays();
                DateTime dt = Convert.ToDateTime(date);


                int tday = dDate.getDayfromDate(dt);
                int tmonth = dDate.getMonthfromDate(dt);
                int tyear = dDate.getYearfromDate(dt);

                int dayss = Convert.ToInt32(noOfDays);
                int count = 0;

                for (int i = 1; i <= dayss; i++)
                {
                    tday += 1;

                    string ttdate = tyear + "-" + tmonth + "-" + tday;
                    if (tday == 30)
                    {
                        if (tmonth == 4)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 6)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 9)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 11)
                        {
                            tmonth += 1;
                            tday = 0;
                        }

                    }
                    else if (tday == 31)
                    {
                        if (tmonth == 1)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 3)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 5)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 7)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 8)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 10)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                        else if (tmonth == 12)
                        {
                            tmonth = 1;
                            tday = 0;
                            tyear += 1;
                        }
                    }
                    else if (tyear % 4 == 0 && tday == 29)
                    {
                        if (tmonth == 2)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                    }
                    else if (tday == 28)
                    {
                        if (tmonth == 2)
                        {
                            tmonth += 1;
                            tday = 0;
                        }
                    }

                    string tdate = tyear + "-" + tmonth + "-" + tday;
                    hd.hDate = tdate;

                    //Check the Holyday between time frame
                    foreach (Holyday item in strHolydays)
                    {
                        if (item.hDate == ttdate)
                        {
                            count++;
                            dayss += 1;
                            break;
                        }
                    }
                }

                string endDate = tyear + "-" + tmonth + "-" + tday;
                return endDate;
            }
            catch(Exception ex)
            {
                //throw ex;
                return(ex.Message);
            }
            

        }
    }
}
