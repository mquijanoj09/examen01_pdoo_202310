using System;
namespace FumigadorHogares
{
	public class Roedores : Fumigador, IRoedores
	{
        public Roedores() : base()
        { }

        public Roedores(string tipoDePlaga, bool obtuvoFumigacion, string tipoDeProductoRoedores)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProducto = tipoDeProductoRoedores;
        }


        public string InfoProductoRoedores()
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

