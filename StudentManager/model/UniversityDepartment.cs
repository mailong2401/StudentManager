using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.model
{
    public class UniversityDepartment
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public UniversityDepartment() { }

        public UniversityDepartment(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
