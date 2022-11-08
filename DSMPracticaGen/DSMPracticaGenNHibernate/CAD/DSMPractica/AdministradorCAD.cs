
using System;
using System.Text;
using DSMPracticaGenNHibernate.CEN.DSMPractica;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.Exceptions;


/*
 * Clase Administrador:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class AdministradorCAD : BasicCAD, IAdministradorCAD
{
public AdministradorCAD() : base ()
{
}

public AdministradorCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdministradorEN ReadOIDDefault (string nombre
                                       )
{
        AdministradorEN administradorEN = null;

        try
        {
                SessionInitializeTransaction ();
                administradorEN = (AdministradorEN)session.Get (typeof(AdministradorEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administradorEN;
}

public System.Collections.Generic.IList<AdministradorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AdministradorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdministradorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdministradorEN>();
                        else
                                result = session.CreateCriteria (typeof(AdministradorEN)).List<AdministradorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AdministradorEN administrador)
{
        try
        {
                SessionInitializeTransaction ();
                AdministradorEN administradorEN = (AdministradorEN)session.Load (typeof(AdministradorEN), administrador.Nombre);

                administradorEN.Pass = administrador.Pass;

                session.Update (administradorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (AdministradorEN administrador)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (administrador);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administrador.Nombre;
}

public void Modify (AdministradorEN administrador)
{
        try
        {
                SessionInitializeTransaction ();
                AdministradorEN administradorEN = (AdministradorEN)session.Load (typeof(AdministradorEN), administrador.Nombre);
                session.Update (administradorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string nombre
                     )
{
        try
        {
                SessionInitializeTransaction ();
                AdministradorEN administradorEN = (AdministradorEN)session.Load (typeof(AdministradorEN), nombre);
                session.Delete (administradorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AdministradorEN
public AdministradorEN ReadOID (string nombre
                                )
{
        AdministradorEN administradorEN = null;

        try
        {
                SessionInitializeTransaction ();
                administradorEN = (AdministradorEN)session.Get (typeof(AdministradorEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administradorEN;
}

public System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministradorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdministradorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdministradorEN>();
                else
                        result = session.CreateCriteria (typeof(AdministradorEN)).List<AdministradorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in AdministradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
