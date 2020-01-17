using System;
using System.Collections.Generic;
using System.Text;

namespace Eduka.Models
{
    public class Soalan
    {
        public string task_id { get; set; }
        public string task_question { get; set; }
        public string task_image { get; set; }
        public string task_answers_a { get; set; }
        public string task_answers_b { get; set; }
        public string task_answers_c { get; set; }
        public string task_ans { get; set; }
        public string quiz_id { get; set; }
    }
}
