package PatronFacadeejemplo;

public class Facade {
	private AvionApi avion;
	private HotelApi hotel;
	public Facade(String fs,String fv,String o,String d) {
		avion = new AvionApi(fs, fv, o, d);
		hotel = new HotelApi(fs,fv,o,d);
		
	}
	
	public void buscar() {
		avion.buscarvuelos();
		hotel.buscarHoteles();
	}

}
