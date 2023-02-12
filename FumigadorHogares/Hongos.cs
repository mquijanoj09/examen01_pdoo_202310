using System;
namespace FumigadorHogares
{
    public class Hongos : Fumigador, IHongos
    {
        private string tipoDeProductoHongos;

        public Hongos() : base()
        {
            tipoDeProductoHongos = "";
        }

        public Hongos(string tipoDePlaga, bool obtuvoFumigacion, string tipoDeProductoHongos)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProductoHongos = tipoDeProductoHongos;
        }

        public string GetTipoDeProductoHongos()
        {
            return tipoDeProductoHongos;
        }

        public void SetTipoDeProductoHongos(string tipoDeProductoHongos)
        {
            this.tipoDeProductoHongos = tipoDeProductoHongos;
        }

        public string InfoProductoHongos()
        {
            string info = $"Tipo de producto: {tipoDeProductoHongos}";
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


