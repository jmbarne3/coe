using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGLib.ItemData
{
    [CreateAssetMenu(fileName = "Consumable", menuName = "Items/Consumable")]
    public class ConsumableItemData : BaseItemData
    {
        #region Field Region



        #endregion

        #region Property Region

        /// <summary>
        /// Gets the item's type
        /// </summary>
        public override ItemType ItemType => this._itemType;

        #endregion

        #region Constructor Region

        /// <summary>
        /// Empty constructor that automatically sets
        /// the item's type
        /// </summary>
        public ConsumableItemData()
            : base(ItemType.CONSUMABLE) { }

        #endregion
    }

}