using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usman_MidtermFirst.Models
{
    public class Workshop
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public int Capacity { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public bool IsFull
        {
            get { return (this.Enrollments.Count == this.Capacity); }
        }
    }
}
