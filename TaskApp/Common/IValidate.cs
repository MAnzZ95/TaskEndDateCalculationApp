using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Common
{
    public interface IValidate
    {
        bool IsValidDate(string date);
        bool IsValidNumberofDays(string days);
    }
}
