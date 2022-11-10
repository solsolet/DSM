
using System;
// Definición clase UsuarioEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class UsuarioEN
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
private long tarjeta;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion;



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
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo id
 */
private int id;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual long Tarjeta {
        get { return tarjeta; } set { tarjeta = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
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



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public UsuarioEN()
{
        pedido = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN>();
        valoracion = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN>();
}



public UsuarioEN(int id, string email, string direccion, long tarjeta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion, string nombre, string apellidos, int telefono, int puntos, String pass
                 )
{
        this.init (Id, email, direccion, tarjeta, pedido, valoracion, nombre, apellidos, telefono, puntos, pass);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Id, usuario.Email, usuario.Direccion, usuario.Tarjeta, usuario.Pedido, usuario.Valoracion, usuario.Nombre, usuario.Apellidos, usuario.Telefono, usuario.Puntos, usuario.Pass);
}

private void init (int id
                   , string email, string direccion, long tarjeta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion, string nombre, string apellidos, int telefono, int puntos, String pass)
{
        this.Id = id;


        this.Email = email;

        this.Direccion = direccion;

        this.Tarjeta = tarjeta;

        this.Pedido = pedido;

        this.Valoracion = valoracion;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Telefono = telefono;

        this.Puntos = puntos;

        this.Pass = pass;
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
