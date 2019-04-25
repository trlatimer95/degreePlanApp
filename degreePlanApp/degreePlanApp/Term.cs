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
        public string Title { get; set; }
        public List<Course> Courses { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
