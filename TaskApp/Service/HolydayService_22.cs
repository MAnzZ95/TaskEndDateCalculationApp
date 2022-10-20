using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.IService;
using TaskApp.Model;

namespace TaskApp.Service
{
    //This for 2022 holydays service if you want to get 2023 Holydays then you can create again service and interface for that
    //Also We can implement Database context and retrive data from DB
    public class HolydayService_22 : IHolydayService_22
    {
        private readonly List<Holyday> _holydays;

        public HolydayService_22()
        {
            _holydays = new List<Holyday>()
            {
                //January
                new Holyday() { hDate = "2022-1-2" },
                new Holyday() { hDate = "2022-1-8" },
                new Holyday() { hDate = "2022-1-9" },
                new Holyday() { hDate = "2022-1-14" },
                new Holyday() { hDate = "2022-1-15" },
                new Holyday() { hDate = "2022-1-16" },
                new Holyday() { hDate = "2022-1-17" },
                new Holyday() { hDate = "2022-1-22" },
                new Holyday() { hDate = "2022-1-23" },
                new Holyday() { hDate = "2022-1-29" },
                new Holyday() { hDate = "2022-1-30" },
                //Feb                
                new Holyday() { hDate = "2022-2-4" },
                new Holyday() { hDate = "2022-2-5" },
                new Holyday() { hDate = "2022-2-6" },
                new Holyday() { hDate = "2022-2-12" },
                new Holyday() { hDate = "2022-2-13" },
                new Holyday() { hDate = "2022-2-16" },
                new Holyday() { hDate = "2022-2-19" },
                new Holyday() { hDate = "2022-2-20" },
                new Holyday() { hDate = "2022-2-26" },
                new Holyday() { hDate = "2022-2-27" },
                //March
                new Holyday() { hDate = "2022-3-1" },
                new Holyday() { hDate = "2022-3-5" },
                new Holyday() { hDate = "2022-3-6" },
                new Holyday() { hDate = "2022-3-12" },
                new Holyday() { hDate = "2022-3-13" },
                new Holyday() { hDate = "2022-3-17" },
                new Holyday() { hDate = "2022-3-19" },
                new Holyday() { hDate = "2022-3-20" },
                new Holyday() { hDate = "2022-3-26" },
                new Holyday() { hDate = "2022-3-27" },
                //April
                new Holyday() { hDate = "2022-4-2" },
                new Holyday() { hDate = "2022-4-3" },
                new Holyday() { hDate = "2022-4-9" },
                new Holyday() { hDate = "2022-4-10" },
                new Holyday() { hDate = "2022-3-13" },
                new Holyday() { hDate = "2022-4-14" },
                new Holyday() { hDate = "2022-4-15" },
                new Holyday() { hDate = "2022-4-16" },
                new Holyday() { hDate = "2022-4-17" },
                new Holyday() { hDate = "2022-4-23" },
                new Holyday() { hDate = "2022-4-24" },
                new Holyday() { hDate = "2022-4-30" },
                //May
                new Holyday() { hDate = "2022-5-1" },
                new Holyday() { hDate = "2022-5-2" },
                new Holyday() { hDate = "2022-5-3" },
                new Holyday() { hDate = "2022-5-7" },
                new Holyday() { hDate = "2022-5-8" },
                new Holyday() { hDate = "2022-5-14" },
                new Holyday() { hDate = "2022-5-15" },
                new Holyday() { hDate = "2022-5-21" },
                new Holyday() { hDate = "2022-5-22" },
                new Holyday() { hDate = "2022-5-28" },
                new Holyday() { hDate = "2022-5-29" },
                //June
                new Holyday() { hDate = "2022-6-4" },
                new Holyday() { hDate = "2022-6-5" },
                new Holyday() { hDate = "2022-6-11" },
                new Holyday() { hDate = "2022-6-12" },
                new Holyday() { hDate = "2022-6-14" },
                new Holyday() { hDate = "2022-6-18" },
                new Holyday() { hDate = "2022-6-19" },
                new Holyday() { hDate = "2022-6-25" },
                new Holyday() { hDate = "2022-6-26" },
                //July
                new Holyday() { hDate = "2022-7-2" },
                new Holyday() { hDate = "2022-7-3" },
                new Holyday() { hDate = "2022-7-9" },
                new Holyday() { hDate = "2022-7-10" },
                new Holyday() { hDate = "2022-7-13" },
                new Holyday() { hDate = "2022-7-16" },
                new Holyday() { hDate = "2022-7-17" },
                new Holyday() { hDate = "2022-7-23" },
                new Holyday() { hDate = "2022-7-24" },
                new Holyday() { hDate = "2022-7-30" },
                new Holyday() { hDate = "2022-7-31" },
                //August
                new Holyday() { hDate = "2022-8-6" },
                new Holyday() { hDate = "2022-8-7" },
                new Holyday() { hDate = "2022-8-11" },
                new Holyday() { hDate = "2022-8-13" },
                new Holyday() { hDate = "2022-8-14" },
                new Holyday() { hDate = "2022-8-20" },
                new Holyday() { hDate = "2022-8-21" },
                new Holyday() { hDate = "2022-8-27" },
                new Holyday() { hDate = "2022-8-28" },
                //Sep
                new Holyday() { hDate = "2022-9-3" },
                new Holyday() { hDate = "2022-9-4" },
                new Holyday() { hDate = "2022-9-10" },
                new Holyday() { hDate = "2022-9-11" },
                new Holyday() { hDate = "2022-9-17" },
                new Holyday() { hDate = "2022-9-18" },
                new Holyday() { hDate = "2022-9-24" },
                new Holyday() { hDate = "2022-9-25" },
                //Oct
                new Holyday() { hDate = "2022-10-1" },
                new Holyday() { hDate = "2022-10-2" },
                new Holyday() { hDate = "2022-10-8" },
                new Holyday() { hDate = "2022-10-9" },
                new Holyday() { hDate = "2022-10-10" },
                new Holyday() { hDate = "2022-10-15" },
                new Holyday() { hDate = "2022-10-16" },
                new Holyday() { hDate = "2022-10-22" },
                new Holyday() { hDate = "2022-10-23" },
                new Holyday() { hDate = "2022-10-24" },
                new Holyday() { hDate = "2022-10-29" },
                new Holyday() { hDate = "2022-10-30" },
                //Nov
                new Holyday() { hDate = "2022-11-5" },
                new Holyday() { hDate = "2022-11-6" },
                new Holyday() { hDate = "2022-11-7" },
                new Holyday() { hDate = "2022-11-12" },
                new Holyday() { hDate = "2022-11-13" },
                new Holyday() { hDate = "2022-11-19" },
                new Holyday() { hDate = "2022-11-20" },
                new Holyday() { hDate = "2022-11-26" },
                new Holyday() { hDate = "2022-11-27" },
                //Dec
                new Holyday() { hDate = "2022-12-3" },
                new Holyday() { hDate = "2022-12-4" },
                new Holyday() { hDate = "2022-12-7" },
                new Holyday() { hDate = "2022-12-10" },
                new Holyday() { hDate = "2022-12-11" },
                new Holyday() { hDate = "2022-12-17" },
                new Holyday() { hDate = "2022-12-28" },
                new Holyday() { hDate = "2022-12-24" },
                new Holyday() { hDate = "2022-12-25" },
                new Holyday() { hDate = "2022-12-26" },
                new Holyday() { hDate = "2022-12-31" },

                //23 Jan
                new Holyday() { hDate = "2023-1-1" },

            };
        }
        public List<Holyday> GetAllHolydays()
        {
            return _holydays;
        }
    }
}
