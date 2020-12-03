using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ArquivoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C:/Users/Rafael/OneDrive/Área de Trabalho/Pós CD/MP/Estudos de caso/Estudo de caso 4/RentalHousing.csv";

            var list = new List<RentalHousing>();

            string value;

            using (StreamReader reader = new StreamReader(path))
            {

                while ((value = reader.ReadLine()) != null)
                {
                    var dados = value.Split(",");

                    list.Add(new RentalHousing
                    {
                        HeatingSystem = dados[0],
                        YearHS = dados[1],
                        Boiler = dados[2],
                        YearB = dados[3],
                        E = dados[4] == "1" ? true : false,
                        P = dados[5] == "1" ? true : false,
                        B = dados[6] == "1" ? true : false
                    });
                }
            }

            var csv = new List<string>();


            list.ForEach(a =>
            {
                a.Classe = a.B || a.E || a.P ? true : false;
                var line = string.Join(",", string.Join(",", a.HeatingSystem, a.YearHS, a.Boiler, a.YearB, a.E, a.P, a.B, a.Classe));
                csv.Add(line);
            });


            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String item in csv)
                {
                    writer.WriteLine(item);
                }
            }

            Console.WriteLine("Fim");

        }
    }
}
