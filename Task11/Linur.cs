using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    struct Linur
    {
        double k;
        double b;

        public Linur(double k, double b)
        {
            this.k = k;
            this.b = b;
            
        }
        public string Root()
        {
            if (k == 0)
                return "Решений нет";
            double x = -(b / k);
          return $"Ответ Х = {x}";

        }
    }
}
