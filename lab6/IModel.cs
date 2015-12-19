using System.Collections;
namespace lab6
{
    public interface IModel:IEnumerable
    {
        int Count
        { get; }
        void Add(int value);
        void Heapify(int i);
        void DeleteAt(int index);
        void RemoveMax();
        void RemoveMin();
        void RemoveAll();
        ThingElement this[int i]
        {
            get;
            set;            
        }
    }
}
