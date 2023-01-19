using DesafioPOO.Models;

Nokia Nokia = new Nokia("+5519998169477", "6130", "1111111", 5);
Iphone Iphone = new Iphone("+5519998169477", "5c", "222222", 16);

Nokia.Ligar();
Nokia.InstalarAplicativo("Youtube");
Nokia.ReceberLigacao();

Console.WriteLine("---------------------");
Iphone.Ligar();
Iphone.InstalarAplicativo("Itunes");
Iphone.ReceberLigacao();