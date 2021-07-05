using sistema_financeiro.formulario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_financeiro
{
   public class MDISingleton
    {
        private MDISingleton()
        {

        }

        private static MDI instancia;

        public static MDI InstanciaMDI()
        {
            {
                if (instancia == null)
                {
                    instancia = new MDI();
                    return instancia;
                }
                return instancia;

            }
        }
    }
}
