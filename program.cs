using System;

namespace hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*try{
            Console.WriteLine("Bir sayı girimiz:");
            int sayi = Convert. ToInt32(Console. ReadLine( ));
            Console. WriteLine("Girmis oldugunuz sayı :" + sayi) ;
           }
            catch (Exception ex){
                Console.WriteLine("Hata: "+ ex.Message.ToString() );
            }
            
            finally{
                Console.Write("Islem tamanlandı.");
            }*/
            
            try{
                    //int a = int.Parse[null);
                    //int a = int.Parse("test"):
                   int a = int.Parse("-280020802ea");
                    }
                    catch (ArgumentNullException ex){
                    Console.WriteLine("Bos deger girdiniz");
                    Console.WriteLine(ex);
                    }
                    catch (FormatException ex){

                    Console.WriteLine("Veri tipi uygun degil.");
                    Console.WriteLine(ex);
                    }
                    catch (OverflowException ex){
                    Console.WriteLine("Cok kucuk yada cok buyuk bir deger girdiniz.");
                    Console.WriteLine(ex);
                    }
                    finally{
                        Console.WriteLine("işlem başarıyla tamamlanmıştır");
                    }


        }
    }
}
