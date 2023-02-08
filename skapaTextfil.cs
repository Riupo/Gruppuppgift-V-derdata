using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppupgift_VäderData
{
    internal class skapaTextfil
    {
        public static void Skapa()
        {
            string filePath = @"C:\Users\Bilal\OneDrive\Documents\Visual Studio 2022\Demos\Gruppupgift VäderData\Textfiler\UtomshusText.txt";
            Random random = new Random();
            int month = random.Next(1, 12);
            int year = random.Next(2016, 2019);
            int day = random.Next(1, 29);
            int hours = random.Next(1, 24);
            
            DateTime randomDate = new DateTime(year, month, day, hours, 0, 0);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Datum \t Plats \t Temp \t Luftfuktighet");
                writer.WriteLine(randomDate + "\t" + "");
            }

            Console.WriteLine("Textfilen har skapats.");
        }
    }
}
