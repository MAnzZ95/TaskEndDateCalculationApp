using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Common
{
    public interface IDevideDate
    {
        int getDayfromDate(DateTime date);
        int getMonthfromDate(DateTime date);
        int getYearfromDate(DateTime date);

    }
}
