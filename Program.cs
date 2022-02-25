using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally_ve_Mantıksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniiz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata " + ex.Message.ToString());


            }
            finally
            {
                Console.Write("İşlem Tamamlandı...");
            }

            try
            {
                //int b = int.Parse(null);
                int a = int.Parse("Test");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz: ");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Veri Tipi Uygun Değil!");
                Console.WriteLine(ex);
                Console.ReadKey();


            }
        }
    }
}
