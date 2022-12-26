using DesafioPOO.Models;


Smartphone iphone  = new Iphone("99286-5576", "5s", "15558996", 128);
Smartphone nokia = new Nokia("98183-7633", "5g", "4489965", 256);
// REALIZADO
Console.WriteLine("Iphone");

iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine("-=-=-=-=-=-=-=-=");


Console.WriteLine("Nokia");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
Console.WriteLine("-=-=-=-=-=-=-=-");

