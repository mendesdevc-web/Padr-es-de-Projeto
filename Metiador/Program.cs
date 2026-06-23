using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookMediator =
                new FacebookGroupMediator();

            User macoratti = new ConcreteUser(facebookMediator, "Macoratti");
            User mendes = new ConcreteUser(facebookMediator, "Mendes");
            User rosa = new ConcreteUser(facebookMediator, "Rosa");
            User santos = new ConcreteUser(facebookMediator, "Santos");

            facebookMediator.RegisterUser(macoratti);
            facebookMediator.RegisterUser(mendes);
            facebookMediator.RegisterUser(rosa);
            facebookMediator.RegisterUser(santos);

            macoratti.Send(" O canal macoratti" + 
                "Esta apresenta uma seria sobre padroes de projetos ");

            mendes.Send("Onde posso encontrar os videos ?");

            macoratti.Send("Veja a playlist Design Patterns'");

            Console.Read();
        }
    }
}
