using System;
using System.Collections.Generic;
using System.Text;
using POO2.Commons;

namespace POO2.General
{
    public class Automovel : Veiculo
    {
        private IConsoleTools _consoleTools = new ConsoleTools();

        public Automovel(string tipo) : base(tipo)
        {
        }

        public override void Mover()
        {
            _consoleTools.Escrever("Acelerando o automóvel");
        }

        public override void Parar()
        {
            _consoleTools.Escrever("Estou parando o automóvel");
        }
    }
}
