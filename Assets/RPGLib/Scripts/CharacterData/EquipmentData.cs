using System;
using UnityEngine;

using RPGLib.ItemData;

namespace RPGLib.CharacterData
{
    [Serializable]
    public class EquipmentData
    {
        #region Field Region

        /// <summary>
        /// The primary weapon
        /// </summary>
        [SerializeField]
        WeaponData primaryWeapon;

        /// <summary>
        /// The secondary weapon or shield
        /// </summary>
        [SerializeField]
        WeaponData secondaryWeapon;

        /// <summary>
        /// The helmet or head armor
        /// </summary>
        [SerializeField]
        ArmorData head;

        /// <summary>
        /// The neck accessory
        /// </summary>
        [SerializeField]
        ArmorData neck;

        /// <summary>
        /// The body armor
        /// </summary>
        [SerializeField]
        ArmorData body;

        /// <summary>
        /// The gloves or hand armor
        /// </summary>
        [SerializeField]
        ArmorData hands;

        /// <summary>
        /// The leg armor
        /// </summary>
        [SerializeField]
        ArmorData legs;

        /// <summary>
        /// The feet armor
        /// </summary>
        [SerializeField]
        ArmorData feet;

        /// <summary>
        /// Amount of additional attack gained
        /// from equipment
        /// </summary>
        private int atkMod;

        /// <summary>
        /// Amount of additional defense gained
        /// from equipment
        /// </summary>
        private int defMod;

        /// <summary>
        /// Amount of additional evasion gained
        /// from equipment
        /// </summary>
        private int evaMod;

        /// <summary>
        /// Amount of additional defense gained
        /// from equipment
        /// </summary>
        private int accMod;

        /// <summary>
        /// Amount of additional speed gained
        /// from equipment
        /// </summary>
        private int spdMod;

        /// <summary>
        /// Amount of additional magic attack gained
        /// from equipment
        /// </summary>
        private int magAtkMod;

        /// <summary>
        /// Amount of additional speed gained
        /// from equipment
        /// </summary>
        private int magDefMod;

        /// <summary>
        /// Teh equipment changed event
        /// </summary>
        private Event EquipmentChanged;

        /// <summary>
        /// The OnEquipmentChanged Handler
        /// </summary>
        public EventHandler OnEquipmentChanged;

        PlayerCharacterData player;

        #endregion

        #region Property Region

        /// <summary>
        /// Gets or sets the primary weapon
        /// </summary>
        public WeaponData PrimaryWeapon
        {
            get { return this.primaryWeapon; }
            set
            {
                this.primaryWeapon = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        /// <summary>
        /// Gets or sets the secondary weapon
        /// </summary>
        public WeaponData SecondaryWeapon
        {
            get { return this.secondaryWeapon; }
            set
            {
                this.secondaryWeapon = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        /// <summary>
        /// Gets or sets the head armor
        /// </summary>
        public ArmorData Head
        {
            get { return this.head; }
            set
            {
                this.head = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        /// <summary>
        /// Gets or sets the neck accessory
        /// </summary>
        public ArmorData Neck
        {
            get { return this.neck; }
            set
            {
                this.neck = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        /// <summary>
        /// Gets or sets the body armor
        /// </summary>
        public ArmorData Body
        {
            get { return this.body; }
            set
            {
                this.body = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        /// <summary>
        /// Gets or sets the hands armor
        /// </summary>
        public ArmorData Hands
        {
            get { return this.hands; }
            set
            {
                this.hands = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        /// <summary>
        /// Gets or sets the legs armor
        /// </summary>
        public ArmorData Legs
        {
            get { return this.legs; }
            set
            {
                this.legs = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        /// <summary>
        /// Gets or sets the feet armor
        /// </summary>
        public ArmorData Feet
        {
            get { return this.feet; }
            set
            {
                this.feet = value;
                this.OnEquipmentChanged.Invoke(this, null);
            }
        }

        #endregion

        #region Constructor Region

        public EquipmentData()
        {
            this.OnEquipmentChanged += new EventHandler(this.CalculateModifiers);
        }

        #endregion

        #region Method Region

        private void CalculateModifiers(object sender, EventArgs args)
        {

        }

        #endregion
    }
}
