//using System;

using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TaskApp.Common;
using TaskApp.Controller;
using TaskApp.IService;
using TaskApp.Service;


//Using Dependancy Injection configure Holyday Service
var serviceProvider = new ServiceCollection()
            .AddSingleton<IHolydayService_22, HolydayService_22>()
            .BuildServiceProvider();
var hService = serviceProvider.GetService<IHolydayService_22>();
//Initiate objects
TimeCalculationController ctr = new TimeCalculationController(hService);
IValidate vd = new Validate();


//Console I/O section
Console.WriteLine("--------Please Enter Number According to Your Task Alocation---------");
Console.WriteLine("If Task is Pending from past then Option : 1");
Console.WriteLine("If Task is assign from Today : 2");
Console.WriteLine("Please Enter Number according to above options : ");

var option = Console.ReadLine();
var date = "";
var days = "";
var endDate = "";
bool isValidDates=false;

//I created two options check, task is old one or assign by today
switch (Convert.ToInt32(option))
{
    case 1:
        Console.WriteLine("--Your Task is Pending One So enter the date below format--");
        Console.WriteLine("Pending scince Date(yyyy-mm-dd) :");
        date = Console.ReadLine();        
        var istrue = vd.IsValidDate(date);

        if (istrue)
        {
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine("* Date is valid, Now Please enter Howmany Dates which you requested: ");
            days = Console.ReadLine();
            isValidDates =vd.IsValidNumberofDays(days);
            if (isValidDates)
            {
                Console.WriteLine("** You requested " + days + " days");
                endDate = ctr.CalculateEndDate(dt, days);
            }
            else
            {
                Console.WriteLine("--Wrong Date..Please enter the digit between 0-99--");
            }

        }
        else
        {
            Console.WriteLine("--Please Enter Valid Date Format within Current Year--");
        }
        break;

    case 2:
        Console.WriteLine("--Your Task end date is calculating from Today...--");
        Console.WriteLine("* Please Enter Howmany dates which you want to complete the Task");
        days = Console.ReadLine();
        isValidDates = vd.IsValidNumberofDays(days);
        DateTime defaultDate = new DateTime();
        if (isValidDates)
        {
            Console.WriteLine("** You requested " + days + " days");
            endDate = ctr.CalculateEndDate(defaultDate, days);
        }
        else
        {
            Console.WriteLine("--Wrong Date..Please enter the digit between 0-99--");
        }
        break;

    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}


Console.WriteLine("End Date excluding holydays :"+endDate);




