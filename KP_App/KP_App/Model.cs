using System;
using System.Collections.Generic;
using System.Text;

namespace KP_App
{
    class Model
    {
        public DateTime date { set; get; }
        public List<Day> days { set; get; }
    }
    public class Day
    {
        public string day { set; get; }
        public List<Lessons> lessons { set; get; }
        public List<Cabinets> cabinets { set; get; }
    }
    public class Lessons
    {
        public string[] lessons { set; get; }
    }
    public class Cabinets
    {
        public string[] cabinets { set; get; }
    }
}
