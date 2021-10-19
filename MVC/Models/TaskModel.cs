using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public int WeekId { get; set; }
        public int MonthId { get; set; }
        public bool IsDone { get; set; }

        [Required(ErrorMessage ="Tarih giriniz!")]
        [Display(Name ="Tarih:")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Saat giriniz!")]
        [Display(Name = "Saat:")]
        public string Time { get; set; }

        [Required(ErrorMessage ="Başlık giriniz!")]
        [Display(Name = "Başlık:")]
        public string Header { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz!")]
        [Display(Name = "Açıklama:")]
        public string Description { get; set; }
    }
}
