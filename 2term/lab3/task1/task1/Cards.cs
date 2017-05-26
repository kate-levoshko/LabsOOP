using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace task1
{
    // The 'Prototype' abstract class
    public abstract class Mast
    {
        protected string mast_name;
        protected string rang;

        public Mast(string mName)
        {
            this.mast_name = mName;
        }

        public virtual Mast Clone()
        {
            return (Mast)this.MemberwiseClone();
        }

        public virtual void setRang(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("Incorrect value of name");
            }
            else { rang = value; }
        }

        public virtual string getRang()
        {
            return rang;
        }

        public virtual string Name
        {
            get { return mast_name; }
        }
    }


    public class Krest : Mast
    {
        const string name = "Krest";
       
        public Krest() : base(name){}
    }

    public class Pika : Mast
    {
        const string name = "Pika";

        public Pika() : base(name){ }
    }

    public class Chirva : Mast
    {
        const string name = "Chirva";

        public Chirva() : base(name){ }

    }

    public class Bubna : Mast
    {
        const string name = "Bubna";

        public Bubna() : base(name){ }

    }
    // 'Singleton' used
    public static class Koloda
    {
        private static readonly Krest krestPrototype;
        private static readonly Pika pikaPrototype;
        private static readonly Bubna bubnaPrototype;
        private static readonly Chirva chirvaPrototype;

        static Koloda()
        {
            krestPrototype = new Krest();
            pikaPrototype = new Pika();
            bubnaPrototype = new Bubna();
            chirvaPrototype = new Chirva();
        }

        public static Krest CreateKrest()
        {
            return (Krest)krestPrototype.Clone();
        }

        public static Pika CreatePika()
        {
            return (Pika)pikaPrototype.Clone();
        }

        public static Bubna CreateBubna()
        {
            return (Bubna)bubnaPrototype.Clone();
        }

        public static Chirva CreateChirva()
        {
            return (Chirva)chirvaPrototype.Clone();
        }
    }

}



