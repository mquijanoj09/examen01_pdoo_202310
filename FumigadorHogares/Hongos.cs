using System;
namespace FumigadorHogares
{
    public class Hongos : Fumigador, IHongos
    {

        public Hongos() : base()
        {
        }

        public Hongos(string tipoDePlaga, bool obtuvoFumigacion, string tipoDeProductoHongos)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProducto = tipoDeProductoHongos;
        }

        public string InfoProductoHongos()
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
                    InfoProductoHongos();
            }
            else
            {
                informacion = $"Este hogar no fue fumigado";
            }
            return informacion;
        }
    }
}


