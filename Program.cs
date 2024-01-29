using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone Ip1 = new Iphone("14353415", "iphone15 pro max", "111111111111", 32);
Smartphone Ip2 = new Iphone("14874345", "iphone13", "22222222222", 64);

Smartphone No1 = new Nokia("01377510", "Nokia chi", "3333333333", 128);
Smartphone No2 = new Nokia("43257043", "Nokia 4", "4444444444", 64);

Console.WriteLine("-----------------------------------");

Console.WriteLine("Iphone 1:");
Ip1.Ligar();
Ip1.ReceberLigacao();
Ip1.InstalarAplicativo("Telegram");

Console.WriteLine("-----------------------------------");

Console.WriteLine("\nIphone 2");
Ip2.InstalarAplicativo("Whatsapp");

Console.WriteLine("-----------------------------------");

Console.WriteLine("\nNokia 1:");
No1.ReceberLigacao();
No1.Ligar();
No1.InstalarAplicativo("Fing");

Console.WriteLine("-----------------------------------");

Console.WriteLine("\nNokia 2:");
No2.ReceberLigacao();
No2.InstalarAplicativo("Ovo");
No2.Ligar();
Console.WriteLine("-----------------------------------");