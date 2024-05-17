using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testes com Nokia
            Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: 512);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            // Testes com iPhone
            Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "987654321098765", memoria: 256);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Facebook");
        }
    }
}