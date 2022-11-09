

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMPracticaGenNHibernate.Exceptions;

using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;


namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
/*
 *      Definition of the class ProductoCEN
 *
 */
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public string New_ (string p_nombre, string p_descripcion, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum p_categoria, float p_precio, int p_cantidad, System.Collections.Generic.IList<string> p_ingrediente, string p_foto, bool p_novedad)
{
        ProductoEN productoEN = null;
        string oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Nombre = p_nombre;

        productoEN.Descripcion = p_descripcion;

        productoEN.Categoria = p_categoria;

        productoEN.Precio = p_precio;

        productoEN.Cantidad = p_cantidad;


        productoEN.Ingrediente = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN>();
        if (p_ingrediente != null) {
                foreach (string item in p_ingrediente) {
                        DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN en = new DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN ();
                        en.Nombre = item;
                        productoEN.Ingrediente.Add (en);
                }
        }

        else{
                productoEN.Ingrediente = new System.Collections.Generic.List<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN>();
        }

        productoEN.Foto = p_foto;

        productoEN.Novedad = p_novedad;

        //Call to ProductoCAD

        oid = _IProductoCAD.New_ (productoEN);
        return oid;
}

public void Modify (string p_Producto_OID, string p_descripcion, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum p_categoria, float p_precio, int p_cantidad, string p_foto, bool p_novedad)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Nombre = p_Producto_OID;
        productoEN.Descripcion = p_descripcion;
        productoEN.Categoria = p_categoria;
        productoEN.Precio = p_precio;
        productoEN.Cantidad = p_cantidad;
        productoEN.Foto = p_foto;
        productoEN.Novedad = p_novedad;
        //Call to ProductoCAD

        _IProductoCAD.Modify (productoEN);
}

public void Destroy (string nombre
                     )
{
        _IProductoCAD.Destroy (nombre);
}

public ProductoEN ReadOID (string nombre
                           )
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.ReadOID (nombre);
        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> FiltrarCategoria ()
{
        return _IProductoCAD.FiltrarCategoria ();
}
public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> FiltrarPrecio ()
{
        return _IProductoCAD.FiltrarPrecio ();
}
public void AsignarCarta (string p_Producto_OID, System.Collections.Generic.IList<int> p_carta_OIDs)
{
        //Call to ProductoCAD

        _IProductoCAD.AsignarCarta (p_Producto_OID, p_carta_OIDs);
}
}
}
