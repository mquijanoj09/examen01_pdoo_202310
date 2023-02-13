using System;
namespace FumigadorHogares
{
	public abstract class Fumigador
    {
        protected string tipoDePlaga;
        protected bool obtuvoFumigacion;
        protected string tipoDeProducto;

        public Fumigador()
		{
            tipoDePlaga = "";
            obtuvoFumigacion = false;
            tipoDeProducto = "";
        }

        public Fumigador(string tipoDePlaga, bool obtuvoFumigacion, string tipoDeProducto)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
            this.tipoDeProducto = tipoDeProducto;
        }

        public string GetTipoDePlaga()
        {
            return tipoDePlaga;
        }

        public void SetTipoDePlaga(string tipoDePlaga)
        {
            this.tipoDePlaga = tipoDePlaga;
        }

        public string GetTipoDeProducto()
        {
            return tipoDeProducto;
        }

        public void SetTipoDeProducto(string tipoDeProducto)
        {
            this.tipoDeProducto = tipoDeProducto;
        }

        public bool GetObtuvoFumigacion()
        {
            return obtuvoFumigacion;
        }

        public void SetObtuvoFumigacion(bool obtuvoFumigacion)
        {
            this.obtuvoFumigacion = obtuvoFumigacion;
        }

        public abstract override string ToString();
    }
}

