using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Day : IEntity
    {
        public int Id { get; set; }
        public int MonthId { get; set; }
        public int WeekId { get; set; }
        public DateTime Date { get; set; }
    }
}
