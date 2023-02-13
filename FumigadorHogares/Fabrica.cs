using System;
namespace FumigadorHogares
{
    public class Fabrica
    {
        private int cantidad;
        private int sumaHogaresFumigados;
        private float porcentajeHogaresFumigados;
        private string[] tipoDeProductoRoedores;
        private string[] tipoDeProductoInsectos;
        private string[] tipoDeProductoHongos;
        private bool[] fueFumigada;
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
                        arregloFumigadores[i] = new Roedores("Roedores",
                            estaFumigado,
                            tipoDeProductoRoedores[aleatorio.Next(tipoDeProductoRoedores.Length)]);
                        ContabilizaHogaresFumigados(estaFumigado);
                        break;
                    case 1:
                        arregloFumigadores[i] = new Insectos("Insectos",
                            estaFumigado,
                            tipoDeProductoInsectos[aleatorio.Next(tipoDeProductoInsectos.Length)]);
                        ContabilizaHogaresFumigados(estaFumigado);
                        break;
                    case 2:
                        
                        arregloFumigadores[i] = new Hongos("Hongos",
                            estaFumigado,
                            tipoDeProductoHongos[aleatorio.Next(tipoDeProductoHongos.Length)]);
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
    }
}

