
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






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}





public AdministradorEN()
{
}



public AdministradorEN(string nombre, String pass
                       )
{
        this.init (Nombre, pass);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Nombre, administrador.Pass);
}

private void init (string nombre
                   , String pass)
{
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
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
