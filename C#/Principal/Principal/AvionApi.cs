﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
     
    class AvionApi
    {
        private String fecha_ida;
        private String fecha_vuelta;
        private String origen;
        private String destino;
        public AvionApi(String fi,String fv,String o,String d)
        {
            this.fecha_ida = fi;
            this.fecha_vuelta = fv;
            this.origen = o;
            this.destino = d;
        }
        public void buscarvuelos()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("vuelos encontrados para: " + this.destino + " desde " + this.origen);
            Console.WriteLine("Fecha IDA :" + this.fecha_ida + " Fecha vuelta: " + this.fecha_vuelta);
            Console.WriteLine("vuelo: con fecha:" + this.fecha_ida);
            Console.WriteLine("vuelo 74931 con destino a :" + this.destino);
            Console.WriteLine("==============================================");

        }
    }
}
