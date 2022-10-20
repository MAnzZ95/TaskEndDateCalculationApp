using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Common
{
    public class TimeConverter
    {
        public DateTime DateConvertToString(string date)
        {
           
            string format = "dd/MM/yyyy";          
            CultureInfo provider = CultureInfo.InvariantCulture;

            try
            {                
                var result = DateTime.ParseExact(date, format, provider);
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
                   
        }
    }
}
