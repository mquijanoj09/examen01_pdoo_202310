using System;
namespace FumigadorHogares
{
    public class Fabrica
    {
        private int cantidad, sumaHogaresFumigados;
        private float porcentajeHogaresFumigados;
        private string[] tipoDeProductoRoedores;
        private string[] tipoDeProductoInsectos;
        private string[] tipoDeProductoHongos;
        private bool[] fueFumigada;
        private string[] arregloPlagas;
        private Fumigador[] losFumigadores;

        public Fabrica()
        {
            cantidad = 0;
            porcentajeHogaresFumigados = 0f;
            sumaHogaresFumigados = 0;
            tipoDeProductoRoedores = AsignaTipoDeProductoRoedores();
            tipoDeProductoInsectos = AsignaTipoDeProductoInsectos();
            tipoDeProductoHongos = AsignaTipoDeProductoHongos();
            fueFumigada = AsignaSiEsFumigada();
            losFumigadores = AsignaFumigadores();
            arregloPlagas = AsignaPlagas();

        }

        public Fabrica(int cantidad)
        {
            this.cantidad = cantidad;
            porcentajeHogaresFumigados = 0f;
            sumaHogaresFumigados = 0;
            tipoDeProductoRoedores = AsignaTipoDeProductoRoedores();
            tipoDeProductoInsectos = AsignaTipoDeProductoInsectos();
            tipoDeProductoHongos = AsignaTipoDeProductoHongos();
            fueFumigada = AsignaSiEsFumigada();
            losFumigadores = AsignaFumigadores();
            arregloPlagas = AsignaPlagas();
        }

        private Fumigador[] AsignaFumigadores()
        {
            if (cantidad == 0)
                cantidad = 1000;

            //Creamos el arreglo de fumigadores
            Fumigador[] arregloFumigadores = new Fumigador[cantidad];

            Random aleatorio = new Random();
            int tipoDePlaga = 0;
            bool estaFumigado = false;


            for (int i = 0; i < arregloFumigadores.Length; i++)
            {
                //0: Roedores, 1: Insectos, 2: Hongos
                tipoDePlaga = aleatorio.Next(3);
                estaFumigado = fueFumigada[aleatorio.Next(fueFumigada.Length)];

                switch (tipoDePlaga)
                {
                    case 0:
                        arregloFumigadores[i] = new Roedores(estaFumigado ? "Roedores": "",
                            estaFumigado,
                            estaFumigado?tipoDeProductoRoedores[aleatorio.Next(tipoDeProductoRoedores.Length)]: "");
                        ContabilizaHogaresFumigados(estaFumigado);
                        break;
                    case 1:
                        arregloFumigadores[i] = new Insectos(estaFumigado ? "Insectos": "",
                            estaFumigado,
                            estaFumigado ? tipoDeProductoInsectos[aleatorio.Next(tipoDeProductoInsectos.Length)]: "");
                        ContabilizaHogaresFumigados(estaFumigado);
                        break;
                    case 2:
                        
                        arregloFumigadores[i] = new Hongos(estaFumigado ? "Hongos": "",
                            estaFumigado,
                            estaFumigado ? tipoDeProductoHongos[aleatorio.Next(tipoDeProductoHongos.Length)]: "");
                        ContabilizaHogaresFumigados(estaFumigado);
                        break;
                } 
            }
            ObtienePorcentajeHogaresFumigados();
            return arregloFumigadores;
        }

        public Fumigador[] GetLosFumigadores()
        {
            return losFumigadores;
        }

        private string[] AsignaPlagas()
        {
            string[] arregloPlagas =
            {
                "Roedores",
                "Insectos",
                "Hongos"
            };
            return arregloPlagas;
        }

        private string[] AsignaTipoDeProductoRoedores()
        {
            string[] arregloProductosRoedores =
            {
                "Anticoagulantes R",
                "Neurotoxicos R",
                "Repelentes R"
            };
            return arregloProductosRoedores;
        }

