using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public interface IEmployee:IBaseRepository
    {
        public string GetName();
        public double CalculateSalary(int dayCount, string gender);
        public double CalculateSalary(int dayCount, int organization);
    }
}
