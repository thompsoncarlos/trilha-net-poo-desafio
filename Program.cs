using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "111111", modelo: "Nokia Mod 1", imei: "1111111-1", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("LinkedIn");

Console.WriteLine("-------------------------------");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "222222", modelo: "Iphone Mod 1", imei: "222222-2", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Reddit");