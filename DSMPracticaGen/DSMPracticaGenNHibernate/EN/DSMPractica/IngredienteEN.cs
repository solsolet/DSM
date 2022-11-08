
using System;
// Definición clase IngredienteEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class IngredienteEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> producto;



/**
 *	Atributo tipo
 */
private DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum tipo;



/**
 *	Atributo stock
 */
private int stock;



/**
 *	Atributo alergeno
 */
private string alergeno;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}



public virtual DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}



public virtual string Alergeno {
        get { return alergeno; } set { alergeno = value;  }
}





public IngredienteEN()
{
        producto = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN>();
}



public IngredienteEN(string nombre, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> producto, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum tipo, int stock, string alergeno
                     )
{
        this.init (Nombre, producto, tipo, stock, alergeno);
}


public IngredienteEN(IngredienteEN ingrediente)
{
        this.init (Nombre, ingrediente.Producto, ingrediente.Tipo, ingrediente.Stock, ingrediente.Alergeno);
}

private void init (string nombre
                   , System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> producto, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum tipo, int stock, string alergeno)
{
        this.Nombre = nombre;


        this.Producto = producto;

        this.Tipo = tipo;

        this.Stock = stock;

        this.Alergeno = alergeno;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IngredienteEN t = obj as IngredienteEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
