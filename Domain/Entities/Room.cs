using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Room
{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
}
