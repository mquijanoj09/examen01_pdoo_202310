using System;
namespace FumigadorHogares
{
	public class ProductoModa : Fumigador
	{

        public ProductoModa() : base()
		{
		}

        public ProductoModa(string tipoDePlaga, bool obtuvoFumigacion, string producto)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProducto = producto;
        }

        public override string ToString()
        {
            string informacion;
            informacion = $"";
            return informacion;
        }

    
     
    }
}

