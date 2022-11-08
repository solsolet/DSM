
using System;
// Definición clase OfertasEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class OfertasEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo carta
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> carta;



/**
 *	Atributo descuento
 */
private float descuento;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo puntos
 */
private int puntos;



/**
 *	Atributo vigencia
 */
private bool vigencia;



/**
 *	Atributo notificacion
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> notificacion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> Carta {
        get { return carta; } set { carta = value;  }
}



public virtual float Descuento {
        get { return descuento; } set { descuento = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual int Puntos {
        get { return puntos; } set { puntos = value;  }
}



public virtual bool Vigencia {
        get { return vigencia; } set { vigencia = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}





public OfertasEN()
{
        carta = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN>();
        notificacion = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN>();
}



public OfertasEN(int id, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> carta, float descuento, float precio, int puntos, bool vigencia, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> notificacion
                 )
{
        this.init (Id, carta, descuento, precio, puntos, vigencia, notificacion);
}


public OfertasEN(OfertasEN ofertas)
{
        this.init (Id, ofertas.Carta, ofertas.Descuento, ofertas.Precio, ofertas.Puntos, ofertas.Vigencia, ofertas.Notificacion);
}

private void init (int id
                   , System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN> carta, float descuento, float precio, int puntos, bool vigencia, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> notificacion)
{
        this.Id = id;


        this.Carta = carta;

        this.Descuento = descuento;

        this.Precio = precio;

        this.Puntos = puntos;

        this.Vigencia = vigencia;

        this.Notificacion = notificacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        OfertasEN t = obj as OfertasEN;
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
