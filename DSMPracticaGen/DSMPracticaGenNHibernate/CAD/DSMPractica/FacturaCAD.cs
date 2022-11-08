
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
 * Clase Factura:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class FacturaCAD : BasicCAD, IFacturaCAD
{
public FacturaCAD() : base ()
{
}

public FacturaCAD(ISession sessionAux) : base (sessionAux)
{
}



public FacturaEN ReadOIDDefault (int id
                                 )
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FacturaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                        else
                                result = session.CreateCriteria (typeof(FacturaEN)).List<FacturaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), factura.Id);

                facturaEN.Fecha = factura.Fecha;


                facturaEN.EsPagada = factura.EsPagada;


                facturaEN.EsAnulada = factura.EsAnulada;


                facturaEN.Total = factura.Total;


                session.Update (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                if (factura.Pedido != null) {
                        // Argumento OID y no colección.
                        factura.Pedido = (DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN)session.Load (typeof(DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN), factura.Pedido.Id);

                        factura.Pedido.Factura
                                = factura;
                }

                session.Save (factura);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return factura.Id;
}

public void Modify (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), factura.Id);

                facturaEN.Fecha = factura.Fecha;


                facturaEN.EsPagada = factura.EsPagada;


                facturaEN.EsAnulada = factura.EsAnulada;


                facturaEN.Total = factura.Total;

                session.Update (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), id);
                session.Delete (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: FacturaEN
public FacturaEN ReadOID (int id
                          )
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(FacturaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                else
                        result = session.CreateCriteria (typeof(FacturaEN)).List<FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
