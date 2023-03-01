using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Kektura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szakasz> szakaszok = FileScan(@"C:\Users\Birinyi Barnabás\Downloads\kektura.txt");

            //Task3(szakaszok);
            //Task4(szakaszok);
            //Task5(szakaszok);
            Task6(szakaszok);


            Console.ReadLine();
        }
        // Metódus ami beolvas egy fájlt 
        public static List<Szakasz> FileScan(string filePath)
        {
            //empty list
            List<Szakasz> szakaszok = new();

            string fileContent = File.ReadAllText(filePath);
            string[] result = fileContent.Split(Environment.NewLine);
            for (int i = 1; i < result.Length; ++i)
            {
                string[] splittedLine = result[i].Split(';');
                szakaszok.Add(new Szakasz(splittedLine));
            }
            return szakaszok;
        }

        #region Task3
        //Kiiratni, hogy hány szakasz található a Kéktúra állományban
        public static void Task3(List<Szakasz> szakaszok)
        {
            Console.WriteLine(szakaszok.Count);
        }
        #endregion

        #region Task4
        //Határozza meg és írja ki a képernyőre a minta szerint a túra teljes hosszát!
        public static void Task4(List<Szakasz> szakaszok)
        {
            double sum = 0;
            for (int i = 0; i < szakaszok.Count; i++)
            {
                sum += szakaszok[i].Lenght;
            }
            Console.WriteLine(sum);
        }
        #endregion

        #region Task5
        // Keresse meg és írja ki a képernyőre a túra legrövidebb szakaszának adatait a minta szerint!
        //Feltételezheti, hogy nincs kért egyforma hosszúságú szakasz!
        public static void Task5(List<Szakasz> szakaszok)
        {            
            double min = szakaszok[0].Lenght;
            for (int i = 0; i < szakaszok.Count; i++)
            {
                if (szakaszok[i].Lenght < min)
                {
                    min = szakaszok[i].Lenght;
                }
            }
            Console.WriteLine(min);
        }
        #endregion
        #region Task6
        //        Készítsen logikai értékkel visszatérő függvényt(vagy jellemzőt) HianyosNev
        //azonosítóval, melynek segítségével minősíteni tudja a túraszakaszok végpontjainak a
        //nevét! Hiányos állomásneveknek minősítjük azokat a végpontneveket, melyek
        //pecsételőhelyek, de a „pecsetelohely” karakterlánc nem található meg a nevükben.Ebben
        //az esetben logikai igaz értékkel térjen vissza a függvény (vagy jellemző), egyébként pedig
        //hamissal.
        public static void Task6(List<Szakasz> szakaszok)
        {
                    
        }
        #endregion
        public static void Task7(List<Szakasz> szakaszok)
        {


        }

        public static void Task8(List<Szakasz> szakaszok)
        {


        }

        public static void Task9(List<Szakasz> szakaszok)
        {


        }
    }
}


