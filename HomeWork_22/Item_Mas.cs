namespace HomeWork_22
{
    class Item_Mas
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }

        public static List<Item_Mast> GetItemMast()
        {
            List<Item_Mast> itemlist = new List<Item_Mast>();
            itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
            itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
            itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
            itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
            itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
            itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });
            return itemlist;
        }
    }

}
