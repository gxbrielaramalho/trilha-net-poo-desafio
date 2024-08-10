using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("123456789", "iPhone 13", "ABC123", 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");

        Smartphone nokia = new Nokia("987654321", "Nokia 3310", "DEF456", 16);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}
