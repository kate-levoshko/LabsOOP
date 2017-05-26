using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    // Using "Clean code" rule 
    //“Читание кода сверху вниз”, “Метод меньшего масштаба - ниже”
    // Форматирование отступов
    class CatList<T> : IDisposable where T : Cat
    {
        public List<Cat> wrList; // список слабких посилань
        bool disposed = false;

        public CatList()
        {
            wrList = new List<Cat>();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                wrList.Clear();
                wrList = null;
            }
            Console.WriteLine("Cat list disposed");
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void AddToWeakRefList(Cat elem)
        {
            wrList.Add(elem); 
        }
    }
}
