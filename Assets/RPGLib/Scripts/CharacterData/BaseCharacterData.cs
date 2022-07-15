using System;
using UnityEngine;

namespace RPGLib.CharacterData
{
    [Serializable]
    public class BaseCharacterData
    {
        #region Field Region

        /// <summary>
        /// The character's name
        /// </summary>
        [SerializeField]
        public string Name { get; set; }

        /// <summary>
        /// The character's description
        /// </summary>
        [SerializeField]
        public string Description { get; set; }

        /// <summary>
        /// The character's current hit points
        /// </summary>
        [SerializeField]
        protected int currentHp;

        /// <summary>
        /// The character's current magic points
        /// </summary>
        [SerializeField]
        protected int currentMp;

        /// <summary>
        /// The character's level
        /// </summary>
        [SerializeField]
        protected int level;

        #endregion

        #region Property Region

        /// <summary>
        /// Gets the character's max hit points
        /// </summary>
        public virtual int MaxHp
        {
            get { return 9999; }
        }

        /// <summary>
        /// Gets or sets the character's current hit points
        /// </summary>
        public int CurrentHp
        {
            get { return this.currentHp; }
            set { this.currentHp = Math.Clamp(value, 0, this.MaxHp); }
        }

        /// <summary>
        /// Gets or sets the character's max magic points
        /// </summary>
        public virtual int MaxMp
        {
            get { return 999; }
        }

        /// <summary>
        /// Gets or sets the character's current magic points
        /// </summary>
        public int CurrentMp
        {
            get { return this.currentMp; }
            set { this.currentMp = Math.Clamp(value, 0, this.MaxMp); }
        }

        /// <summary>
        /// Gets or sets the character's current level
        /// </summary>
        public virtual int Level
        {
            get { return this.level; }
            set { this.level = Math.Clamp(value, 1, 99); }
        }

        #endregion

        #region Constructor Region

        /// <summary>
        /// Default empty constructor
        /// </summary>
        public BaseCharacterData() { }

        #endregion
    }
}
