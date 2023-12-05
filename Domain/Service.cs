using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHourCalculator.Domain
{
    public class Service
    {
        [Key]
        public string ServiceId { get; set; }
        public string DescService { get; set; }
        public int WorkerId { get; set; }
        public Worker MyProperty { get; set; }
    }
}
