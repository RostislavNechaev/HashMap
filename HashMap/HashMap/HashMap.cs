using System;
using System.Collections.Generic;
using System.Linq;

namespace HashMap
{
    public class HashMap<TKey, TValue>
    {
        private List<Item<TKey, TValue>> Items = new List<Item<TKey, TValue>>();

        public int Count => Items.Count;

        public IReadOnlyList<TKey> Keys => (IReadOnlyList<TKey>)Items.Select(i => i.Key).ToList();

        public void Add(Item<TKey, TValue> item)
        {
            
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (Items.Any(i => i.Key.Equals(item.Key)))
            {
                throw new ArgumentException($"Словарь уже содержит значение с ключом {item.Key}.", nameof(item));
            }

            Items.Add(item);
        }
                
        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (Items.Any(i => i.Key.Equals(key)))
            {
                throw new ArgumentException($"Словарь уже содержит значение с ключом {key}.", nameof(key));
            }
            var item = new Item<TKey, TValue>()
            {
                Key = key,
                Value = value
            };
            Items.Add(item);
        }

        public void Remove(TKey key)
        {
           
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var item = Items.SingleOrDefault(i => i.Key.Equals(key));

            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public void Update(TKey key, TValue newValue)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (newValue == null)
            {
                throw new ArgumentNullException(nameof(newValue));
            }

            if (!Items.Any(i => i.Key.Equals(key)))
            {
                throw new ArgumentException($"Словарь не содержит значение с ключом {key}.", nameof(key));
            }

            var item = Items.SingleOrDefault(i => i.Key.Equals(key));

            if (item != null)
            {
                item.Value = newValue;
            }
        }

        public TValue Get(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var item = Items.SingleOrDefault(i => i.Key.Equals(key)) ??
                throw new ArgumentException($"Словарь не содержит значение с ключом {key}.", nameof(key));

            return item.Value;
        }
    }
}
