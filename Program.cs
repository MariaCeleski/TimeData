using System.Globalization;
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

            //Comparando datas - se puxar as horas podem dar conflitos 
            if (data.Date > DateTime.Now.Date) //então chama somente a data DateTime.Now.Date
                Console.WriteLine("É igual");
            Console.WriteLine(data);

            //globalização de horas - CultureInfo pega o local do servidor que está rodando
            //pode usar somente o CultureInfo e dar crtl + . e chamar o using
            var pt = new System.Globalization.CultureInfo("pt-PT");
            var br = new System.Globalization.CultureInfo("pt-BR");
            var en = new System.Globalization.CultureInfo("en-US");
            var de = new System.Globalization.CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D", atual));//ou
            Console.WriteLine(string.Format("{0:D}", DateTime.Now));//ou

            var UtcNowTime = DateTime.UtcNow;
            Console.WriteLine(UtcNowTime.ToLocalTime());

            //exemplo se o usuario estiver na australia
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(UtcNowTime, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            //para listar todas as timezones
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(UtcNowTime, timezone));
                Console.WriteLine("-------------");
            }
        }
    }


}
