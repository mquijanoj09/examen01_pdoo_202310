using System;
namespace FumigadorHogares
{
	public class Roedores : Fumigador, IRoedores
	{
        private string tipoDeProductoRoedores;

        public Roedores() : base()
		{
            tipoDeProductoRoedores = "";
        }

        public Roedores(string tipoDePlaga, bool obtuvoFumigacion, string tipoDeProductoRoedores)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProductoRoedores = tipoDeProductoRoedores;
        }

        public string GetTipoDeProductoRoedores()
        {
            return tipoDeProductoRoedores;
        }

        public void SetTipoDeProductoRoedores(string tipoDeProductoRoedores)
        {
            this.tipoDeProductoRoedores = tipoDeProductoRoedores;
        }

        public string InfoProductoRoedores()
		{
            string info = $"Tipo de producto: {tipoDeProductoRoedores}";
            return info;
        }

        public override string ToString()
        {
            string informacion;
            if (obtuvoFumigacion)
            {
                informacion = $"Esta es una fumigacion contra la plaga {tipoDePlaga}. \n" +
                    InfoProductoRoedores();
            }
            else
            {
                informacion = $"Este hogar no fue fumigado";
            }
            return informacion;
        }
    }
}

