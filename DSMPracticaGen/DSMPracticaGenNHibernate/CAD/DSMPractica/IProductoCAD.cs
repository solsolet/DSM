
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (string nombre
                           );

void ModifyDefault (ProductoEN producto);

System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size);



string New_ (ProductoEN producto);

void Modify (ProductoEN producto);


void Destroy (string nombre
              );


ProductoEN ReadOID (string nombre
                    );


System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size);



System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> FiltrarCategoria ();


System.Collections.Generic.IList<DSMPracticaGenNHibernate.EN.DSMPractica.ProductoEN> FiltrarPrecio ();


void AsignarCarta (string p_Producto_OID, System.Collections.Generic.IList<int> p_carta_OIDs);
}
}
