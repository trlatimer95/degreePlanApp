using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace degreePlanApp
{
    class Term
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string FullDate { get; set; }
    }
}
