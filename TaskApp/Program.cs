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
Console.WriteLine();
Console.WriteLine("1. If Task is Pending from past then Option : 1");
Console.WriteLine("2. If Task is assign from Today : 2");
Console.Write("Please Enter Number here, according to above options : ");

var option = Console.ReadLine();
var date = "";
var days = "";
var endDate = "";
bool isValidDates=false;

//I created two options check, task is old one or assign by today
switch (Convert.ToInt32(option))
{
    case 1:
        Console.WriteLine();
        Console.WriteLine("--Your Task is Pending One So enter the date below format--");
        Console.WriteLine();
        Console.Write("Pending scince Date(yyyy-mm-dd) : ");
        date = Console.ReadLine();        
        var istrue = vd.IsValidDate(date);

        if (istrue)
        {
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine();
            Console.Write("* Date is valid, Now Please enter Howmany Dates which you requested to complete: ");
            days = Console.ReadLine();
            isValidDates =vd.IsValidNumberofDays(days);
            if (isValidDates)
            {
                Console.WriteLine();
                Console.WriteLine("** You requested " + days + " days");
                endDate = ctr.CalculateEndDate(dt, days);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("--Wrong Date..Please enter the digit between 0-99--");
            }

        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("--Please Enter Valid Date Format within Current Year--");
        }
        break;

    case 2:
        Console.WriteLine();
        Console.WriteLine("--Your Task end date is calculating from Today...--");
        Console.Write("* Please Enter Howmany dates which you want to complete the Task : ");
        days = Console.ReadLine();
        isValidDates = vd.IsValidNumberofDays(days);
        DateTime defaultDate = new DateTime();
        if (isValidDates)
        {
            Console.WriteLine();
            Console.WriteLine("** You requested " + days + " days");
            endDate = ctr.CalculateEndDate(defaultDate, days);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("-- Wrong Date..Please enter the digit between 0-30 --");
        }
        break;

    default:
        Console.WriteLine();
        Console.WriteLine("Looking forward to theWork with you.");
        break;
}

if(endDate=="")
{
    Console.WriteLine();
    Console.WriteLine("Try Again!!");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Task end date except holydays :" + endDate);
}





