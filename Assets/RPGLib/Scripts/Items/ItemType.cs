using System;

namespace RPGLib.ItemData
{
    [Serializable]
    public enum ItemType
    {
        UNDEFINED,
        CONSUMABLE,
        WEAPON,
        ARMOR,
        ACCESSORY,
        KEY_ITEM
    }
}