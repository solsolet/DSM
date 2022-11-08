
using System;
// Definición clase NotificacionEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class NotificacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido;



/**
 *	Atributo ofertas
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN ofertas;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN Ofertas {
        get { return ofertas; } set { ofertas = value;  }
}





public NotificacionEN()
{
        pedido = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN>();
}



public NotificacionEN(int id, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN ofertas
                      )
{
        this.init (Id, pedido, ofertas);
}


public NotificacionEN(NotificacionEN notificacion)
{
        this.init (Id, notificacion.Pedido, notificacion.Ofertas);
}

private void init (int id
                   , System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN ofertas)
{
        this.Id = id;


        this.Pedido = pedido;

        this.Ofertas = ofertas;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NotificacionEN t = obj as NotificacionEN;
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
