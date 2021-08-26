using System;
using System.Collections.Generic;

namespace Lambda
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();

        delegate bool ItemSelector(Item item);

        static Item FindItem(ItemSelector selector) 
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        static Item FindItem2(MyFunc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        delegate Return MyFunc<Return>();
        delegate Return MyFunc<T, Return>(T item);
        delegate Return MyFunc<T1, T2, Return>(T1 t1, T2 t2);

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            //Lambda : 일회용 함수를 만드는데 사용하는 문법
            Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

            //Anonymous Funtion : 무명 함수 / 익명 함수
            Item item2 = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            ItemSelector selector = new ItemSelector((Item Item) => {return item.ItemType == ItemType.Weapon; });

            Item item3 = FindItem(selector);

            MyFunc<Item, bool> selector2 = (Item item) => { return item.ItemType == ItemType.Weapon; };

            Item item4 = FindItem2(selector2);

            // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재한다.
            // -> 반환 타입이 있을 경우 Func ex) Func<Item, bool> selector = (Item item) => { return item.ItemType == itemType.Weapon; };
            // -> 반화 타입이 없으면 Action
        }
    }
}
 