using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_AAE.Class
{
    internal class Contabilidad
    {
        static private readonly int[] valores = { 200, 100, 50, 20, 10, 5, 2, 1 };
        static public IEnumerable DesglosarDinero(int dinero)
        {
            int desglose = 0;
            string sol = "";
            string resultado = "";

            if (dinero > 0)
            {
                for(int i = 0; i < valores.Length; i++)
                {
                    desglose = dinero / valores[i];
                    dinero = dinero % valores[i];
                    if (i < 5)
                    {
                        if (desglose == 1)
                            resultado = string.Format("{0} billete de {1} soles", 1, valores[i]);
                        else if (desglose > 1)
                            resultado = string.Format("{0} billetes de {1} soles", desglose, valores[i]);
                    }
                    else 
                    {
                        sol = (i == 6) ? "sol" : "soles";
                        if (desglose == 1)
                            resultado = string.Format("{0} moneda de {1} {2}", 1, valores[i], sol);
                        else if (desglose > 0)
                            resultado = string.Format("{0} monedas de {1} {2}", desglose, valores[i], sol);
                    }
                    if(desglose != 0)
                        yield return resultado;
                }
            }
        }
    }
}
