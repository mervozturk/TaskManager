using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskManager taskManager = new TaskManager(new EFTaskDal());
            //taskManager.Add(new Task {Date = new DateTime(2021,10,20), Header = "Sürüş dersi", Description = "ÇAkmak sürüş alanında", Time = "15.30", IsDone = false });
            //foreach (var item in taskManager.GetAllTaskOfWeek(DateTime.Now).Data)
            //{
            //    Console.WriteLine(item.Header);
            //}

            //    DateTime firstDayOfWeek;
            //    DateTime lastDayOfWeek;
            //    DateTime week = new DateTime(2017, 11, 10, 9, 5, 0);
            //    List<DateTime> listofdays = new List<DateTime>();

            //    switch ((int)week.DayOfWeek)
            //    {
            //        case 0://Haftanın ilk günü Pazar kabul edildiğinden
            //            firstDayOfWeek = week.AddDays(-6).Date; // İçinde olduğumuz haftanın başı Pazartesi
            //            lastDayOfWeek = week.Date; // Sonraki haftanın başı Pazartesi
            //            break;

            //        default:// Gün Pazar değilse;
            //            firstDayOfWeek = week.AddDays(1 - (int)week.DayOfWeek).Date; // İçinde olduğumuz haftanın başı Pazartesi
            //            lastDayOfWeek = firstDayOfWeek.AddDays(6).Date; //  Sonraki haftanın başı Pazartesi
            //            break;
            //    }

            //    for (int i = 0; i < 7; i++)
            //    {
            //        DateTime date = new DateTime(firstDayOfWeek.Year, firstDayOfWeek.Month, firstDayOfWeek.Day+i);
            //        listofdays.Add(date);
            //    }
            //    Console.WriteLine(listofdays.Count);
            //    foreach (var item in listofdays)
            //    {
            //        Console.WriteLine("gün "+item.ToString("d") + " " + item.DayOfWeek);
            //    }

            //DateTime FirstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ay ilk günü
            //DateTime LastDayOfMonth = FirstDayOfMonth.AddMonths(1).AddDays(-1);// Ay son günü
            //List<DateTime> listofdays = new List<DateTime>();
            //if (FirstDayOfMonth.DayOfWeek != 0)
            //{
            //    for (int i = 0; i < (int)FirstDayOfMonth.DayOfWeek; i++)
            //    {
            //        listofdays.Add(new DateTime(1,1,1));
            //    }
            //}

            //for (int i = 0; i < (int)LastDayOfMonth.Day; i++)
            //{
            //    DateTime date = new DateTime(FirstDayOfMonth.Year, FirstDayOfMonth.Month, FirstDayOfMonth.Day + i);
            //    listofdays.Add(date);
            //}

            //foreach (var item in listofdays)
            //{
            //    Console.WriteLine(item.ToString("d") + "=>" + (int)item.DayOfWeek);
            //}
        }
    }
}
