package PatronFacadeejemplo;

public class AvionApi {
	private String fecha_ida;
	private String fecha_vuelta;
	private String origen;
	private String destino;

	public AvionApi(String fi,String fv,String o,String d) {
		this.fecha_ida=fi;
		this.fecha_vuelta=fv;
		this.origen=o;
		this.destino=d;
	}
	public void buscarvuelos() {
		System.out.println("==========================================");
		System.out.println("vuelos encontrados para: "+this.destino+" desde "+this.origen);
		System.out.println("Fecha IDA :" +this.fecha_ida+" Fecha vuelta: "+this.fecha_vuelta );
		System.out.println("vuelo: con fecha:"+this.fecha_ida);
		System.out.println("vuelo 74931 con destino a :" +this.destino);
		System.out.println("==============================================");
	}

}
