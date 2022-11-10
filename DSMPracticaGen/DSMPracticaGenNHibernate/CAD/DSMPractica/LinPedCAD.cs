
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
 * Clase LinPed:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class LinPedCAD : BasicCAD, ILinPedCAD
{
public LinPedCAD() : base ()
{
}

public LinPedCAD(ISession sessionAux) : base (sessionAux)
{
}



public LinPedEN ReadOIDDefault (int linea
                                )
{
        LinPedEN linPedEN = null;

        try
        {
                SessionInitializeTransaction ();
                linPedEN = (LinPedEN)session.Get (typeof(LinPedEN), linea);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return linPedEN;
}

public System.Collections.Generic.IList<LinPedEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LinPedEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LinPedEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LinPedEN>();
                        else
                                result = session.CreateCriteria (typeof(LinPedEN)).List<LinPedEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LinPedEN linPed)
{
        try
        {
                SessionInitializeTransaction ();
                LinPedEN linPedEN = (LinPedEN)session.Load (typeof(LinPedEN), linPed.Linea);



                linPedEN.Cantidad = linPed.Cantidad;


                linPedEN.Importe = linPed.Importe;

                session.Update (linPedEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LinPedEN linPed)
{
        try
        {
                SessionInitializeTransaction ();
                if (linPed.Producto != null) {
                        // Argumento OID y no colección.
                        linPed.Producto = (DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN)session.Load (typeof(DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN), linPed.Producto.Id);

                        linPed.Producto.Linped
                        .Add (linPed);
                }
                if (linPed.Pedido != null) {
                        // Argumento OID y no colección.
                        linPed.Pedido = (DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN)session.Load (typeof(DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN), linPed.Pedido.Id);

                        linPed.Pedido.Linped
                        .Add (linPed);
                }

                session.Save (linPed);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return linPed.Linea;
}

public void Modify (LinPedEN linPed)
{
        try
        {
                SessionInitializeTransaction ();
                LinPedEN linPedEN = (LinPedEN)session.Load (typeof(LinPedEN), linPed.Linea);

                linPedEN.Cantidad = linPed.Cantidad;


                linPedEN.Importe = linPed.Importe;

                session.Update (linPedEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int linea
                     )
{
        try
        {
                SessionInitializeTransaction ();
                LinPedEN linPedEN = (LinPedEN)session.Load (typeof(LinPedEN), linea);
                session.Delete (linPedEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: LinPedEN
public LinPedEN ReadOID (int linea
                         )
{
        LinPedEN linPedEN = null;

        try
        {
                SessionInitializeTransaction ();
                linPedEN = (LinPedEN)session.Get (typeof(LinPedEN), linea);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return linPedEN;
}

public System.Collections.Generic.IList<LinPedEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LinPedEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LinPedEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<LinPedEN>();
                else
                        result = session.CreateCriteria (typeof(LinPedEN)).List<LinPedEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in LinPedCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
