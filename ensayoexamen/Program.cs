
Console.WriteLine(" Sistema de librerias");


var lista_Librerias = new List<Librerias>();
lista_Librerias.Add(new Librerias() 
{ 
    Id = 1, 
    Nombre = "Librería Nacional", 
    Direccion = "Calle 50 #25-30",
    fecha = DateTime.Now 
});
lista_Librerias.Add(new Librerias() 
{ 
    Id = 2, 
    Nombre = "Panamericana", 
    Direccion = "Carrera 70 #45-10",
    fecha = DateTime.Now 
});


var lista_Libros = new List <Libros> () ;

   lista_Libros.Add ( new Libros() { 
     Id=1,
     Nombre = "alas de onix",
     Nhojas =500 , Precio = 100.00m, Id_Libreria = 1} );

   lista_Libros.Add ( new Libros (){ 
     Id=2, 
     Nombre = " el señor de los anillos ",
     Nhojas = 600 , 
     Precio = 150.00m, Id_Libreria = 2} );
   lista_Libros.Add ( new Libros() {
      Id=3,
      Nombre = "  pedro el escamoso ",
      Nhojas =500 , 
      Precio = 100.00m} );
   
   var lista_Ventas = new List <Ventas> ();
   lista_Ventas.Add ( new Ventas () {Id = 1 , ID_Libro = 1, Cantidad = 2  });
   lista_Ventas.Add ( new Ventas () {Id = 2 , ID_Libro = 2, Cantidad = 1  });
   lista_Ventas.Add ( new Ventas () {Id = 3 , ID_Libro = 1, Cantidad = 3  });


Console.WriteLine("Librerias  activas");
foreach ( var libreria in lista_Librerias )
{
    Console.WriteLine($"Libreria: {libreria.Nombre}, Direccion: {libreria.Direccion} , Fecha : { libreria.fecha } ");
}
Console.WriteLine("Libros activos");
foreach (var libro in lista_Libros.Where(x => x.Id_Libreria > 0))
{
    Console.WriteLine($"Libro: {libro.Nombre}, Precio: ${libro.Precio}");
}



public class Ventas
{
    public int Id {get ; set;}
    public int ID_Libro {get ; set ;}
    public int Cantidad {get ; set ;}
    public Decimal Total { get ; set;} = 0.0m;
    public Libros?_libro { get ;set;}

    
    


}
public class Libros {

public int Id {get ;set;}
public String? Nombre {get ;set;}
public int Nhojas {get ;set;}
public Decimal Precio {get ;set;} = 0.0m  ;
public int Id_Libreria {get;set;}
public Librerias? Libreria {get ;set;}


}


public class Librerias {
 public int Id  {get ; set}
 public String? Nombre {get ;set;}
 public String? Direccion {get;set;}
 public DateTime fecha { get ;set ;}
 public List <Libros>? Libros {get ;set;}
 
}
