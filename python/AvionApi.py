class AvionApi():
    
    def __init__(self,fi,fv,o,d):
        self.fecha_ida = fi
        self.fecha_vuelta=fv
        self.origen=o
        self.destino=d
        
    def buscarVuelos(self):
        print("==========================================")
        print("vuelos encontrados para: ",self.destino,"desde: ",self.origen)
        print("Fecha IDA :" ,self.fecha_ida," Fecha vuelta: ",self.fecha_vuelta)
        print("vuelo: con fecha:",self.fecha_ida)
        print("vuelo 74931 con destino a :" ,self.destino)

		
