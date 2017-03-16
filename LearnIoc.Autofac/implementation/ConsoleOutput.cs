using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnIoc.Autofac.Interfaces;

namespace LearnIoc.Autofac.implementation
{
    public class ConsoleOutput :  IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }

        private Guid _guid;

        public ConsoleOutput()
        {
            _guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return _guid.ToString();
        }
    }
}
