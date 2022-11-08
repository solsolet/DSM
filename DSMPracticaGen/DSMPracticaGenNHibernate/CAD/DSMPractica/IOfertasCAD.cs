
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IOfertasCAD
{
OfertasEN ReadOIDDefault (int id
                          );

void ModifyDefault (OfertasEN ofertas);

System.Collections.Generic.IList<OfertasEN> ReadAllDefault (int first, int size);



int New_ (OfertasEN ofertas);

void Modify (OfertasEN ofertas);


void Destroy (int id
              );


OfertasEN ReadOID (int id
                   );


System.Collections.Generic.IList<OfertasEN> ReadAll (int first, int size);




void AsignarCarta (int p_Ofertas_OID, System.Collections.Generic.IList<int> p_carta_OIDs);
}
}
