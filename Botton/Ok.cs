using System;

namespace Botoes
{
    class Ok : Botao
    {
        public Ok()
        {
            base.rotulo = "Ok";
            Estado = true;
        }
        public override void Click()
        {
            if (Estado)
            {
                Console.WriteLine("Calculando!");
            }
        }
    }
}
