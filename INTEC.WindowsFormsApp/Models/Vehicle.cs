using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEC.WindowsFormsApp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public string EnrollNumber { get; set; }
        public int MarkId { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public string Picture { get; set; }
        public string Descripcion { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
