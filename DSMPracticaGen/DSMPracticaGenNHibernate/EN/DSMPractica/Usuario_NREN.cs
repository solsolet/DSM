
using System;
// Definición clase Usuario_NREN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class Usuario_NREN
{
/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo tarjeta
 */
private int tarjeta;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual int Tarjeta {
        get { return tarjeta; } set { tarjeta = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}





public Usuario_NREN()
{
        pedido = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN>();
        valoracion = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN>();
}



public Usuario_NREN(string email, string direccion, int tarjeta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion
                    )
{
        this.init (Email, direccion, tarjeta, pedido, valoracion);
}


public Usuario_NREN(Usuario_NREN usuario_NR)
{
        this.init (Email, usuario_NR.Direccion, usuario_NR.Tarjeta, usuario_NR.Pedido, usuario_NR.Valoracion);
}

private void init (string email
                   , string direccion, int tarjeta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion)
{
        this.Email = email;


        this.Direccion = direccion;

        this.Tarjeta = tarjeta;

        this.Pedido = pedido;

        this.Valoracion = valoracion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Usuario_NREN t = obj as Usuario_NREN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
