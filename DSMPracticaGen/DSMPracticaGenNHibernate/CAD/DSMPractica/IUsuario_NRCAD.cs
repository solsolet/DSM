
using System;
using DSMPracticaGenNHibernate.EN.DSMPractica;

namespace DSMPracticaGenNHibernate.CAD.DSMPractica
{
public partial interface IUsuario_NRCAD
{
Usuario_NREN ReadOIDDefault (string email
                             );

void ModifyDefault (Usuario_NREN usuario_NR);

System.Collections.Generic.IList<Usuario_NREN> ReadAllDefault (int first, int size);



string New_ (Usuario_NREN usuario_NR);

void Modify (Usuario_NREN usuario_NR);


void Destroy (string email
              );


Usuario_NREN ReadOID (string email
                      );


System.Collections.Generic.IList<Usuario_NREN> ReadAll (int first, int size);
}
}
