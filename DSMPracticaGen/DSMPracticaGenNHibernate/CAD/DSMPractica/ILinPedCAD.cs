
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface ILinPedCAD
{
LinPedEN ReadOIDDefault (int linea
                         );

void ModifyDefault (LinPedEN linPed);

System.Collections.Generic.IList<LinPedEN> ReadAllDefault (int first, int size);



int New_ (LinPedEN linPed);

void Modify (LinPedEN linPed);


void Destroy (int linea
              );


LinPedEN ReadOID (int linea
                  );


System.Collections.Generic.IList<LinPedEN> ReadAll (int first, int size);
}
}
