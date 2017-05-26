using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class Worker
    {
        protected string name;
        protected bool isknow;

        public Worker(string name)
        {
            this.name = name;
        }

        public bool Isknow
        {
            set { isknow = value; }
            get { return isknow; }
        }

        public string Name { get { return name; } }

        public abstract void Add(Worker c);
        public abstract void Remove(Worker c);
        public abstract void GetKnowledgeInfo();
        public abstract void Display(int depth);
    }

    class Composite : Worker
    {
        private List<Worker> children = new List<Worker>();

        public Composite(string name) : base(name) { }

        public void sayAboutOrder(Worker component)
        {
            component.Isknow = true;
        }

        public override void Add(Worker component)
        {
            children.Add(component);
        }

        public override void Remove(Worker component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + this.isknow.ToString());

            foreach (Worker component in children)
            {
                component.Display(depth + 2);
            }
        }

        public override void GetKnowledgeInfo()
        {
            foreach (Worker component in children)
            {
                if (!component.Isknow) Console.WriteLine("{0} don`t know about order", component.Name);
            }
        }
    }


    class SimpleWorker : Worker
    {

        public SimpleWorker(string name) : base(name) { }

        public override void Add(Worker c)
        {
            Console.WriteLine("Impossible operation");
        }

        public override void Remove(Worker c)
        {
            Console.WriteLine("Impossible operation");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + isknow.ToString());
        }

        public override void GetKnowledgeInfo()
        {
            Console.WriteLine("Worker know about order: {0}", this.isknow); 
        }
    }


}


