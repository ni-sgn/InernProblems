using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{

    public class CustomHashTable<TKey, TValue>
    {
        private LinkedList<Tuple<TKey, TValue>>[] _items;
        private int _fillFactor = 3;
        private int _size;

        public CustomHashTable()
        {
            _items = new LinkedList<Tuple<TKey, TValue>>[4];
        }



        private int GetPosition(TKey key, int length)
        {
            var hash = key.GetHashCode();
            var pos = Math.Abs(hash % length);
            return pos;
        }


        private void GrowAndReHash()
        {
            _fillFactor *= 2;
            var newItems = new LinkedList<Tuple<TKey, TValue>>[_items.Length * 2];
            foreach (var item in _items.Where(x => x != null))
            {
                foreach (var value in item)
                {
                    var pos = GetPosition(value.Item1, newItems.Length);
                    if (newItems[pos] == null)
                    {
                        newItems[pos] = new LinkedList<Tuple<TKey, TValue>>();
                    }
                    newItems[pos].AddFirst(new Tuple<TKey, TValue>(value.Item1, value.Item2));
                }
            }
            _items = newItems;
        }

        private bool NeedToGrow()
        {
            return _size >= _fillFactor;
        }

        public TValue Get(TKey key)
        {
            var pos = GetPosition(key, _items.Length);
            foreach (var item in _items[pos].Where(item => item.Item1.Equals(key)))
            {
                return item.Item2;
            }
            throw new Exception("Araswori gasagebi");
        }



        public void Add(TKey key, TValue value)
        {
            var pos = GetPosition(key, _items.Length);
            if (_items[pos] == null)
            {
                _items[pos] = new LinkedList<Tuple<TKey, TValue>>();
            }
            if (_items[pos].Any(x => x.Item1.Equals(key)))
            {
                throw new Exception("Elementi aseti gasagebit ukve arseBooBs");
            }


            _size++;
            if (NeedToGrow())
            {
                GrowAndReHash();
            }
            pos = GetPosition(key, _items.Length);
            if (_items[pos] == null)
            {
                _items[pos] = new LinkedList<Tuple<TKey, TValue>>();
            }
            _items[pos].AddFirst(new Tuple<TKey, TValue>(key, value));
        }

        public void Remove(TKey key)
        {
            var pos = GetPosition(key, _items.Length);
            if (_items[pos] != null)
            {
                var objToRemove = _items[pos].FirstOrDefault(item => item.Item1.Equals(key));
                if (objToRemove == null) return;
                _items[pos].Remove(objToRemove);
                _size--;
            }
            else
            {
                throw new Exception("Mnishvneloba ver moidzebna");
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            CustomHashTable<string, string> what = new CustomHashTable<string, string> { };
            what.Add("Gulis", "Vardo");
            Console.WriteLine(what.Get("Gulis"));
            what.Remove("Gulis");
        }
    }
}
