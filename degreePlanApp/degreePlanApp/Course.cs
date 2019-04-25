using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace degreePlanApp
{
    class Course
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public enum Status { Completed, InProgress, Dropped, Planned }
        public string Instructor { get; set; }
    }
}
