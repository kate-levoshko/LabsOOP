using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    // The 'AbstractFactory' abstract class
    public abstract class TypeFirm
    {
        protected double price;
        public abstract AbstractLaureatePaper CreateLaureatePaper();
        public abstract AbstractDiplomatPaper CreateDiplomatPaper();
        public abstract AbstractMemberPaper CreateMemberPaper();

        public double Price
        {
            set{ price = value;}
            get { return price; }
        }
    }

    public class PrintCenter : TypeFirm
    {
        protected int printColourAmount = 10;
        protected int paperQuality = 5;


        public override AbstractLaureatePaper CreateLaureatePaper()
        {
            return new LaureatePaper();
        }
        public override AbstractDiplomatPaper CreateDiplomatPaper()
        {
            return new DiplomatPaper();
        }
        public override AbstractMemberPaper CreateMemberPaper()
        {
            return new MemberPaper();
        }
    }

    public class ElitePrintCompany : TypeFirm
    {
        protected int printColourAmount = 17;
        protected int paperQuality = 5;

        public override AbstractLaureatePaper CreateLaureatePaper()
        {
            return new LaminatedLaureatePaper();
        }
        public override AbstractDiplomatPaper CreateDiplomatPaper()
        {
            return new LaminatedDiplomatPaper();
        }
        public override AbstractMemberPaper CreateMemberPaper()
        {
            return new LaminatedMemberPaper();
        }
    }

    public abstract class AbstractLaureatePaper
    {
        public virtual void showWinners()
        {
            Console.WriteLine(this.GetType().Name + " get pupils who won 1,2,3 places");
        }
    }

    public abstract class AbstractDiplomatPaper
    {
        public virtual void showWinners()
        {
            Console.WriteLine(this.GetType().Name + " get pupils of high school");
        }
    }

    public abstract class AbstractMemberPaper
    {
        public virtual void showWinners()
        {
            Console.WriteLine(this.GetType().Name + " get participants of contest");
        }

        public abstract void ShowInfo(AbstractDiplomatPaper amp);
    }

    public class LaureatePaper : AbstractLaureatePaper{ }


    public class DiplomatPaper : AbstractDiplomatPaper{}

    public class MemberPaper : AbstractMemberPaper
    {
        public override void ShowInfo(AbstractDiplomatPaper amp)
        {
            Console.WriteLine(this.GetType().Name + "is less qualitative than" + amp.GetType().Name);
        }
    }

    public class LaminatedLaureatePaper : AbstractLaureatePaper { }

    public class LaminatedDiplomatPaper : AbstractDiplomatPaper { }

    public class LaminatedMemberPaper : AbstractMemberPaper
    {
        public override void ShowInfo(AbstractDiplomatPaper amp)
        {
            Console.WriteLine(this.GetType().Name + "is more qualitative than" + amp.GetType().Name);
        }
    }

    public class PaperProduction
    {
        private AbstractLaureatePaper AbLaureatePaper;
        private AbstractDiplomatPaper AbDiplomatPaper;
        private AbstractMemberPaper AbMemberPaper;

        // Constructor
        public PaperProduction(TypeFirm tFirm)
        {
            AbLaureatePaper = tFirm.CreateLaureatePaper();
            AbDiplomatPaper = tFirm.CreateDiplomatPaper();
            AbMemberPaper = tFirm.CreateMemberPaper();
        }

        public void Run(TypeFirm tFirm)
        {
            Console.WriteLine("Awards was printed with the help of " + tFirm.GetType().Name);
            AbDiplomatPaper.showWinners();
            AbLaureatePaper.showWinners();
            AbMemberPaper.showWinners();
        }
    }
}

