using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new(numero: "128955", modelo: "Iphone 17 Pro Max", imei: "000023899", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("==========");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new(numero: "128955", modelo: "Nokia modelo 00", imei: "000023899", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Navegador");