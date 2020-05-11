using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Views.Home;

namespace Test.Models
{
    public class News
    {
        public int ID { get; set; }

        public string Thumb { get; set; }

        public string Slag { get; set; }

        public List<NewsLang> Info { get; set; }

    }
}
