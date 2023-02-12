using System;
namespace FumigadorHogares
{
    public class Fabrica
    {
        private int cantidad;
        private string[] tipoDeProductoRoedores;
        private string[] tipoDeProductoInsectos;
        private string[] tipoDeProductoHongos;
        private bool[] fueFumigada;
        private Fumigador[] losFumigadores;

        public Fabrica()
        {
            cantidad = 0;
            tipoDeProductoRoedores = AsignaTipoDeProductoRoedores();
            tipoDeProductoInsectos = AsignaTipoDeProductoInsectos();
            tipoDeProductoHongos = AsignaTipoDeProductoHongos();
            fueFumigada = AsignaSiEsFumigada();
            losFumigadores = AsignaFumigadores();

        }

        public Fabrica(int cantidad)
        {
            this.cantidad = cantidad;
            tipoDeProductoRoedores = AsignaTipoDeProductoRoedores();
            tipoDeProductoInsectos = AsignaTipoDeProductoInsectos();
            tipoDeProductoHongos = AsignaTipoDeProductoHongos();
            fueFumigada = AsignaSiEsFumigada();
            losFumigadores = AsignaFumigadores();
        }

        private Fumigador[] AsignaFumigadores()
        {
            if (cantidad == 0)
                cantidad = 1000;

            //Creamos el arreglo de arepas
            Fumigador[] arregloFumigadores = new Fumigador[cantidad];

            Random aleatorio = new Random();
            int tipoDePlaga = 0;

            //Inicializamos cada posicion del arreglo de arepas
            //con una arepa de tipo aleatorio

            for (int i = 0; i < arregloFumigadores.Length; i++)
            {
                //0: Roedores, 1: Congelada, 2: Procesada
                tipoDePlaga = aleatorio.Next(3);

                switch (tipoDePlaga)
                {
                    case 0:
                        arregloFumigadores[i] = new Roedores("Roedores",
                            fueFumigada[aleatorio.Next(fueFumigada.Length)],
                            tipoDeProductoRoedores[aleatorio.Next(tipoDeProductoRoedores.Length)]);
                        break;
                    case 1:
                        arregloFumigadores[i] = new Insectos("Insectos",
                            fueFumigada[aleatorio.Next(fueFumigada.Length)],
                            tipoDeProductoInsectos[aleatorio.Next(tipoDeProductoInsectos.Length)]);
                        break;
                    case 2:
                        arregloFumigadores[i] = new Hongos("Hongos",
                            fueFumigada[aleatorio.Next(fueFumigada.Length)],
                            tipoDeProductoHongos[aleatorio.Next(tipoDeProductoHongos.Length)]);
                        break;
                }
            }
            return arregloFumigadores;
        }

        public Fumigador[] GetLosFumigadores()
        {
            return losFumigadores;
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
    }
}

