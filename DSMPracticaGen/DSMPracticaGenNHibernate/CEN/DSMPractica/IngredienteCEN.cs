

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
 *      Definition of the class IngredienteCEN
 *
 */
public partial class IngredienteCEN
{
private IIngredienteCAD _IIngredienteCAD;

public IngredienteCEN()
{
        this._IIngredienteCAD = new IngredienteCAD ();
}

public IngredienteCEN(IIngredienteCAD _IIngredienteCAD)
{
        this._IIngredienteCAD = _IIngredienteCAD;
}

public IIngredienteCAD get_IIngredienteCAD ()
{
        return this._IIngredienteCAD;
}

public int New_ (string p_nombre, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum p_tipo, int p_stock, string p_alergeno)
{
        IngredienteEN ingredienteEN = null;
        int oid;

        //Initialized IngredienteEN
        ingredienteEN = new IngredienteEN ();
        ingredienteEN.Nombre = p_nombre;

        ingredienteEN.Tipo = p_tipo;

        ingredienteEN.Stock = p_stock;

        ingredienteEN.Alergeno = p_alergeno;

        //Call to IngredienteCAD

        oid = _IIngredienteCAD.New_ (ingredienteEN);
        return oid;
}

public void Modify (int p_Ingrediente_OID, string p_nombre, DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum p_tipo, int p_stock, string p_alergeno)
{
        IngredienteEN ingredienteEN = null;

        //Initialized IngredienteEN
        ingredienteEN = new IngredienteEN ();
        ingredienteEN.Id = p_Ingrediente_OID;
        ingredienteEN.Nombre = p_nombre;
        ingredienteEN.Tipo = p_tipo;
        ingredienteEN.Stock = p_stock;
        ingredienteEN.Alergeno = p_alergeno;
        //Call to IngredienteCAD

        _IIngredienteCAD.Modify (ingredienteEN);
}

public void Destroy (int id
                     )
{
        _IIngredienteCAD.Destroy (id);
}

public IngredienteEN ReadOID (int id
                              )
{
        IngredienteEN ingredienteEN = null;

        ingredienteEN = _IIngredienteCAD.ReadOID (id);
        return ingredienteEN;
}

public System.Collections.Generic.IList<IngredienteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IngredienteEN> list = null;

        list = _IIngredienteCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.IngredienteEN> FiltrarComida (int ? p_tComida)
{
        return _IIngredienteCAD.FiltrarComida (p_tComida);
}
}
}
