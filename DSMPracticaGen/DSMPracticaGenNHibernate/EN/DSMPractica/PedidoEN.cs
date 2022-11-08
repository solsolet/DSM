
using System;
// Definición clase PedidoEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo direntrega
 */
private string direntrega;



/**
 *	Atributo horamaxima
 */
private Nullable<DateTime> horamaxima;



/**
 *	Atributo cliente
 */
private string cliente;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo usuario
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN usuario;



/**
 *	Atributo estado
 */
private DSMPracticaGenNHibernate.Enumerated.DSMPractica.EstadoPedidoEnum estado;



/**
 *	Atributo linped
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> linped;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo factura
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.FacturaEN factura;



/**
 *	Atributo valoracion
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN valoracion;



/**
 *	Atributo notificacion
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> notificacion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Direntrega {
        get { return direntrega; } set { direntrega = value;  }
}



public virtual Nullable<DateTime> Horamaxima {
        get { return horamaxima; } set { horamaxima = value;  }
}



public virtual string Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual DSMPracticaGenNHibernate.Enumerated.DSMPractica.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> Linped {
        get { return linped; } set { linped = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}





public PedidoEN()
{
        linped = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN>();
        notificacion = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN>();
}



public PedidoEN(int id, string direntrega, Nullable<DateTime> horamaxima, string cliente, float precio, DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN usuario, DSMPracticaGenNHibernate.Enumerated.DSMPractica.EstadoPedidoEnum estado, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> linped, Nullable<DateTime> fecha, DSMPracticaGenNHibernate.EN.DSMPractica.FacturaEN factura, DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN valoracion, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> notificacion
                )
{
        this.init (Id, direntrega, horamaxima, cliente, precio, usuario, estado, linped, fecha, factura, valoracion, notificacion);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (Id, pedido.Direntrega, pedido.Horamaxima, pedido.Cliente, pedido.Precio, pedido.Usuario, pedido.Estado, pedido.Linped, pedido.Fecha, pedido.Factura, pedido.Valoracion, pedido.Notificacion);
}

private void init (int id
                   , string direntrega, Nullable<DateTime> horamaxima, string cliente, float precio, DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN usuario, DSMPracticaGenNHibernate.Enumerated.DSMPractica.EstadoPedidoEnum estado, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.LinPedEN> linped, Nullable<DateTime> fecha, DSMPracticaGenNHibernate.EN.DSMPractica.FacturaEN factura, DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN valoracion, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.NotificacionEN> notificacion)
{
        this.Id = id;


        this.Direntrega = direntrega;

        this.Horamaxima = horamaxima;

        this.Cliente = cliente;

        this.Precio = precio;

        this.Usuario = usuario;

        this.Estado = estado;

        this.Linped = linped;

        this.Fecha = fecha;

        this.Factura = factura;

        this.Valoracion = valoracion;

        this.Notificacion = notificacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
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
