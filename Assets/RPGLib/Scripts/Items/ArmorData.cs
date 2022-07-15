using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGLib.ItemData
{
    [CreateAssetMenu(fileName = "New Armor", menuName = "Items/Armor")]
    public class ArmorData : BaseItemData
    {
        #region Field Region

        /// <summary>
        /// Gets the defense value for the armor
        /// </summary>
        public int DefenseMod;

        #endregion

        #region Property Region

        /// <summary>
        /// Gets the item's type
        /// </summary>
        public override ItemType ItemType => this._itemType;

        #endregion

        #region Constructor Region

        /// <summary>
        /// Default empty constructor that sets
        /// the item's type
        /// </summary>
        public ArmorData()
            : base(ItemType.ARMOR) { }

        #endregion
    }
}
