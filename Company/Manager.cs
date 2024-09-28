using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Manager : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public string Gender { get; set; }
        public bool IsRemoved { get; set; }
        public double CalculateSalary(int dayCount, string gender)
        {
            switch (gender)
            {
                case "man":
                    return dayCount * 100;
                    break;
                case "woman":
                    return dayCount * 150;
                    break;
                default:
                    return dayCount * 100;
                    break;
            }
        }

        public double CalculateSalary(int dayCount, int organization)
        {
            switch (organization)
            {
                case 1:
                    return dayCount * 100;
                    break;
                case 2:
                    return dayCount * 9999999;
                    break;
                default:
                    return dayCount * 100;
                    break;
            }
        }

        public string GetName()
        {
            return this.Name;
        }

        public void Remove()
        {
            this.IsRemoved = true;
        }

        public void Restore()
        {
            this.IsRemoved = false;

        }
    }
}
