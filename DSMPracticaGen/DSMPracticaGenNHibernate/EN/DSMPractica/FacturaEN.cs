
using System;
// Definición clase FacturaEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class FacturaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo esPagada
 */
private bool esPagada;



/**
 *	Atributo esAnulada
 */
private bool esAnulada;



/**
 *	Atributo total
 */
private float total;



/**
 *	Atributo pedido
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual bool EsPagada {
        get { return esPagada; } set { esPagada = value;  }
}



public virtual bool EsAnulada {
        get { return esAnulada; } set { esAnulada = value;  }
}



public virtual float Total {
        get { return total; } set { total = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public FacturaEN()
{
}



public FacturaEN(int id, Nullable<DateTime> fecha, bool esPagada, bool esAnulada, float total, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido
                 )
{
        this.init (Id, fecha, esPagada, esAnulada, total, pedido);
}


public FacturaEN(FacturaEN factura)
{
        this.init (Id, factura.Fecha, factura.EsPagada, factura.EsAnulada, factura.Total, factura.Pedido);
}

private void init (int id
                   , Nullable<DateTime> fecha, bool esPagada, bool esAnulada, float total, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido)
{
        this.Id = id;


        this.Fecha = fecha;

        this.EsPagada = esPagada;

        this.EsAnulada = esAnulada;

        this.Total = total;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
