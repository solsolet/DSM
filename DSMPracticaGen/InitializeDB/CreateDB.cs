
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DSMPracticaGenNHibernate.EN.DSMPractica;
using DSMPracticaGenNHibernate.CEN.DSMPractica;
using DSMPracticaGenNHibernate.CAD.DSMPractica;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes
                UsuarioCEN usuCEN = new UsuarioCEN ();
                int idUsu = usuCEN.New_ ("pedro08@gmail.com", "c/Quintana n32", 1234567890123456789, "Pedro", "Llorca", 963453454, 75, "123123a");

                //AdministradorCEN adminCEN = new AdministradorCEN ();
                //adminCEN.New_ ("Pedro Ruiz", "hola1234");

                ////crear antes de producto ingrediente
                //IngredienteCEN ingCEN = new IngredienteCEN ();
                //string ing1 = ingCEN.New_ ("patata", DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum.vegano, 23, "");
                //string ing2 = ingCEN.New_ ("nugget", DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum.general, 52, "huevo");
                //string ing3 = ingCEN.New_ ("tomate", DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum.vegano, 17, "");

                ////IList<>
                //IList<IngredienteEN> todosIngredientes = ingCEN.ReadAll (0, 2);
                //IList<String> listaIng = new List<String>();
                //foreach (IngredienteEN ing in todosIngredientes) {
                //        listaIng.Add (ing.Nombre);
                //}

                //NotificacionCEN notCEN = new NotificacionCEN ();

                //int idNoti1 = notCEN.New_ ();
                //int idNoti2 = notCEN.New_ ();
                //int idNoti3 = notCEN.New_ ();

                //IList<NotificacionEN> todasNotficaciones = notCEN.ReadAll (0, 2);
                //IList<int> listaNot = new List<int>();
                //foreach (NotificacionEN noti in todasNotficaciones) {
                //        listaNot.Add (noti.Id);
                //}

                //ProductoCEN prodCEN = new ProductoCEN (); //da error ns como solucionarlo
                //string idProd = prodCEN.New_ ("Pedro", "hamburguesa", DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoCategoriaEnum.hamburguesa, 10, 3, listaIng, "hambur.jpg", true); //no tiene sentido la lista de ingredientes con la hamburguesa pero xdd


                //PedidoCEN pedCEN = new PedidoCEN ();
                ////int idPed = pedCEN.New_ ("c/Quintana n32", new DateTime (2022, 4, 5), "pedro08@gmail.com", 22, "pedro08@gmail.com", DSMPracticaGenNHibernate.Enumerated.DSMPractica.EstadoPedidoEnum.enviado, new DateTime (20022, 4, 5), listaNot);

                //LinPedCEN lpCEN = new LinPedCEN ();
                //int lin1 = lpCEN.New_ ("Agua", idPed, 1, 1);
                //int lin2 = lpCEN.New_ ("Patatas deluxe", idPed, 2, 2);
                //int lin3 = lpCEN.New_ ("FMburger", idPed, 1, 5);

                //FacturaCEN facCEN = new FacturaCEN ();
                //facCEN.New_ (new DateTime (2022, 8, 8), true, false, 45, idPed);

                //CartaCEN carCEN = new CartaCEN ();
                //carCEN.New_ (DSMPracticaGenNHibernate.Enumerated.DSMPractica.TipoComidaEnum.vegano, "cartavegana.com", "carta.com");


                //ValoracionCEN valCEN = new ValoracionCEN ();
                //valCEN.New_ (3, "Muy rapidos y atentos", idUsu, idPed);

                //// p.e. CustomerCEN customer = new CustomerCEN();
                //// customer.New_ (p_user:"user", p_password:"1234");

                ///*
                // *
                // * //IList<>
                // * IList<IngredienteEN> todosIngredientes = ingCEN.ReadAll (0, 2);
                // * IList<String> listaIng = new List<String>();
                // * foreach (IngredienteEN ing in todosIngredientes) {
                // *      listaIng.Add (ing.Nombre);
                // * }
                // */

                ////pedidoporProducto
                //IList<PedidoEN> listaPedidos = pedCEN.PedidoporProducto (idProd);

                //Console.WriteLine ("Lista de Pedidos que tienen el producto  " + idProd);
                //foreach (PedidoEN ped in listaPedidos) {
                //        Console.WriteLine ("Pedido " + ped.Id);
                //}

                ////filtrarCarta

                //IList<CartaEN> listaCartas = carCEN.FiltrarCarta (1);
                //Console.WriteLine ("Lista de Cartas que son del tipo " + 1);
                //foreach (CartaEN cart in listaCartas) {
                //        Console.WriteLine ("Carta  " + cart.Tipo);
                //}

                ////filtrarCategoria

                //IList<ProductoEN> listaProd = prodCEN.FiltrarCategoria (1);
                //Console.WriteLine ("Lista de Productos que son del tipo " + 1);
                //foreach (ProductoEN prod in listaProd) {
                //        Console.WriteLine ("Producto  " + prod.Nombre);
                //}

                ////filtrarComida

                //IList<IngredienteEN> listaIng1 = ingCEN.FiltrarComida (2);
                //Console.WriteLine ("Lista de Ingredientes que son del tipo " + 2);
                //foreach (IngredienteEN ing in listaIng1) {
                //        Console.WriteLine ("Ingrediente  " + ing.Nombre);
                //}

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
