from Facade import Facade
class Main():
    
    cliente=Facade("02/11/2020","03/01/2020","Uruguay","Caracas")
    cliente.buscar()
    
    cliente2=Facade("02/08/2020","03/01/2021","Santigo","Puerto Valle")
    cliente2.buscar()