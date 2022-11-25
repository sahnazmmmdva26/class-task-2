using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managertask
{
    internal class Assistant : Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                Employee employee1 = GetPromotion(employee);
                Console.WriteLine("maas artirildi");
            }
            else
            {
                Console.WriteLine("biraz da isle");
            }
        }
    }
}
