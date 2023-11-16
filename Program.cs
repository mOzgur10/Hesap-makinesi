namespace switchcasehesapmakodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayiyi giriniz: ");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayiyi giriniz: ");
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlemi seçiniz\nToplama (+) \nÇıkarma (-) \nÇarpma (*) \nBölme (/)");
            char islem = Convert.ToChar(Console.ReadLine());
            switch (islem)
            {
                case '+':
                    Console.WriteLine("İslemin sonucu = " + (sayi1 + sayi2));
                    break;
                case '-':
                    Console.WriteLine("İslemin sonucu = " + (sayi1 - sayi2));
                    break;
                case '*':
                    Console.WriteLine("İslemin sonucu = " + (sayi1 * sayi2));
                    break;
                case '/':
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("0'a bölme işlemi yapılamaz!!");
                    }
                    else
                    {
                        Console.WriteLine("İslemin sonucu = " + (sayi1 / sayi2));
                    }
                    break;
                default:
                    Console.WriteLine("Yanlis secim!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
