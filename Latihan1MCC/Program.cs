using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1MCC
{
    public class Program
    {
        public static void Main()
        {

            int pilih, i;
            double hasilbmi, bmi1, bmi2;
            string cetak;
            int jml = 0;
            for (; ; )
            {
                string pilihan = "yes";

                if (jml != 0)
                {
                    Console.Write("You want Restart? [yes/no]: ");
                    pilihan = Console.ReadLine();
                }
                if (pilihan.ToLower() == "no" && jml != 0)
                {
                    break;
                }
                else if (pilihan.ToLower() == "yes" && jml != 0 || jml == 0)
                {
                    Console.WriteLine("Input Number from 1 - 4");
                    Console.WriteLine("1. Body Max Index");
                    Console.WriteLine("2. Reprint Name");
                    Console.WriteLine("3. Print Even's Character");
                    Console.WriteLine("4. Sum The Input Array");
                    pilih = Convert.ToInt16(Console.ReadLine());

                    switch (pilih)
                    {
                        case 1:
                            Console.Write("Input your weight(kg): ");
                            bmi1 = double.Parse(Console.ReadLine());
                            Console.Write("Input Your Height(cm):");
                            bmi2 = double.Parse(Console.ReadLine());
                            bmi2 = bmi2 / 100;
                            hasilbmi = bmi1 / (bmi2 * bmi2);
                            if (hasilbmi < 18.1)
                            {
                                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are Underweight");
                            }
                            else if ((hasilbmi >= 18.1) && (hasilbmi <= 23.1))
                            {
                                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are Normal");
                            }
                            else if ((hasilbmi >= 23.1) && (hasilbmi <= 28.1))
                            {
                                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are overweight");
                            }
                            else
                            {
                                Console.WriteLine("Your BMI" + " " + hasilbmi + ", " + "you are obesitas");
                            }
                            break;

                        case 2:
                            Console.Write("Please Input Name: ");
                            cetak = Console.ReadLine();
                            char[] a = cetak.ToCharArray();
                            for (i = 0; i < cetak.Length; i++)
                            {
                                Console.WriteLine("Huruf ke " + (i + 1) + " adalah " + a[i]);
                            }
                            Console.ReadLine();
                            break;

                        case 3:
                            string nama;
                            Console.WriteLine("Input your name: ");
                            nama = Console.ReadLine();
                            char[] per = nama.ToCharArray();
                            for (i = 0; i < per.Length; i++)
                            {
                                if (i % 2 == 1)
                                {
                                    Console.Write(per[i]);
                                }
                            }
                            Console.ReadLine();
                            break;

                        case 4:
                            int angka;
                            Console.Write("Input number aray = ");
                            angka = Convert.ToInt16(Console.ReadLine());
                            int z = 0;
                            int y = 0;
                            for (i = 1; i <= angka; i++)
                            {
                                z = Convert.ToInt16(Console.ReadLine());
                                y = y + z;
                            }
                            Console.Write("Result Sum Array is " + y);
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("please input number from 1 - 4");
                            Console.ReadLine();
                            break;
                    }
                    jml++;
                }
            }
        }
    }
}
