
using System;
// Definición clase UsuarioEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class UsuarioEN
{
/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo tarjeta
 */
private long tarjeta;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo telefono
 */
private int telefono;



/**
 *	Atributo puntos
 */
private int puntos;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion;






public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual long Tarjeta {
        get { return tarjeta; } set { tarjeta = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual int Puntos {
        get { return puntos; } set { puntos = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}





public UsuarioEN()
{
        pedido = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN>();
        valoracion = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN>();
}



public UsuarioEN(int id, string direccion, long tarjeta, string nombre, string apellidos, int telefono, int puntos, String pass, string email, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion
                 )
{
        this.init (Id, direccion, tarjeta, nombre, apellidos, telefono, puntos, pass, email, pedido, valoracion);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Id, usuario.Direccion, usuario.Tarjeta, usuario.Nombre, usuario.Apellidos, usuario.Telefono, usuario.Puntos, usuario.Pass, usuario.Email, usuario.Pedido, usuario.Valoracion);
}

private void init (int id
                   , string direccion, long tarjeta, string nombre, string apellidos, int telefono, int puntos, String pass, string email, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion)
{
        this.Id = id;


        this.Direccion = direccion;

        this.Tarjeta = tarjeta;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Telefono = telefono;

        this.Puntos = puntos;

        this.Pass = pass;

        this.Email = email;

        this.Pedido = pedido;

        this.Valoracion = valoracion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
