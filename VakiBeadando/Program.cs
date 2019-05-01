using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VakiBeadando
{
    public class Program
    {
        #region Private Fields

        private static string[] felbontott_szabalyzat;
        private static string szabalyzat;

        #endregion Private Fields

        #region Private Methods

        public static void FeladatA()
        {
            List<int> emberek_szama = new List<int>
            {
                0
            };
            int index = 0;
            foreach (string item in felbontott_szabalyzat)
            {
                if (item == "(")
                {
                    index++;
                    emberek_szama.Add(0);
                }
                else if (item == ")")
                {
                    index--;
                }
                else
                {
                    emberek_szama[index]++;
                }
            }
        }

        public static void FeladatB()
        {
            int max = 0;
            int db = 0;
            foreach (string item in felbontott_szabalyzat)
            {
                if (item == "(")
                {
                    db++;
                }
                else if (item == ")")
                {
                    if (max < db)
                    {
                        max = db;
                    }
                    db--;
                }
            }
        }

        public static void FeladatC()
        {
            int db = 0;
            for (int i = 0; i < felbontott_szabalyzat.Length - 1; i++)
            {
                if (felbontott_szabalyzat[++i] != "(")
                {
                    db++;
                }
            }
        }

        public static void Main(string[] args)
        {
            StreamReader fajl = new StreamReader("UZENET.BE.txt", Encoding.Default);
            szabalyzat = fajl.ReadLine();
            fajl.Close();
            szabalyzat = szabalyzat.Replace("(", ",(,");
            szabalyzat = szabalyzat.Replace(")", ",),");
            szabalyzat = szabalyzat.Replace(" ", "");
            felbontott_szabalyzat = szabalyzat.Split(',');
            Console.WriteLine(szabalyzat);
            FeladatA();
            FeladatB();
            FeladatC();
            Console.ReadKey();
        }

        #endregion Private Methods
    }
}
