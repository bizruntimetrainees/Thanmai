using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserilalization
{
    [Serializable]
    class Studen
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Studen(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
