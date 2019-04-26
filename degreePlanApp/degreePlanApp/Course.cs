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
        public int TermID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Status { get; set; }
        public string InstructorName { get; set; }
        public string InstructorEmail { get; set; }
        public string InstructorPhone { get; set; }
        public int Notifications { get; set; }
    }
}
