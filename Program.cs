using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia("999999999", "Galaxy S22 Ultra", "123456789", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Dio Voice");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
var Iphone = new Iphone("888888888", "Galaxy S20 FE ", "987654321", 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Dio VideoChamada");