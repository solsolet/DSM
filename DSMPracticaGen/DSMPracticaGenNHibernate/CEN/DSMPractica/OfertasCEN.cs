

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
 *      Definition of the class OfertasCEN
 *
 */
public partial class OfertasCEN
{
private IOfertasCAD _IOfertasCAD;

public OfertasCEN()
{
        this._IOfertasCAD = new OfertasCAD ();
}

public OfertasCEN(IOfertasCAD _IOfertasCAD)
{
        this._IOfertasCAD = _IOfertasCAD;
}

public IOfertasCAD get_IOfertasCAD ()
{
        return this._IOfertasCAD;
}

public int New_ (float p_descuento, float p_precio, int p_puntos, bool p_vigencia)
{
        OfertasEN ofertasEN = null;
        int oid;

        //Initialized OfertasEN
        ofertasEN = new OfertasEN ();
        ofertasEN.Descuento = p_descuento;

        ofertasEN.Precio = p_precio;

        ofertasEN.Puntos = p_puntos;

        ofertasEN.Vigencia = p_vigencia;

        //Call to OfertasCAD

        oid = _IOfertasCAD.New_ (ofertasEN);
        return oid;
}

public void Modify (int p_Ofertas_OID, float p_descuento, float p_precio, int p_puntos, bool p_vigencia)
{
        OfertasEN ofertasEN = null;

        //Initialized OfertasEN
        ofertasEN = new OfertasEN ();
        ofertasEN.Id = p_Ofertas_OID;
        ofertasEN.Descuento = p_descuento;
        ofertasEN.Precio = p_precio;
        ofertasEN.Puntos = p_puntos;
        ofertasEN.Vigencia = p_vigencia;
        //Call to OfertasCAD

        _IOfertasCAD.Modify (ofertasEN);
}

public void Destroy (int id
                     )
{
        _IOfertasCAD.Destroy (id);
}

public OfertasEN ReadOID (int id
                          )
{
        OfertasEN ofertasEN = null;

        ofertasEN = _IOfertasCAD.ReadOID (id);
        return ofertasEN;
}

public System.Collections.Generic.IList<OfertasEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<OfertasEN> list = null;

        list = _IOfertasCAD.ReadAll (first, size);
        return list;
}
public void AsignarCarta (int p_Ofertas_OID, System.Collections.Generic.IList<int> p_carta_OIDs)
{
        //Call to OfertasCAD

        _IOfertasCAD.AsignarCarta (p_Ofertas_OID, p_carta_OIDs);
}
}
}
