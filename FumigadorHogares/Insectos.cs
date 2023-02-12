using System;
namespace FumigadorHogares
{
    public class Insectos : Fumigador, IInsectos
    {
        private string tipoDeProductoInsectos;

        public Insectos() : base()
        {
            tipoDeProductoInsectos = "";
        }

        public Insectos(string tipoDePlaga, bool obtuvoFumigacion, string tipoDeProductoInsectos)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProductoInsectos = tipoDeProductoInsectos;
        }

        public string GetTipoDeProductoInsectos()
        {
            return tipoDeProductoInsectos;
        }

        public void SetTipoDeProductoInsectos(string tipoDeProductoInsectos)
        {
            this.tipoDeProductoInsectos = tipoDeProductoInsectos;
        }

        public string InfoProductoInsectos()
        {
            string info = $"Tipo de producto: {tipoDeProductoInsectos}";
            return info;
        }

        public override string ToString()
        {
            string informacion;
            if (obtuvoFumigacion)
            {
                informacion = $"Esta es una fumigacion contra la plaga {tipoDePlaga}. \n" +
                    InfoProductoInsectos();
            }
            else
            {
                informacion = $"Este hogar no fue fumigado";
            }
            return informacion;
        }
    }
}


