using DesafioPOO.Models;


Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero : "123654477", modelo: "Modelo1", imei :"1122552236", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero : "789456123", modelo: "Modelo20", imei :"112252225", memoria: 32);
nokia.Ligar();

nokia.InstalarAplicativo("Twitter");
