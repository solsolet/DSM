
using System;
// Definición clase CartaEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class CartaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> producto;



/**
 *	Atributo tipo
 */
private DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum tipo;



/**
 *	Atributo ofertas
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN> ofertas;



/**
 *	Atributo linkterminos
 */
private string linkterminos;



/**
 *	Atributo linkcarta
 */
private string linkcarta;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}



public virtual DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN> Ofertas {
        get { return ofertas; } set { ofertas = value;  }
}



public virtual string Linkterminos {
        get { return linkterminos; } set { linkterminos = value;  }
}



public virtual string Linkcarta {
        get { return linkcarta; } set { linkcarta = value;  }
}





public CartaEN()
{
        producto = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN>();
        ofertas = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN>();
}



public CartaEN(int id, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> producto, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum tipo, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN> ofertas, string linkterminos, string linkcarta
               )
{
        this.init (Id, producto, tipo, ofertas, linkterminos, linkcarta);
}


public CartaEN(CartaEN carta)
{
        this.init (Id, carta.Producto, carta.Tipo, carta.Ofertas, carta.Linkterminos, carta.Linkcarta);
}

private void init (int id
                   , System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> producto, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum tipo, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN> ofertas, string linkterminos, string linkcarta)
{
        this.Id = id;


        this.Producto = producto;

        this.Tipo = tipo;

        this.Ofertas = ofertas;

        this.Linkterminos = linkterminos;

        this.Linkcarta = linkcarta;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CartaEN t = obj as CartaEN;
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
