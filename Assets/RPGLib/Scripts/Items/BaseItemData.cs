using System;
using UnityEngine;

namespace RPGLib.ItemData
{
    public class BaseItemData : ScriptableObject
    {
        #region Field Region

        /// <summary>
        /// The item's name
        /// </summary>
        public string Name;

        /// <summary>
        /// The item's description
        /// </summary>
        public string Description;

        /// <summary>
        /// The items' icon
        /// </summary>
        public Sprite Icon;

        /// <summary>
        /// The cost of the item
        /// </summary>
        public int Cost;

        [SerializeField]
        protected ItemType _itemType = ItemData.ItemType.UNDEFINED;

        #endregion

        #region Property Region

        [SerializeField]
        public virtual ItemType ItemType
        {
            get { return this._itemType; }
        }

        #endregion

        #region Constructor Region

        /// <summary>
        /// Default empty constructor
        /// </summary>
        public BaseItemData() { }

        /// <summary>
        /// Simple constructor for setting the item's type
        /// </summary>
        /// <param name="itemType">The item's type</param>
        public BaseItemData(ItemType itemType)
        {
            this._itemType = itemType;
        }

        #endregion
    }
}