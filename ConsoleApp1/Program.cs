using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String NumTarjeta = "1245874512536589";
            //int tam_var = NumTarjeta.Length;
            //String Var_Sub = NumTarjeta.Substring(tam_var - 4);


            //Console.Write(Var_Sub);

            string ClsCommon = "3456123434561234";

            if (ClsCommon.Length == 16)
            {
                int tam = ClsCommon.Length;
              string var=  string.Concat("XXXXXXXXXXXX",ClsCommon.Substring(tam-15));
                Console.Write(var);

            }

        }
    }
}














