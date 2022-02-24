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
            //("{0:dd/MM/yyyy hh:mm:ss ff zz}", data)para data e hora com ff fração de segundos. zz time zone, no Brasil é -3
            //"{0:t}" = short datetime = 1:14 PM hora
            //"{0:d}" = short datetime = 7/8/2022 data
            //"{0:T}" = short datetime = 1:14:57 PM
            //"{0:D}" = short datetime = wednesday, July 8, 2022
            //"{0:f}" = short datetime = 1:14:57 PM wednesday, July 8, 2022
            //"{0:g}" = short datetime = 1:14 PM 7/8/2022
            //"{0:r}" = short datetime = Wed, 08 Jul 2022 13:16:55 GMT
            //"{0:s}" = short datetime = converter para front end
            //"{0:g}" = short datetime = padrão universal noSQL mongo
            //"{0:u}" = short datetime = formato json

            Console.WriteLine(formatada);

            Console.WriteLine("--------------------");

            var dateTe = DateTime.Now;
            Console.WriteLine(dateTe);
            Console.WriteLine(dateTe.AddDays(-12));
            Console.WriteLine(dateTe.AddMonths(1));
            Console.WriteLine(dateTe.AddHours(1));
        }
    }


}
