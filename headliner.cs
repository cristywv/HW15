using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class headliner : opener
    {
        public string _production { get; set; }
        public headliner (string name, int hour, int fans, string production): base (name, hour, fans)
        {
            _name = name;
            _hour = hour;
            _fans = fans;
            _production = production;
        }
       
    }
}
