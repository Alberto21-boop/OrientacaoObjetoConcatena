using System;

namespace app11
{
    internal class Carros
    {
        public string carro1 { get; set; } = default!;
        public string carro2 { get; set; } = default!;  

        public string DoisCarros()
        {
            return carro1 + carro2;
        }
    }
}