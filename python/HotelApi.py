class HotelApi():
    
    def __init__(self,fe,fs,o,d):
        self.fecha_entrada = fe
        self.fecha_salida = fs
        self.origen = o
        self.destino = d
    
    def buscarHotel(self):
        print("===========================")
        print("HOTELES ENCONTRADOS")
        print("Entrada :"+self.fecha_entrada+" salida : "+self.fecha_salida)
        print("Hotel ASKAT")
        print("Hotel ROTHKY")
        print("Hotel MIRRAN XOR")
        print("=========================")