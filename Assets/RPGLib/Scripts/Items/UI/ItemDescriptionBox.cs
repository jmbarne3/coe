using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using RPGLib.ItemData;

public class ItemDescriptionBox : MonoBehaviour
{
    [SerializeField]
    private BaseItemData _itemData;

    public Image ItemIcon;
    public TMP_Text ItemName;
    public TMP_Text ItemDesc;
    public event Action ItemChanged;

    private void Awake()
    {
        this.ItemChanged += UpdateItemDescription;
        this.UpdateItemDescription();
    }

    public BaseItemData ItemData
    {
        get { return this._itemData; }
        set
        {
            this._itemData = value;
            ItemChanged();

        }
    }

    void UpdateItemDescription()
    {
        if (this.ItemData == null)
        {
            this.ItemIcon.enabled = false;
            this.ItemName.enabled = false;
            this.ItemDesc.enabled = false;
        }
        else
        {
            this.ItemIcon.enabled = true;
            this.ItemName.enabled = true;
            this.ItemDesc.enabled = true;
            this.ItemIcon.sprite = ItemData.Icon;
            this.ItemName.text = ItemData.Name;
            this.ItemDesc.text = ItemData.Description;
        }
    }
}
