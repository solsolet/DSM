
using System;
// Definición clase ProductoEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class ProductoEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo categoria
 */
private DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum categoria;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo carta
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> carta;



/**
 *	Atributo ingrediente
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> ingrediente;



/**
 *	Atributo foto
 */
private string foto;



/**
 *	Atributo linped
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> linped;



/**
 *	Atributo novedad
 */
private bool novedad;



/**
 *	Atributo id
 */
private int id;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> Carta {
        get { return carta; } set { carta = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> Ingrediente {
        get { return ingrediente; } set { ingrediente = value;  }
}



public virtual string Foto {
        get { return foto; } set { foto = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> Linped {
        get { return linped; } set { linped = value;  }
}



public virtual bool Novedad {
        get { return novedad; } set { novedad = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public ProductoEN()
{
        carta = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN>();
        ingrediente = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN>();
        linped = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN>();
}



public ProductoEN(int id, string nombre, string descripcion, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum categoria, float precio, int cantidad, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> carta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> ingrediente, string foto, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> linped, bool novedad
                  )
{
        this.init (Id, nombre, descripcion, categoria, precio, cantidad, carta, ingrediente, foto, linped, novedad);
}


public ProductoEN(ProductoEN producto)
{
        this.init (Id, producto.Nombre, producto.Descripcion, producto.Categoria, producto.Precio, producto.Cantidad, producto.Carta, producto.Ingrediente, producto.Foto, producto.Linped, producto.Novedad);
}

private void init (int id
                   , string nombre, string descripcion, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum categoria, float precio, int cantidad, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> carta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> ingrediente, string foto, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> linped, bool novedad)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Categoria = categoria;

        this.Precio = precio;

        this.Cantidad = cantidad;

        this.Carta = carta;

        this.Ingrediente = ingrediente;

        this.Foto = foto;

        this.Linped = linped;

        this.Novedad = novedad;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
