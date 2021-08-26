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

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            //Lambda : 일회용 함수를 만드는데 사용하는 문법
            Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

            //Anonymous Funtion : 무명 함수 / 익명 함수
            Item item2 = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon;});
        }
    }
}
