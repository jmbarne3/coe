using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGLib.ItemData
{
    [CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapon")]
    public class WeaponData : BaseItemData
    {
        #region Field Region

        /// <summary>
        /// The weapon's attack value
        /// </summary>
        public int AttackMod;

        #endregion

        #region Property Region

        /// <summary>
        /// The item's type
        /// </summary>
        public override ItemType ItemType => this._itemType;

        #endregion

        #region Constructor Region

        /// <summary>
        /// Empty constructor that sets the
        /// item's type
        /// </summary>
        public WeaponData()
            : base(ItemType.WEAPON) { }

        #endregion
    }
}