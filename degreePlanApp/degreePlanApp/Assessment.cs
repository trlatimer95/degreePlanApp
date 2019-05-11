using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace degreePlanApp
{
    class Assessment
    {
        [PrimaryKey, AutoIncrement]
        public int AssessmentId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CourseId { get; set; }
        public int Notifications { get; set; }
    }
}
