using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using LearnIoc.Autofac.Interfaces;
using LearnIoc.Autofac.implementation;

namespace LearnIoc.Autofac
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            Container = builder.Build();


            #region 直接使用Container.Resolve创建对象的话,会是内存释放不及时,不建议这么用
            //IDateWriter dateWrite = Container.Resolve<IDateWriter>();
            //dateWrite.WriteDate(); 
            #endregion

            WriteDate();


            Console.ReadKey();
        }

        private static void WriteDate()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = Container.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}
