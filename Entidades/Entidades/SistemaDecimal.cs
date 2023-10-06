using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
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
            if (sistema == ESistema.Decimal)
            {
                return this;
            }
            else
            {
                return DecimalABinario();
            }
        }
        protected new bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor))
            {
                return true;
            }
            return false;
        }
        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double numero);
        }
        private SistemaBinario DecimalABinario()
        {
            if (int.TryParse(this.valor, out int numero))
            {
                string retornoDecimalBinario = string.Empty;

                do
                {
                    retornoDecimalBinario = (numero % 2) + retornoDecimalBinario;
                    numero /= 2;
                }
                while (numero >= 2);
                retornoDecimalBinario = numero + retornoDecimalBinario;

                return retornoDecimalBinario;
            }
            else
            {
                return msgError;
            }
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return (SistemaDecimal)valor;
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            return (SistemaDecimal)valor;
        }

    }
}
