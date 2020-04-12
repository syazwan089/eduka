using System;
using System.Collections.Generic;
using System.Text;

namespace Eduka.Models
{
    public class Prestasi
    {
        public string id { get; set; }
        public string quiz_id { get; set; }
        public string student_id { get; set; }
        public string markah { get; set; }
        public string created_at { get; set; }
        public string quiz_name { get; set; }
        public string topic_id { get; set; }
    }
}
