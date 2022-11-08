
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
 * Clase Usuario_R:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class Usuario_RCAD : BasicCAD, IUsuario_RCAD
{
public Usuario_RCAD() : base ()
{
}

public Usuario_RCAD(ISession sessionAux) : base (sessionAux)
{
}



public Usuario_REN ReadOIDDefault (string email
                                   )
{
        Usuario_REN usuario_REN = null;

        try
        {
                SessionInitializeTransaction ();
                usuario_REN = (Usuario_REN)session.Get (typeof(Usuario_REN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario_REN;
}

public System.Collections.Generic.IList<Usuario_REN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Usuario_REN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Usuario_REN)).
                                         SetFirstResult (first).SetMaxResults (size).List<Usuario_REN>();
                        else
                                result = session.CreateCriteria (typeof(Usuario_REN)).List<Usuario_REN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Usuario_REN usuario_R)
{
        try
        {
                SessionInitializeTransaction ();
                Usuario_REN usuario_REN = (Usuario_REN)session.Load (typeof(Usuario_REN), usuario_R.Email);

                usuario_REN.Nombre = usuario_R.Nombre;


                usuario_REN.Apellidos = usuario_R.Apellidos;


                usuario_REN.Psw = usuario_R.Psw;


                usuario_REN.Telefono = usuario_R.Telefono;


                session.Update (usuario_REN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (Usuario_REN usuario_R)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario_R);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario_R.Email;
}

public void Modify (Usuario_REN usuario_R)
{
        try
        {
                SessionInitializeTransaction ();
                Usuario_REN usuario_REN = (Usuario_REN)session.Load (typeof(Usuario_REN), usuario_R.Email);

                usuario_REN.Direccion = usuario_R.Direccion;


                usuario_REN.Tarjeta = usuario_R.Tarjeta;


                usuario_REN.Nombre = usuario_R.Nombre;


                usuario_REN.Apellidos = usuario_R.Apellidos;


                usuario_REN.Psw = usuario_R.Psw;


                usuario_REN.Telefono = usuario_R.Telefono;

                session.Update (usuario_REN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
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
                Usuario_REN usuario_REN = (Usuario_REN)session.Load (typeof(Usuario_REN), email);
                session.Delete (usuario_REN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: Usuario_REN
public Usuario_REN ReadOID (string email
                            )
{
        Usuario_REN usuario_REN = null;

        try
        {
                SessionInitializeTransaction ();
                usuario_REN = (Usuario_REN)session.Get (typeof(Usuario_REN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario_REN;
}

public System.Collections.Generic.IList<Usuario_REN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Usuario_REN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(Usuario_REN)).
                                 SetFirstResult (first).SetMaxResults (size).List<Usuario_REN>();
                else
                        result = session.CreateCriteria (typeof(Usuario_REN)).List<Usuario_REN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in Usuario_RCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
