
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
 * Clase Ofertas:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class OfertasCAD : BasicCAD, IOfertasCAD
{
public OfertasCAD() : base ()
{
}

public OfertasCAD(ISession sessionAux) : base (sessionAux)
{
}



public OfertasEN ReadOIDDefault (int id
                                 )
{
        OfertasEN ofertasEN = null;

        try
        {
                SessionInitializeTransaction ();
                ofertasEN = (OfertasEN)session.Get (typeof(OfertasEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ofertasEN;
}

public System.Collections.Generic.IList<OfertasEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<OfertasEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(OfertasEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<OfertasEN>();
                        else
                                result = session.CreateCriteria (typeof(OfertasEN)).List<OfertasEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (OfertasEN ofertas)
{
        try
        {
                SessionInitializeTransaction ();
                OfertasEN ofertasEN = (OfertasEN)session.Load (typeof(OfertasEN), ofertas.Id);


                ofertasEN.Descuento = ofertas.Descuento;


                ofertasEN.Precio = ofertas.Precio;


                ofertasEN.Puntos = ofertas.Puntos;


                ofertasEN.Vigencia = ofertas.Vigencia;


                session.Update (ofertasEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (OfertasEN ofertas)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (ofertas);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ofertas.Id;
}

public void Modify (OfertasEN ofertas)
{
        try
        {
                SessionInitializeTransaction ();
                OfertasEN ofertasEN = (OfertasEN)session.Load (typeof(OfertasEN), ofertas.Id);

                ofertasEN.Descuento = ofertas.Descuento;


                ofertasEN.Precio = ofertas.Precio;


                ofertasEN.Puntos = ofertas.Puntos;


                ofertasEN.Vigencia = ofertas.Vigencia;

                session.Update (ofertasEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
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
                OfertasEN ofertasEN = (OfertasEN)session.Load (typeof(OfertasEN), id);
                session.Delete (ofertasEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: OfertasEN
public OfertasEN ReadOID (int id
                          )
{
        OfertasEN ofertasEN = null;

        try
        {
                SessionInitializeTransaction ();
                ofertasEN = (OfertasEN)session.Get (typeof(OfertasEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ofertasEN;
}

public System.Collections.Generic.IList<OfertasEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<OfertasEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(OfertasEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<OfertasEN>();
                else
                        result = session.CreateCriteria (typeof(OfertasEN)).List<OfertasEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AsignarCarta (int p_Ofertas_OID, System.Collections.Generic.IList<int> p_carta_OIDs)
{
        DSMPracticaGenNHibernate.EN.DSMPractica.OfertasEN ofertasEN = null;
        try
        {
                SessionInitializeTransaction ();
                ofertasEN = (OfertasEN)session.Load (typeof(OfertasEN), p_Ofertas_OID);
                DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN cartaENAux = null;
                if (ofertasEN.Carta == null) {
                        ofertasEN.Carta = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN>();
                }

                foreach (int item in p_carta_OIDs) {
                        cartaENAux = new DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN ();
                        cartaENAux = (DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN)session.Load (typeof(DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN), item);
                        cartaENAux.Ofertas.Add (ofertasEN);

                        ofertasEN.Carta.Add (cartaENAux);
                }


                session.Update (ofertasEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in OfertasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
