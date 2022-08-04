// See https://aka.ms/new-console-template for more information
Console.WriteLine("** CONTROL DE VENTAS DE PRODUCTOS ** ");
Console.WriteLine(" ");

double precio, cantidad;

Console.WriteLine("Digite el precio de la compra");
 precio = double.Parse(Console.ReadLine());

Console.WriteLine("Digite la cantidad a comprar");
cantidad = double.Parse(Console.ReadLine());

double importe = cantidad * precio;
double descuento = (importe * 11) / 100;
double total = importe - descuento;

Console.WriteLine("-------------------------------------");
Console.WriteLine("El importe de la compra es: " + importe.ToString("0.00"));
Console.WriteLine("El descuento total de la compra es: " + descuento.ToString("0.00"));
Console.WriteLine("El total es: "+total.ToString("0.00"));
