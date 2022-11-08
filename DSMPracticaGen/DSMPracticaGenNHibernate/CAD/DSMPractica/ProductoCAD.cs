
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
 * Clase Producto:
 *
 */

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial class ProductoCAD : BasicCAD, IProductoCAD
{
public ProductoCAD() : base ()
{
}

public ProductoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductoEN ReadOIDDefault (string nombre
                                  )
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProductoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                        else
                                result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Nombre);

                productoEN.Descripcion = producto.Descripcion;


                productoEN.Categoria = producto.Categoria;


                productoEN.Precio = producto.Precio;


                productoEN.Cantidad = producto.Cantidad;




                productoEN.Foto = producto.Foto;



                productoEN.Novedad = producto.Novedad;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                if (producto.Ingrediente != null) {
                        for (int i = 0; i < producto.Ingrediente.Count; i++) {
                                producto.Ingrediente [i] = (DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN)session.Load (typeof(DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN), producto.Ingrediente [i].Nombre);
                                producto.Ingrediente [i].Producto.Add (producto);
                        }
                }

                session.Save (producto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return producto.Nombre;
}

public void Modify (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Nombre);

                productoEN.Descripcion = producto.Descripcion;


                productoEN.Categoria = producto.Categoria;


                productoEN.Precio = producto.Precio;


                productoEN.Cantidad = producto.Cantidad;


                productoEN.Foto = producto.Foto;


                productoEN.Novedad = producto.Novedad;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
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
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), nombre);
                session.Delete (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ProductoEN
public ProductoEN ReadOID (string nombre
                           )
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                else
                        result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AsignarCarta (string p_Producto_OID, System.Collections.Generic.IList<int> p_carta_OIDs)
{
        DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN productoEN = null;
        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_Producto_OID);
                DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN cartaENAux = null;
                if (productoEN.Carta == null) {
                        productoEN.Carta = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN>();
                }

                foreach (int item in p_carta_OIDs) {
                        cartaENAux = new DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN ();
                        cartaENAux = (DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN)session.Load (typeof(DSMPracticaGenNHibernate.EN.DSMPractica.CartaEN), item);
                        cartaENAux.Producto.Add (productoEN);

                        productoEN.Carta.Add (cartaENAux);
                }


                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMPracticaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMPracticaGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
