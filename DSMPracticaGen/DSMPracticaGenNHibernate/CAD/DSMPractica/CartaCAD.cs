
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
 * Clase Carta:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class CartaCAD : BasicCAD, ICartaCAD
{
public CartaCAD() : base ()
{
}

public CartaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CartaEN ReadOIDDefault (int id
                               )
{
        CartaEN cartaEN = null;

        try
        {
                SessionInitializeTransaction ();
                cartaEN = (CartaEN)session.Get (typeof(CartaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cartaEN;
}

public System.Collections.Generic.IList<CartaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CartaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CartaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CartaEN>();
                        else
                                result = session.CreateCriteria (typeof(CartaEN)).List<CartaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CartaEN carta)
{
        try
        {
                SessionInitializeTransaction ();
                CartaEN cartaEN = (CartaEN)session.Load (typeof(CartaEN), carta.Id);


                cartaEN.Tipo = carta.Tipo;



                cartaEN.Linkterminos = carta.Linkterminos;


                cartaEN.Linkcarta = carta.Linkcarta;

                session.Update (cartaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CartaEN carta)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (carta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carta.Id;
}

public void Modify (CartaEN carta)
{
        try
        {
                SessionInitializeTransaction ();
                CartaEN cartaEN = (CartaEN)session.Load (typeof(CartaEN), carta.Id);

                cartaEN.Tipo = carta.Tipo;


                cartaEN.Linkterminos = carta.Linkterminos;


                cartaEN.Linkcarta = carta.Linkcarta;

                session.Update (cartaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
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
                CartaEN cartaEN = (CartaEN)session.Load (typeof(CartaEN), id);
                session.Delete (cartaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CartaEN
public CartaEN ReadOID (int id
                        )
{
        CartaEN cartaEN = null;

        try
        {
                SessionInitializeTransaction ();
                cartaEN = (CartaEN)session.Get (typeof(CartaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cartaEN;
}

public System.Collections.Generic.IList<CartaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CartaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CartaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CartaEN>();
                else
                        result = session.CreateCriteria (typeof(CartaEN)).List<CartaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in CartaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
