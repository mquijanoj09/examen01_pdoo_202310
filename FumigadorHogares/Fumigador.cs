using System;
namespace FumigadorHogares
{
	public abstract class Fumigador
    {
        protected string tipoDePlaga;
        protected bool obtuvoFumigacion;

        public Fumigador()
		{
            tipoDePlaga = "";
            obtuvoFumigacion = false;
        }

        public Fumigador(string tipoDePlaga, bool obtuvoFumigacion)
        {
            this.tipoDePlaga = tipoDePlaga;
            this.obtuvoFumigacion = obtuvoFumigacion;
        }

        public string GetTipoDePlaga()
        {
            return tipoDePlaga;
        }

        public void SetTipoDePlaga(string tipoDePlaga)
        {
            this.tipoDePlaga = tipoDePlaga;
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

