
using System;
// Definición clase AdministradorEN
namespace DSMPracticaGenNHibernate.EN.DSMPractica
{
public partial class AdministradorEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo id
 */
private int id;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public AdministradorEN()
{
}



public AdministradorEN(int id, string nombre, String pass
                       )
{
        this.init (Id, nombre, pass);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Id, administrador.Nombre, administrador.Pass);
}

private void init (int id
                   , string nombre, String pass)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Pass = pass;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
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
