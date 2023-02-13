using System;
namespace FumigadorHogares
{
    public class Insectos : Fumigador, IInsectos
    {
        public Insectos() : base()
        {
        }

        public Insectos(string tipoDePlaga, bool obtuvoFumigacion, string tipoDeProductoInsectos)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProducto = tipoDeProductoInsectos;
        }

        public string InfoProductoInsectos()
        {
            string info = $"Tipo de producto: {tipoDeProducto}";
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


