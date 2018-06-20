using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class opener
    {
        public string _name { get; set; }
        public int _hour { get; set; }
        public int _fans { get; set; }

        public opener (string name, int hour, int fans)
        {
            _name = name;
            _hour = hour;
            _fans = fans;
        }
    }
}
