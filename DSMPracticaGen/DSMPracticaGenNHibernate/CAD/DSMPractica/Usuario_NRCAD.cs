
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
 * Clase Usuario_NR:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class Usuario_NRCAD : BasicCAD, IUsuario_NRCAD
{
public Usuario_NRCAD() : base ()
{
}

public Usuario_NRCAD(ISession sessionAux) : base (sessionAux)
{
}



public Usuario_NREN ReadOIDDefault (string email
                                    )
{
        Usuario_NREN usuario_NREN = null;

        try
        {
                SessionInitializeTransaction ();
                usuario_NREN = (Usuario_NREN)session.Get (typeof(Usuario_NREN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario_NREN;
}

public System.Collections.Generic.IList<Usuario_NREN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Usuario_NREN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Usuario_NREN)).
                                         SetFirstResult (first).SetMaxResults (size).List<Usuario_NREN>();
                        else
                                result = session.CreateCriteria (typeof(Usuario_NREN)).List<Usuario_NREN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Usuario_NREN usuario_NR)
{
        try
        {
                SessionInitializeTransaction ();
                Usuario_NREN usuario_NREN = (Usuario_NREN)session.Load (typeof(Usuario_NREN), usuario_NR.Email);

                usuario_NREN.Direccion = usuario_NR.Direccion;


                usuario_NREN.Tarjeta = usuario_NR.Tarjeta;



                session.Update (usuario_NREN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (Usuario_NREN usuario_NR)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario_NR);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario_NR.Email;
}

public void Modify (Usuario_NREN usuario_NR)
{
        try
        {
                SessionInitializeTransaction ();
                Usuario_NREN usuario_NREN = (Usuario_NREN)session.Load (typeof(Usuario_NREN), usuario_NR.Email);

                usuario_NREN.Direccion = usuario_NR.Direccion;


                usuario_NREN.Tarjeta = usuario_NR.Tarjeta;

                session.Update (usuario_NREN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string email
                     )
{
        try
        {
                SessionInitializeTransaction ();
                Usuario_NREN usuario_NREN = (Usuario_NREN)session.Load (typeof(Usuario_NREN), email);
                session.Delete (usuario_NREN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: Usuario_NREN
public Usuario_NREN ReadOID (string email
                             )
{
        Usuario_NREN usuario_NREN = null;

        try
        {
                SessionInitializeTransaction ();
                usuario_NREN = (Usuario_NREN)session.Get (typeof(Usuario_NREN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario_NREN;
}

public System.Collections.Generic.IList<Usuario_NREN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Usuario_NREN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(Usuario_NREN)).
                                 SetFirstResult (first).SetMaxResults (size).List<Usuario_NREN>();
                else
                        result = session.CreateCriteria (typeof(Usuario_NREN)).List<Usuario_NREN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_NRCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
