using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMachine
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 3;
        static int seleccion_tipo = 0;
        [Flags]
        enum precio
        {
            Barato = 500,
            Normal = 600,
            Aceptable = 1000,
            Caro = 2000,
            MuyCaro = 5000,
        };
        struct product
        {
            public int codigo_articulo;
            public string nombre_articulo;
            public char tipo;
            public double precio;
            public double fecha_vencimiento;
            public string nombre_proveedor;
            public int posicion_estante;
        };

        static product[] products;

        static void Ingreso_productos()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < products.Length)
                {
                    
                    Console.WriteLine("*-* Global Machines  *-*");
                    Console.WriteLine("Ingreso de Productos.             ");
                    Console.Write("Digite el Codigo del Producto:                  ");
                    products[i].codigo_articulo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del Producto:    ");
                    products[i].nombre_articulo = Console.ReadLine();
                    Console.WriteLine("Seleccione el tipo del Producto:\n1-Confiteria\n2-Reposteria\n3-Frituras\n4-Refresco Gaseoso\n5-Refresco Natural");
                    seleccion_tipo =int.Parse( Console.ReadLine());
                    if (seleccion_tipo == 1)
                    {
                        products[i].tipo = 'C';
                    }
                    else if (seleccion_tipo == 2)
                    {
                        products[i].tipo = 'R';
                    }
                    else if (seleccion_tipo == 3)
                    {
                        products[i].tipo = 'F';
                    }
                    else if (seleccion_tipo == 4)
                    {
                        products[i].tipo = 'G';
                    }
                    else if (seleccion_tipo == 5)
                    {
                        products[i].tipo = 'N';
                    }
                    else { Console.WriteLine("Sexo no especificado"); }
                    Console.Write("Digite la fecha de vencimiento del Producto: ");
                    products[i].fecha_vencimiento = double.Parse(Console.ReadLine());
                    Console.Write("Digite el proveedor del Producto: ");
                    products[i].nombre_proveedor = Console.ReadLine();
                    Console.Write("Digite el nivel de la Posicion en el estante: ");
                    products[i].posicion_estante = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione el precio del Producto:");
                    Console.Write(precio.Barato + ": " + (int)precio.Barato + "\n" +
                                  precio.Normal + ": " + (int)precio.Normal + "\n" +
                                  precio.Aceptable + ": " + (int)precio.Aceptable + "\n" +
                                  precio.Caro + ": " + (int)precio.Caro + "\n" +
                                  precio.MuyCaro + ": " + (int)precio.MuyCaro + "\n");
                    products[i].precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Desea agregar otro Producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de Productos lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }
        static void Modificaion_productos()
        {
            int selecc = 0;
            int codigo_articulo = 0;
            int registro = 0;
            int resp = 0;
            bool found = false;
            while (resp != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines *-*");
                Console.WriteLine("Modificacion de Productos.           ");
                Console.WriteLine("Digite el Codigo del Producto a Modificar");
                codigo_articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Que desea Modificar:\n1-Registro\n2-Nombre\n3-Proveedor\n4-Tipo\n5-Fecha de Vencimiento\n6-Posicion del Estante\n7-Precio");
                selecc = int.Parse(Console.ReadLine());
                if (selecc == 1)
                {
                    Console.WriteLine("Ingrese el nuevo Registro del Producto:");
                    registro = int.Parse(Console.ReadLine());
                }

                if (selecc == 2)
                {
                    Console.Write("Digite el nuevo nombre del Producto: ");
                    products[i].nombre_articulo = Console.ReadLine();
                }
                if (selecc == 3)
                {
                    Console.WriteLine("Ingrese el nuevo proveedor del articulo:");
                    products[i].nombre_proveedor += Console.ReadLine();
                }
                if (selecc == 4)
                {
                    Console.WriteLine("Seleccione el nuevo tipo del Producto:\n1-Confiteria\n2-Reposteria\n3-Frituras\n4-Refresco Gaseoso\n5-Refresco Natural");
                    seleccion_tipo = int.Parse(Console.ReadLine());
                    if (seleccion_tipo == 1)
                    {
                        products[i].tipo = 'C';
                    }
                    else if (seleccion_tipo == 2)
                    {
                        products[i].tipo = 'R';
                    }
                    else if (seleccion_tipo == 3)
                    {
                        products[i].tipo = 'F';
                    }
                    else if (seleccion_tipo == 4)
                    {
                        products[i].tipo = 'G';
                    }
                    else if (seleccion_tipo == 5)
                    {
                        products[i].tipo = 'N';
                    }
                }
                if (selecc==5)
                {
                    Console.Write("Digite la nueva fecha de vencimiento del Producto: ");
                    products[i].fecha_vencimiento = double.Parse(Console.ReadLine());
                }

                if (selecc == 6)
                {
                    Console.WriteLine("Ingrese el nuevo Estante del Producto:");
                    products[i].posicion_estante = int.Parse(Console.ReadLine());
                }

                if (selecc == 7)
                {
                    Console.WriteLine("Seleccione el nuevo precio del Producto:");
                    Console.Write(precio.Barato + ": " + (int)precio.Barato + "\n" +
                                  precio.Normal + ": " + (int)precio.Normal + "\n" +
                                  precio.Aceptable + ": " + (int)precio.Aceptable + "\n" +
                                  precio.Caro + ": " + (int)precio.Caro + "\n" +
                                  precio.MuyCaro + ": " + (int)precio.MuyCaro + "\n");
                    products[i].precio = double.Parse(Console.ReadLine());
                }
                for (i = 0; i < products.Length; i++)
                {
                    if (codigo_articulo == products[i].codigo_articulo)
                    {


                        Console.WriteLine("Registro: " + registro);
                        Console.WriteLine("Codigo:       " + products[i].codigo_articulo);
                        Console.WriteLine("Nombre:   " + products[i].nombre_articulo);
                        Console.WriteLine("Autor:     " + products[i].nombre_proveedor);
                        Console.WriteLine("Precio:   " + products[i].precio);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No se encontro el Codigo de ese Producto");
                    found = false;
                }
                Console.WriteLine("Desea Modificar otro Producto 0-Sí 1-No");
                resp = int.Parse(Console.ReadLine());
            }
        }
        static int cont_Confiteria()
        {
            int cont_confi = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].tipo == 'C')
                {
                    cont_confi++;
                }
            }
            return cont_confi;
        }
        static int cont_frituras()
        {
            int cont_frituras = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].tipo == 'F')
                {
                    cont_frituras++;
                }
            }
            return cont_frituras;
        }
        static int cont_reposteria()
        {
            int cont_reposteria= 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].tipo == 'R')
                {
                    cont_reposteria++;
                }
            }
            return cont_reposteria;
        }
        static int cont_ref_gas()
        {
            int cont_refgas = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].tipo == 'G')
                {
                    cont_refgas++;
                }
            }
            return cont_refgas;
        }
        static int cont_ref_nat()
        {
            int cont_refnas = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].tipo == 'N')
                {
                    cont_refnas++;
                }
            }
            return cont_refnas;
        }
        static int cont_nivel1()
        {
            int nivel1 = 0;
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].posicion_estante == 1)
                {
                    nivel1++;
                }
            }
            return nivel1;
        }
        static int cont_nivel2()
        {
            int nivel2 = 0;
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].posicion_estante == 2)
                {
                    nivel2++;
                }
            }
            return nivel2;
        }
        static int cont_nivel3()
        {
            int nivel3 = 0;
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].posicion_estante == 3)
                {
                    nivel3++;
                }
            }
            return nivel3;
        }
        static int cont_nivel4()
        {
            int nivel4 = 0;
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].posicion_estante == 4)
                {
                    nivel4++;
                }
            }
            return nivel4;
        }
        static int cont_nivel5()
        {
            int nivel5 = 0;
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].posicion_estante == 5)
                {
                    nivel5++;
                }
            }
            return nivel5;
        }
        static void Eliminacion_productos()
        {
            int codigo_articulo = 0;
            int resp = 0;
            bool found = false;
            while (resp != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines *-*");
                Console.WriteLine("Eliminado de Productos");
                Console.WriteLine("Digite el Codigo del Producto a Eliminar");
                codigo_articulo = int.Parse(Console.ReadLine());
                for (i = 0; i < products.Length; i++)
                {
                    if (products[i].codigo_articulo == codigo_articulo)
                    {
                        products[i].codigo_articulo = 0;
                        products[i].nombre_articulo = "";
                        products[i].nombre_proveedor = "";
                        products[i].tipo = ' ';
                        products[i].fecha_vencimiento = 0;
                        products[i].posicion_estante = 0;
                        products[i].precio = 0;
                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese Codigo");
                        found = false;
                    }
                   
                } Console.WriteLine("Desea Eliminar otro Producto 0-Sí 1-No");
                    resp = int.Parse(Console.ReadLine());
            }
        }
        static void busqueda_productos()
        {

            int codigo_articulo = 0;
            int registro = 0;
            int resp = 0;
            bool found = false;
            while (resp != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("Busqueda de Productos.           ");
                Console.WriteLine("Digite el codigo del Producto a buscar");
                codigo_articulo = int.Parse(Console.ReadLine());
                for (i = 0; i < products.Length; i++)
                {
                    if (codigo_articulo == products[i].codigo_articulo)
                    {
                        registro = i + 1;
                        Console.WriteLine("Registro: " + registro);
                        Console.WriteLine("Codigo del Producto:       " + products[i].codigo_articulo);
                        Console.WriteLine("Nombre del producto:   " + products[i].nombre_articulo);
                        Console.WriteLine("Proveedor:     " + products[i].nombre_proveedor);
                        Console.WriteLine("Precio:   " + products[i].precio);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese Codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro Producto 0-Sí 1-No");
                resp = int.Parse(Console.ReadLine());
            }
        }
        static void listado_productos()
        {
            int registro = 0;
            Console.Clear();
            Console.WriteLine("                                                 Global Machines  ");
            Console.WriteLine("===============================================================================================");
            Console.WriteLine("                                               Listado de Productos             ");
            Console.WriteLine("===============================================================================================");
            Console.Write("Reg  Codigo  Nombre    Tipo  Vencimiento Proveedor Posicion Precio\n");
            for (i = 0; i < products.Length; i++)
            {
                registro = i + 1;
                Console.Write(registro+"     "+products[i].codigo_articulo+"      "+ products[i].nombre_articulo+"       "+products[i].tipo+"      "+products[i].fecha_vencimiento+"     "+products[i].nombre_proveedor+"    "+products[i].posicion_estante+ "        ₡" + products[i].precio+"\n");
            
            }
            Console.WriteLine("Fin del Listado...\n\n");
            Console.WriteLine("                  Global Machines  ");
            Console.WriteLine("=====================================================");
            Console.WriteLine("                  Listado de Productos             ");
            Console.WriteLine("=====================================================");
            Console.Write("Clasificacion          ||        Cantidad\n");
            Console.Write("Frituras               ||          "+cont_frituras()+"\n");
            Console.Write("Reposteria             ||          "+cont_reposteria()+"\n");
            Console.Write("Confiteria             ||          "+cont_Confiteria()+"\n");
            Console.Write("Refrescos Gaseosos     ||          "+cont_ref_gas()+"\n");
            Console.Write("Refrescos Naturales    ||          "+cont_ref_nat()+"\n");
            Console.Write("Nivel                  ||        Cantidad\n");
            Console.Write("1                      ||          "+cont_nivel1()+"\n");
            Console.Write("2                      ||          "+cont_nivel2()+"\n");
            Console.Write("3                      ||          " + cont_nivel3() + "\n");
            Console.Write("4                      ||          " + cont_nivel4() + "\n");
            Console.Write("5                      ||          " + cont_nivel5() + "\n");
            Console.Write("========================================================\n");
            Console.Write("Fin del Listado...");


            Console.ReadKey();
        }
        static void venta_productos()
        {
            int numero_telef = 0;
            string nombre_cliente = "";
            int impuvent = 0;
            int imputot = 0;
            int desc = 0;
            int monto = 0;
            int resp = 0;
            int cantidad = 1;
            double total = products[i].precio*cantidad+500;
            int seleccion = 0;
            int registro = 0;
            Console.Clear();
            Console.WriteLine("*-* Global Machine *-*");
            Console.WriteLine("--Seleccion de Productos--");
            for (i = 0; i < products.Length; i++)
            {
                registro = i + 1;
                Console.WriteLine(registro + "  " + products[i].nombre_articulo + "  ₡" + products[i].precio);
            }
            Console.WriteLine("Seleccione el que desee: ");
            while (resp != 1)
            {
                if (seleccion == registro)
                {
                    seleccion = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la cantidad que desee:");
                    cantidad = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Desea agragar otro producto:\n0-Si\n1-No");
                resp = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("============================================");
            Console.WriteLine("          ** Global Machine  **");
            Console.WriteLine("============================================");
            Console.WriteLine("Factura Proforma Nro: 0001");
            Console.WriteLine("Cliente:"+ nombre_cliente);
            Console.WriteLine("Telefono: "+numero_telef);
            Console.WriteLine("____________________________________________");
            Console.WriteLine("Item           Ctd         Precio      SubTotal");
            Console.Write(products[i].nombre_articulo+" "+cantidad+products[i].precio+""+total);
            Console.WriteLine("============================================");
            Console.WriteLine("Total Orden:                             "+total);
            Console.WriteLine("Descuento:                               "+desc );
            Console.WriteLine("Impuesto de Venta:                       "+impuvent);
            Console.WriteLine("Impuesto Total:                          "+imputot);
            Console.WriteLine("Precio Neto:");
            Console.WriteLine("____________________________________________");
            Console.WriteLine("Monto Recibido:");
            Console.WriteLine("Monto Cambio:");
            Console.WriteLine("____________________________________________");
            Console.WriteLine("Gracias Por su compra...");



            Console.ReadKey();
        }

            static void Main(string[] args)
        {
            products = new product[size];
            do
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de productos.");
                Console.WriteLine("2. Modificación de productos.");
                Console.WriteLine("3. Eliminación de productos.");
                Console.WriteLine("4. Búsquedad de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Seleccione una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Ingreso_productos();
                            break;
                        }
                    case 2:
                        {
                            Modificaion_productos();
                            break;
                        }
                    case 3:
                        {
                            Eliminacion_productos();
                            break;
                        }
                    case 4:
                        {
                            busqueda_productos();
                            break;
                        }
                    case 5:
                        {
                           listado_productos();
                            break;
                        }
                    case 6:
                        {
                          venta_productos();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccion no Valida...\n Selecione una opcion valida");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}
