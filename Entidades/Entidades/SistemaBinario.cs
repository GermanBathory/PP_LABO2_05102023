using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                return double.Parse(this.valor);
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this;
            }
            else
            {
                return BinarioADecimal();
            }
        }
        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char item in valor)
            {
                if (!(item == '0' || item == '1'))
                {
                    return false;
                }
            }
            return true;
        }
        protected new bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor))
            {
                return true;
            }
            return false;
        }
        public static implicit operator SistemaBinario(string valor)
        {
            return (SistemaBinario)valor;
        }
        private SistemaDecimal BinarioADecimal()
        {
            if (this.valor != msgError)
            {
                double aux;
                double.TryParse(valor, out aux);
                int resto;
                int potencia = 0;
                double acumulador = 0;

                do
                {
                    resto = (int)aux % 10;
                    aux = aux / 10;
                    aux = Math.Floor(aux);
                    acumulador += (double)(resto * Math.Pow(2, potencia));
                    potencia++;

                } while (aux != 0);

                return (SistemaDecimal)acumulador;
            }
            else
            {
                return double.MinValue;
            }
        }

    }
}
