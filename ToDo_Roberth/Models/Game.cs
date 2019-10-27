using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_Roberth.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int Minimum_Type { get; set; }
        public int Maximum_Type { get; set; }
    }
}
