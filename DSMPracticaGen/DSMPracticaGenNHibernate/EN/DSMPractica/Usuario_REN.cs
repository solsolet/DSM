
using System;
// Definición clase Usuario_REN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class Usuario_REN                                                                    : DSMPracticaGenNHibernate.EN.DSMPractica.Usuario_NREN


{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo psw
 */
private String psw;



/**
 *	Atributo telefono
 */
private int telefono;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual String Psw {
        get { return psw; } set { psw = value;  }
}



public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}





public Usuario_REN() : base ()
{
}



public Usuario_REN(string email, string nombre, string apellidos, String psw, int telefono
                   , string direccion, int tarjeta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion
                   )
{
        this.init (Email, nombre, apellidos, psw, telefono, direccion, tarjeta, pedido, valoracion);
}


public Usuario_REN(Usuario_REN usuario_R)
{
        this.init (Email, usuario_R.Nombre, usuario_R.Apellidos, usuario_R.Psw, usuario_R.Telefono, usuario_R.Direccion, usuario_R.Tarjeta, usuario_R.Pedido, usuario_R.Valoracion);
}

private void init (string email
                   , string nombre, string apellidos, String psw, int telefono, string direccion, int tarjeta, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN> pedido, System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ValoracionEN> valoracion)
{
        this.Email = email;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Psw = psw;

        this.Telefono = telefono;

        this.Direccion = direccion;

        this.Tarjeta = tarjeta;

        this.Pedido = pedido;

        this.Valoracion = valoracion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Usuario_REN t = obj as Usuario_REN;
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
