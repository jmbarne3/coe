using System;
using System.Linq;
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

        /// <summary>
        /// Gets all the equipment for ease of
        /// access.
        /// </summary>
        private BaseItemData[] AllEquipment
        {
            get
            {
                return new BaseItemData[] {
                    primaryWeapon,
                    secondaryWeapon,
                    head,
                    neck,
                    body,
                    hands,
                    legs,
                    feet
                };
            }
        }

        /// <summary>
        /// Gets the attack modifier
        /// </summary>
        public int AttackModifier => this.atkMod;

        /// <summary>
        /// Gets the defense modifier
        /// </summary>
        public int DefenseModifier => this.defMod;

        /// <summary>
        /// Gets the accuracy modifier
        /// </summary>
        public int AccuracyModifier => this.accMod;

        /// <summary>
        /// Gets the evasion modifier
        /// </summary>
        public int EvasionModifier => this.evaMod;

        /// <summary>
        /// Gets the speed modifier
        /// </summary>
        public int SpeedModifier => this.spdMod;

        /// <summary>
        /// Gets the magic attack modifier
        /// </summary>
        public int MagicAttackModifier => this.magAtkMod;

        /// <summary>
        /// Gets the magic defense modifier
        /// </summary>
        public int MagicDefenseModifier => this.magDefMod;
        
        #endregion

        #region Constructor Region

        public EquipmentData()
        {
            this.OnEquipmentChanged += new EventHandler(this.OnEquipmentChangedDefault);
            this.ResetModifiers();
            this.CalculateModifiers();
        }

        #endregion

        #region Method Region

        /// <summary>
        /// Default event handler for OnEquipmentChanged
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The event args</param>
        private void OnEquipmentChangedDefault(object sender, EventArgs args)
        {
            this.ResetModifiers();
            this.CalculateModifiers();
        }

        /// <summary>
        /// Calculates the stat modifiers for all the equipment
        /// </summary>
        /// <param name="sender">The sender of the even args</param>
        /// <param name="args"></param>
        private void CalculateModifiers()
        {
            // Loop through all items that are equipped
            foreach(BaseItemData item in this.AllEquipment.Where(x => x is not null))
            {
                if (item.ItemType == ItemType.WEAPON)
                {
                    WeaponData weapon = (WeaponData)item;
                    this.atkMod += weapon.AttackMod;
                } else if (item.ItemType == ItemType.ARMOR)
                {
                    ArmorData armor = (ArmorData)item;
                    this.defMod += armor.DefenseMod;
                }
            }
        }

        /// <summary>
        /// Resets all of the modifiers in preparation
        /// of a recalculation.
        /// </summary>
        private void ResetModifiers()
        {
            this.atkMod = 0;
            this.defMod = 0;
            this.evaMod = 0;
            this.accMod = 0;
            this.spdMod = 0;
            this.magAtkMod = 0;
            this.magDefMod = 0;
        }

        #endregion
    }
}
