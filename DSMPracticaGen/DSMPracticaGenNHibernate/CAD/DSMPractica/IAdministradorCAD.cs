
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (int id
                                );

void ModifyDefault (AdministradorEN administrador);

System.Collections.Generic.IList<AdministradorEN> ReadAllDefault (int first, int size);






int New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (int id
              );


AdministradorEN ReadOID (int id
                         );


System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size);
}
}
