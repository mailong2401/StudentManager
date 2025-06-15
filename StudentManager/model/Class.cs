using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.model
{
    public class Class
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string nameNganh { get; set; }

        public Class() { }

        public Class(string id, string name, string nameNganh)
        {
            this.Id = id;
            this.Name = name;
            this.nameNganh = nameNganh;
        }
    }
}
