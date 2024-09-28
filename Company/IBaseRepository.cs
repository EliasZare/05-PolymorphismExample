using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public interface IBaseRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public string Gender { get; set; }
        public bool IsRemoved { get; set; }

        public void Remove();
        public void Restore();

    }
}
