using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("4899998877", "NK54", "AB152DE", 64);

Iphone iphone = new Iphone("4899998888", "IP15", "JJ122FF", 256);

Console.WriteLine("Smartphone Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

Console.ReadKey();
