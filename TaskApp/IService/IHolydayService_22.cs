using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Model;

namespace TaskApp.IService
{
    //This for 2022 holydays interface if you want to get 2023 Holydays then you can create again service and interface for that
    //Also We can implement Database context and retrive data from DB
    public interface IHolydayService_22
    {
        List<Holyday> GetAllHolydays();
    }
}
