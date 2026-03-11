using System;
using System.Collections.Generic;
using System.Text;

namespace l13
{
    internal class Visitor
    {
        public string name;
        public static int totalVisitors = 0;

        public Visitor(string name)
        {
            this.name = name;
            totalVisitors++; 
        }

        public String PrintInfo()
        {
            return name;
        }

        public static String ShowTotalVisitors()
        {
            return $"Кол-во посетителей: {totalVisitors}";
        }
    }
}
