using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.model
{
    public class Branch
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameKhoa { get; set; }

        public Branch(string id, string name, string nameKhoa)
        {
            Id = id;
            Name = name;
            NameKhoa = nameKhoa;
        }
    }
}