        private string[] AsignaTipoDeProductoInsectos()
        {
            string[] arregloProductoInsectos =
            {
                "Insecticidas I",
                "Repelentes I",
                "Desinfectantes I"
            };
            return arregloProductoInsectos;
        }

        private string[] AsignaTipoDeProductoHongos()
        {
            string[] arregloProductoHongos =
            {
                "Desinfectantes H",
                "Fungisidas H",
                "Inhibidores H"
            };
            return arregloProductoHongos;
        }

        public bool[] AsignaSiEsFumigada()
        {
            bool[] arregloSiEsFumigada =
            {
                true,
                false
            };

            return arregloSiEsFumigada;
        }

        private void ContabilizaHogaresFumigados(bool estaFumigado)
        {
            if (estaFumigado)
            sumaHogaresFumigados++;
        }

        private void ObtienePorcentajeHogaresFumigados()
        {
            porcentajeHogaresFumigados = (float) sumaHogaresFumigados / cantidad * 100;
        }

        public float GetPorcentajeHogaresFumigados()
        {
            return porcentajeHogaresFumigados;
        }

        public ProductoModa ObtieneProductoModa()
        {
            ProductoModa productoResultado = ObtieneProductoPlagaMasUtilizado(losFumigadores, arregloPlagas);
            return productoResultado;
        }

        public ProductoModa ObtieneProductoPlagaMasUtilizado(Fumigador[] arregloFumigadores, string[] arregloPlagas)
        {
            int[] contadorProductos = new int[arregloPlagas.Length];
            for (int i = 0; i < contadorProductos.Length; i++)
                contadorProductos[i] = 0;

            for (int i = 0; i < arregloPlagas.Length; i++)
            {
                for (int j = 0; j < arregloFumigadores.Length; j++)
                {
                
                    if (arregloPlagas[i] == arregloFumigadores[j].GetTipoDePlaga())
                        contadorProductos[i]++;
                }
            }

            int valorMayor = contadorProductos[0];
            int posicionMayor = 0;

            for (int i = 0; i < contadorProductos.Length; i++)
            {
                if (contadorProductos[i] > valorMayor)
                {
                    valorMayor = contadorProductos[i];
                    posicionMayor = i;
                }
            }

            string[] arregloPlagasProductos= new string[3];

            switch (posicionMayor)
            {
                case 0:
                    arregloPlagasProductos = AsignaTipoDeProductoRoedores();
                    break;
                case 1:
                    arregloPlagasProductos = AsignaTipoDeProductoInsectos();
                    break;
                case 2:
                    arregloPlagasProductos = AsignaTipoDeProductoHongos();
                    break;
            }

            int[] contadorProductosPlagas = new int[arregloPlagasProductos.Length];
            for (int i = 0; i < contadorProductosPlagas.Length; i++)
                contadorProductosPlagas[i] = 0;

            for (int i = 0; i < arregloPlagasProductos.Length; i++)
            {
                for (int j = 0; j < arregloFumigadores.Length; j++)
                   
                {
                    if (arregloPlagasProductos[i] == arregloFumigadores[j].GetTipoDeProducto())
                        contadorProductosPlagas[i]++;
                }
            }

            int valorMayorPlaga = contadorProductosPlagas[0];
            int posicionMayorPlaga = 0;

            for (int i = 0; i < contadorProductosPlagas.Length; i++)
            {
                if (contadorProductosPlagas[i] > valorMayorPlaga)
                {
                    valorMayorPlaga = contadorProductosPlagas[i];
                    posicionMayorPlaga = i;
                }
            }
            ProductoModa productoResultado = new ProductoModa();

            productoResultado.SetTipoDeProducto(arregloPlagasProductos[posicionMayorPlaga]);
            productoResultado.SetTipoDePlaga(arregloPlagas[posicionMayor]);

            return productoResultado;
        }
    }
}

