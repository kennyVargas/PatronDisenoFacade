from HotelApi import HotelApi
from AvionApi import AvionApi
class Facade():
    
    def __init__(self,fs,fv,o,d):
        self.hotel = HotelApi(fs, fv, o, d)
        self.avion=AvionApi(fs,fv,o,d)
        
    def buscar(self):
        self.avion.buscarVuelos()
        self.hotel.buscarHotel()
    
    
        
a=Facade("02/11/2020","03/01/2020","Uruguay","Caracas")
a.buscar()