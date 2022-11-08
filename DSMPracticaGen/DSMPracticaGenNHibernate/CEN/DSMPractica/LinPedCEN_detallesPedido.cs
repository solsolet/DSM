
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMPracticaGenNHibernate.Exceptions;
using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;


/*PROTECTED REGION ID(usingDSMPracticaGenNHibernate.CEN.DSMPractica_LinPed_detallesPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMPracticaGenNHibernate.CEN.DSMPractica
{
public partial class LinPedCEN
{
public void DetallesPedido (int p_oid, DSMPracticaGenNHibernate.EN.DSMPractica.PedidoEN pedido)
{
            /*PROTECTED REGION ID(DSMPracticaGenNHibernate.CEN.DSMPractica_LinPed_detallesPedido) ENABLED START*/

            PedidoEN ped = _IPedidoCAD.DameporOID(pedido);
            Console.WriteLine("id: " + ped.id);
            Console.WriteLine("Dirección de entrega: " + ped.Direntrega);
            Console.WriteLine("Hora Máxima: " + ped.Hramaxima);
            Console.WriteLine("Cliente: " + ped.Cliente);
            Console.WriteLine("Precio: " + ped.Precio);
            Console.WriteLine("Estado: " + ped.Estado);
            Console.WriteLine("Fecha: " + ped.Fecha);


            throw new NotImplementedException ("Method DetallesPedido() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
