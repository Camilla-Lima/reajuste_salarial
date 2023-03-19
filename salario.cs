using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reajustesalarial
{
    public class salario
    {
        public double calculosalario (double salarioatual){

            if (salarioatual <= 1700){
                double salarionovo = salarioatual + 300;
                return salarionovo;
            }

            else{
                double salarionovo = salarioatual + 200;
                return salarionovo;
            }
        }


    }
}