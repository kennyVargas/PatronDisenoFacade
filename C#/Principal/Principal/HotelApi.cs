using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    class HotelApi
    {
        private String fecha_entrada;
        private String fecha_salida;
        private String origen;
        private String destino;
        public HotelApi(String fe, String fs, String o, String d)
        {
            this.fecha_entrada = fe;
            this.fecha_salida = fs;
            this.origen = o;
            this.destino = d;
        }
        public void buscarHoteles()
        {
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("HOTELES ENCONTRADOS");
            Console.WriteLine("Entrada :" + this.fecha_entrada + " salida : " + this.fecha_salida);
            Console.WriteLine("Hotel ASKAT");
            Console.WriteLine("Hotel ROTHKY");
            Console.WriteLine("Hotel MIRRAN XOR");
            Console.WriteLine("============================");
        }
    }
}
