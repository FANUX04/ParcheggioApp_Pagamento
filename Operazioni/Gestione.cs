using System;

namespace Operazioni
{
    public class Gestione
    {
        
        public static int ContoA(int t)
        {

            int conto = 15;
            int valore=0;
            if (t>1)
            {
                valore = conto * t;
            }
            return valore;
            
        }
        public static string ContoB(int t)
        {
            int conto = t * 1;
            return $"la tariffa B costa {conto}";
        }
        public static string ContoC(int t)
        {
            double conto = 0;
            double tariffa = 1.20;
            if(t==1)
            {
               return $"se è solo per un'ora spendi {conto}";
            }
            else
            {
                conto = tariffa * (t - 1);
                return $"paghi {conto}";
            }
        }
    }
}
