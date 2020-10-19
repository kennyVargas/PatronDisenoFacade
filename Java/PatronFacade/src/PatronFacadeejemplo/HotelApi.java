package PatronFacadeejemplo;

public class HotelApi {
	private String fecha_entrada;
	private String fecha_salida;
	private String origen;
	private String destino;

	public HotelApi(String fe,String fs,String o,String d) {
		this.fecha_entrada=fe;
		this.fecha_salida=fs;
		this.origen=o;
		this.destino=d;
		
	}
	public void buscarHoteles() {
		System.out.println("============================");
		System.out.println("HOTELES ENCONTRADOS");
		System.out.println("Entrada :"+this.fecha_entrada+" salida : "+this.fecha_salida );
		System.out.println("Hotel ASKAT");
		System.out.println("Hotel ROTHKY");
		System.out.println("Hotel MIRRAN XOR");
		System.out.println("============================");
	}

}
