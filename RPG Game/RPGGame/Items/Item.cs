﻿
namespace RPGGame.Items
{
    public abstract class Item : GameObject
    {
        public Item(Position position, char itemSymbol) : base(position, itemSymbol)
        {
            this.ItemState = ItemState.Available;
        }
        public ItemState ItemState { get; set; }
    }
}
