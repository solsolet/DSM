
using System;
// Definición clase ValoracionEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class ValoracionEN
{
/**
 *	Atributo puntuacion
 */
private int puntuacion;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo usuario
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN usuario;



/**
 *	Atributo pedido
 */
private DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido;



/**
 *	Atributo id
 */
private int id;






public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int id, int puntuacion, string descripcion, DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN usuario, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido
                    )
{
        this.init (Id, puntuacion, descripcion, usuario, pedido);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Puntuacion, valoracion.Descripcion, valoracion.Usuario, valoracion.Pedido);
}

private void init (int id
                   , int puntuacion, string descripcion, DSMPracticaGenNHibernate.EN.DSMPractica.UsuarioEN usuario, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido)
{
        this.Id = id;


        this.Puntuacion = puntuacion;

        this.Descripcion = descripcion;

        this.Usuario = usuario;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
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
