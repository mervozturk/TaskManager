using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Tasks : IEntity
    {
        public int Id { get; set; }
        public int WeekId { get; set; }
        public int MonthId { get; set; }
        public bool IsDone { get; set; }
        public DateTime Date { get; set; }
        public string  Time { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
    }
}
