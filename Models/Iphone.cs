using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone

    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Construtor
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Implemente se houver lógica adicional no construtor
        }

        // Método sobrescrito da classe abstrata
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na App Store...");
        }
    }
}