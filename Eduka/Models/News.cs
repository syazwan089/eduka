using System;
using System.Collections.Generic;
using System.Text;

namespace Eduka.Models
{
  public  class News
    {
        public int id { get; set; }
        public string pengumuman_title { get; set; }
        public string pengumuman_desc { get; set; }
        public string created_at { get; set; }
    }
}
