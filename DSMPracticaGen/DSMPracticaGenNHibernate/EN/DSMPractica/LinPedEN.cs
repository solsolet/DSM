
using System;
// Definición clase LinPedEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class LinPedEN
{
/**
 *	Atributo linea
 */
private int linea;



/**
 *	Atributo producto
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN producto;



/**
 *	Atributo pedido
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo importe
 */
private float importe;






public virtual int Linea {
        get { return linea; } set { linea = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual float Importe {
        get { return importe; } set { importe = value;  }
}





public LinPedEN()
{
}



public LinPedEN(int linea, DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN producto, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido, int cantidad, float importe
                )
{
        this.init (Linea, producto, pedido, cantidad, importe);
}


public LinPedEN(LinPedEN linPed)
{
        this.init (Linea, linPed.Producto, linPed.Pedido, linPed.Cantidad, linPed.Importe);
}

private void init (int linea
                   , DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN producto, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido, int cantidad, float importe)
{
        this.Linea = linea;


        this.Producto = producto;

        this.Pedido = pedido;

        this.Cantidad = cantidad;

        this.Importe = importe;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LinPedEN t = obj as LinPedEN;
        if (t == null)
                return false;
        if (Linea.Equals (t.Linea))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Linea.GetHashCode ();
        return hash;
}
}
}
