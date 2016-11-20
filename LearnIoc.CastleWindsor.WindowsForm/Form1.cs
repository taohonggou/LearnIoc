using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace LearnIoc.CastleWindsor.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary.IDependencyOne>().ImplementedBy<ClassLibrary.DependencyOne>());
            container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary.IDependencyTwo>().ImplementedBy<ClassLibrary.DependencyTwo>());
            container.Register(Castle.MicroKernel.Registration.Component.For<LearnIoc.CastleWindsor.ClassLibrary.Main>());
            

            var main = container.Resolve<ClassLibrary.Main>();
            main.DoSomeThing();

        }
    }
}
