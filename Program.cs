using System;


namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            //y = y+ 2;
            y += 2;
            Console.WriteLine(y);
            x += 2; 
            y /= 1;
           Console.WriteLine(y);
           Console.WriteLine(x);


           //Mantiksal Operatorler

           bool isSuccess = true;
           bool isCompleted = false;

           if(isSuccess && isSuccess){
               Console.WriteLine("perfect");
           }
            if(isSuccess || isCompleted ){
               Console.WriteLine("Good");
            }
            if(isCompleted || !(isSuccess)){
                Console.WriteLine("Fine");
            }
            //Iliskisel Operatorler

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmetik
            int sayi1 = 10;
            int sayi2 = 20;

            int sonuc1 = sayi2 /sayi1;
            Console.WriteLine(sonuc1);

            int sonuc2  = sayi2 % sayi1;
            Console.WriteLine(sonuc2);

            int sonuc3 = sayi1 + sayi2;
            Console.WriteLine(sonuc3);

            

        }
    }
}