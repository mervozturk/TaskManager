using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Task : IEntity
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public string  Time { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
    }
}
