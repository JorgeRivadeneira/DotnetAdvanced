using System.Collections.ObjectModel;

namespace SOLID.SingleResponsability
{
    public class FakeStorage<T>
    {
        private ObservableCollection<T> collection;

        public FakeStorage()
        {
            collection = new ObservableCollection<T>();
        }

        public T Add(T item)
        {
            collection.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            collection.Remove(item);
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return collection;
        }
    }
}