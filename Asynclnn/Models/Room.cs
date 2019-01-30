using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asynclnn.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Layouts { get; set; }
        public enum Layout
        {
            Studio=0,
            onebed=1,
            twobed=2
        }


    }
}
