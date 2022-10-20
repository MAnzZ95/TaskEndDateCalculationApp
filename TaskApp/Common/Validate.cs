using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskApp.Common
{
    public class Validate: IValidate
    {

        public bool IsValidDate(string date)
        {
           // DateTime dt = Convert.ToDateTime(date);
            try
            {
                var regex = new Regex(@"^\d{4}-((0\d)|\d|(1[012]))-(([012]\d|\d)|3[01])$");
                var nowDate = DateTime.Now;
                var nowYear = nowDate.Year;
                string[] arrDate = date.Split('-');
                //var cdate = Convert.ToDateTime(date);
                var cYear = Convert.ToInt32(arrDate[0]);
                var cMonth = Convert.ToInt32(arrDate[1]);
                var cDay = Convert.ToInt32(arrDate[2]);

                if (regex.IsMatch(date))
                {
                    if (cYear == nowYear)
                    {
                        if (cMonth==1)
                        {
                            if(cDay>=1&&cDay<=31)
                            {
                                return true;
                            }
                            return false;
                            
                        }
                        else if(cMonth == 2)
                        {
                            if(cYear%4==0)
                            {
                                if (cDay >= 1 && cDay <= 29)
                                {
                                    return true;
                                }
                                return false;
                            }
                            else
                            {
                                if (cDay >= 1 && cDay <= 28)
                                {
                                    return true;
                                }
                                return false;
                            }
                        }
                        else if (cMonth == 3)
                        {
                            if (cDay >= 1 && cDay <= 31)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 4)
                        {
                            if (cDay >= 1 && cDay <= 30)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 5)
                        {
                            if (cDay >= 1 && cDay <= 31)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 6)
                        {
                            if (cDay >= 1 && cDay <= 30)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 7)
                        {
                            if (cDay >= 1 && cDay <= 31)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 8)
                        {
                            if (cDay >= 1 && cDay <= 31)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 9)
                        {
                            if (cDay >= 1 && cDay <= 30)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 10)
                        {
                            if (cDay >= 1 && cDay <= 31)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 11)
                        {
                            if (cDay >= 1 && cDay <= 30)
                            {
                                return true;
                            }
                            return false;
                        }
                        else if (cMonth == 12)
                        {
                            if (cDay >= 1 && cDay <= 31)
                            {
                                return true;
                            }
                            return false;
                        }
                        return false;

                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public bool IsValidNumberofDays(string days)
        {
            try
            {
                var regex = new Regex(@"^(([012]\d|\d)|3[0])$");
                if (regex.IsMatch(days))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }
    }
}
