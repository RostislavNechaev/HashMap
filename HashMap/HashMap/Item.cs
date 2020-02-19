using System;

namespace HashMap
{
    public class Item<TKye, TValue>
    {
        public TKye Key { get; set; }

        public TValue Value { get; set; }

        public Item() { }

        public Item(TKye key, TValue value)
        {
            // Проверяем входные данные на корректность.
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
