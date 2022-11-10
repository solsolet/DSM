
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
 * Clase Ingrediente:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class IngredienteCAD : BasicCAD, IIngredienteCAD
{
public IngredienteCAD() : base ()
{
}

public IngredienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public IngredienteEN ReadOIDDefault (int id
                                     )
{
        IngredienteEN ingredienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                ingredienteEN = (IngredienteEN)session.Get (typeof(IngredienteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredienteEN;
}

public System.Collections.Generic.IList<IngredienteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IngredienteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IngredienteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IngredienteEN>();
                        else
                                result = session.CreateCriteria (typeof(IngredienteEN)).List<IngredienteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IngredienteEN ingrediente)
{
        try
        {
                SessionInitializeTransaction ();
                IngredienteEN ingredienteEN = (IngredienteEN)session.Load (typeof(IngredienteEN), ingrediente.Id);

                ingredienteEN.Nombre = ingrediente.Nombre;



                ingredienteEN.Tipo = ingrediente.Tipo;


                ingredienteEN.Stock = ingrediente.Stock;


                ingredienteEN.Alergeno = ingrediente.Alergeno;

                session.Update (ingredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IngredienteEN ingrediente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (ingrediente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingrediente.Id;
}

public void Modify (IngredienteEN ingrediente)
{
        try
        {
                SessionInitializeTransaction ();
                IngredienteEN ingredienteEN = (IngredienteEN)session.Load (typeof(IngredienteEN), ingrediente.Id);

                ingredienteEN.Nombre = ingrediente.Nombre;


                ingredienteEN.Tipo = ingrediente.Tipo;


                ingredienteEN.Stock = ingrediente.Stock;


                ingredienteEN.Alergeno = ingrediente.Alergeno;

                session.Update (ingredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
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
                IngredienteEN ingredienteEN = (IngredienteEN)session.Load (typeof(IngredienteEN), id);
                session.Delete (ingredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IngredienteEN
public IngredienteEN ReadOID (int id
                              )
{
        IngredienteEN ingredienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                ingredienteEN = (IngredienteEN)session.Get (typeof(IngredienteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredienteEN;
}

public System.Collections.Generic.IList<IngredienteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IngredienteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IngredienteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IngredienteEN>();
                else
                        result = session.CreateCriteria (typeof(IngredienteEN)).List<IngredienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> FiltrarComida (int ? p_tComida)
{
        System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM IngredienteEN self where select ing FROM IngredienteEN as ing where ing.Tipo =: p_tComida";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("IngredienteENfiltrarComidaHQL");
                query.SetParameter ("p_tComida", p_tComida);

                result = query.List<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
