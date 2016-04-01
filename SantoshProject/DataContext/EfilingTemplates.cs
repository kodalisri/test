using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SantoshProject.DataContext
{
    public class EfilingTemplates
    {
        [Key]
        public int Templateid { get; set; }

        public string Templatename { get; set; }

        public int Resourceid { get; set; }

        public string Templatefile { get; set; }

        public string Ignoreexternalfiles { get; set; }

        public string Createuser { get; set; }

        public DateTime Createdate { get; set; }

        public string Updateuser { get; set; }
        public DateTime Updatedate { get; set; }
        public string Integrationsetting { get; set; }
    }
}