using System;

namespace TimeData
{
    public class NewBaseType
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;

            // y (yyyy)= ano, M = mês, d = dia, h = hora, s = segundo, m = minutos 
            var formatada = String.Format("{0}", data);//23/02/2022 21:24:49 / ("{0:y}", data)se for mês e ano somente
            Console.WriteLine(formatada);
        }
    }

    public class Program : NewBaseType
    {
    }
}
