
Console.WriteLine("Hello, World!");

public class Libros {

public int Id {get ;set;}
public String? Nombre {get ;set;}
public int Nhojas {get ;set;}
public Decimal Precio {get ;set;} = 0.0m  ;

}


public class Librerias {
 public int Id ;
 public String? Nombre {get ;set;}
 public String? Direccion {get;set;}
 public DateTime fecha { get ;set ;}
 public List <Libros>? Libros {get ;set;}
 
}
