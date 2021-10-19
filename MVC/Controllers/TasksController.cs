using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
namespace MVC.Controllers
{
    public class TasksController : Controller
    {
        TaskManager taskManager = new TaskManager(new EFTaskDal());
        public IActionResult Index() // buulunduğumuz tarihteki yapılacakları listeleyen sayfa
        {
            ViewBag.task = taskManager.GetAllTaskOfDay(DateTime.Now).Data;
            ViewData["Date"] = DateTime.Now.ToString("D");
            return View();
        }

        public IActionResult Week() //Haftalık plan sayfası
        {
            DateTime firstDayOfWeek;
            DateTime lastDayOfWeek;
            DateTime week = DateTime.Now;
            List<DateTime> listofdays = new List<DateTime>();

            switch ((int)week.DayOfWeek)
            {
                case 0://Haftanın ilk günü Pazar kabul edildiğinden
                    firstDayOfWeek = week.AddDays(-6).Date; // İçinde olduğumuz haftanın başı Pazartesi
                    lastDayOfWeek = week.Date; // Haftanın Sonu
                    break;

                default:// Gün Pazar değilse;
                    firstDayOfWeek = week.AddDays(1 - (int)week.DayOfWeek).Date; // İçinde olduğumuz haftanın başı Pazartesi
                    lastDayOfWeek = firstDayOfWeek.AddDays(6).Date; //  Haftanın Sonu
                    break;
            }

            for (int i = 0; i < 7; i++) // o haftadaki tarihleri getirir
            {
                DateTime date = new DateTime(firstDayOfWeek.Year, firstDayOfWeek.Month, firstDayOfWeek.Day + i);
                listofdays.Add(date);
            }
            ViewBag.ListofDays = listofdays;
            ViewBag.TaskofWeek = taskManager.GetAllTaskOfWeek(DateTime.Now).Data;
            return View();
        }
        public IActionResult Month() // Aylık yapılacaklar sayfası
        {
            DateTime FirstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ay ilk günü
            DateTime LastDayOfMonth = FirstDayOfMonth.AddMonths(1).AddDays(-1);// Ay son günü
            List<DateTime> listofdays = new List<DateTime>();
            if ((int)FirstDayOfMonth.DayOfWeek!=1)
            {
                for (int i = 0; i < (int)FirstDayOfMonth.DayOfWeek-1; i++)
                {
                    listofdays.Add(new DateTime(1, 1, 1).Date); //ayın ilk  günü pazartesi değilse ayın başladığı güne kadar 01.01.0001 tarihini atar
                }
            }
            for (int i = 0; i < (int)LastDayOfMonth.Day; i++)
            {
                DateTime date = new DateTime(FirstDayOfMonth.Year, FirstDayOfMonth.Month, FirstDayOfMonth.Day + i).Date;  // ayın tarihleri
                listofdays.Add(date);
            }
            ViewBag.ListofDays = listofdays;
            ViewBag.TaskofMonth = taskManager.GetAllTaskOfMonth(DateTime.Now.Month).Data;

            return View();
        }
        [HttpGet]
        public IActionResult ToggleIsDone(int Id) //günlük plandaki yapıldığında işaretleyebilceğimiz alanın fonksiyonu
        {
            var task = taskManager.GetById(Id).Data;
            if (task.IsDone == true)
            {
                task.IsDone = false;
            }
            else if (task.IsDone == false)
            {
                task.IsDone = true;
            }
            
            var result=taskManager.Update(task);
            ViewBag.task = taskManager.GetAllTaskOfDay(DateTime.Now).Data;
            return View("Index");
        }
       
        [HttpPost]
        public IActionResult AddTask(Tasks tasks)  // yeni görev ekleme sayfası
        {
            ViewBag.Result = new Tasks();
            taskManager.Add(tasks);
            return RedirectToAction("Index", "Tasks");
        }
        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Tasks task)  // günceleme sayfası
        {
            taskManager.Update(task);
            return RedirectToAction("Index", "Tasks");
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            ViewBag.task = taskManager.GetById(Id).Data;
            return View();
        }
        public IActionResult  Delete(int Id) // güncelleme sayasında bulunan silme butonu için silme fonksiyonu
        {
            taskManager.Delete(Id);
            return RedirectToAction("Index", "Tasks");
        }

    }
}
