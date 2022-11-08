
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string nombre
                                );

void ModifyDefault (AdministradorEN administrador);

System.Collections.Generic.IList<AdministradorEN> ReadAllDefault (int first, int size);






string New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (string nombre
              );


AdministradorEN ReadOID (string nombre
                         );


System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size);
}
}
