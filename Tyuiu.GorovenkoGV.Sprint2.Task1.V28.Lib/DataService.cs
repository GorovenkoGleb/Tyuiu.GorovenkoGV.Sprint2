using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorovenkoGV.Sprint2.Task1.V28.Lib
//int a = 247;
//int b = 654;
//int c = 671;
//int d = 671;
//true, false, true, false, true, false
{
    public class DataService : ISprint2Task1V28
    {

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c != d);
            res[1] = (a > b) & (c != d);
            res[2] = (a < b) || (c != d);
            res[3] = (a > b) && (c != d);
            res[4] = !(!res[0]);
            res[5] = (a < b) ^ (c == d);

            return res;
        }
    }
}
