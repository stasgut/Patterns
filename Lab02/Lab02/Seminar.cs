using System;
using System.Collections.Generic;

namespace Lab02
{
    public class Seminar
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime deadline { get; set; }
        public List<string> items = new List<string>();
        public float status { get; set; }
        public string relatedCourse { get; set; }

        public string ImplementItem(string itemName)
        {
            return "gag";
        }

        public void AddComment(Staff person)
        {
            //
        }
    }
}