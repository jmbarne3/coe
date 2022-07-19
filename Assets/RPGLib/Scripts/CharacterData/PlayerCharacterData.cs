using System;

using UnityEngine;

namespace RPGLib.CharacterData
{
    [Serializable]
    public class PlayerCharacterData : BaseCharacterData
    {
        #region Field Region

        /// <summary>
        /// The player's equipment
        /// </summary>
        public EquipmentData Equipment;

        #endregion

        #region Property Region

        /// <summary>
        /// The player's attack
        /// </summary>
        public override int Attack
        {
            get { return base.Attack + Equipment.AttackModifier; }
        }

        /// <summary>
        /// The player's defense
        /// </summary>
        public override int Defense
        {
            get { return base.Defense + Equipment.DefenseModifier; }
        }

        /// <summary>
        /// The player's accuracy
        /// </summary>
        public override int Accuracy
        {
            get { return base.Accuracy + Equipment.AccuracyModifier; }
        }

        /// <summary>
        /// The player's evasion
        /// </summary>
        public override int Evasion
        {
            get { return base.Evasion + Equipment.EvasionModifier; }
        }

        /// <summary>
        /// The player's speed
        /// </summary>
        public override int Speed
        {
            get { return base.Speed + Equipment.SpeedModifier; }
        }

        /// <summary>
        /// The player's magic attack
        /// </summary>
        public override int MagicAttack
        {
            get { return base.MagicAttack + Equipment.MagicAttackModifier; }
        }

        /// <summary>
        /// The player's magic defense
        /// </summary>
        public override int MagicDefense
        {
            get { return base.MagicDefense + Equipment.MagicDefenseModifier; }
        }

        #endregion

        #region Constructor Region

        /// <summary>
        /// Default empty constructor
        /// </summary>
        public PlayerCharacterData() { }

        #endregion
    }
}