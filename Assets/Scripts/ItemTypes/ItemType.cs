using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemType", menuName = "ItemTypes/New ItemType")]
public class ItemType : ScriptableObject
{
    [SerializeField] private string itemTypeName;
    public virtual string ItemTypeName 
    {
        get { return itemTypeName; }
    }
    [SerializeField] private float itemTypeWeight;
    public virtual float ItemTypeWeight 
    {
        get { return itemTypeWeight; }
        set { itemTypeWeight = value; }
    }
    [SerializeField] private float itemTypeValue;
    public virtual float ItemTypeValue 
    {
        get { return itemTypeValue; }
        set { itemTypeValue = value; }
    }
    [SerializeField] private int baseMaterialCost;
    public virtual float BaseMaterialCost 
    {
        get { return baseMaterialCost; }
    }
    private int itemTypeDamage;
    public int ItemTypeDamage
    {
        get { return itemTypeDamage; }
        set { itemTypeDamage = value; }
    }
    private ItemMaterial baseMaterial;
    public ItemMaterial BaseMaterial
    {
        get { return baseMaterial; }
        set { baseMaterial = value; }
    }

    private const string itemTypeError0 = "BaseMaterial is not set in ItemType.";

    public int CalculateTotalDamage()
    {
        if (baseMaterial != null)
        {
            return baseMaterial.MaterialDamage * baseMaterialCost;
        }
        else
        {
            Debug.LogError(String.Format($"{itemTypeError0}"));
            return 0;
        }
    }

    public float CalculateValue()
    {
        if (baseMaterial != null)
        {
            return baseMaterial.MaterialValue * baseMaterialCost; 
        }
        else
        {
            Debug.LogError(String.Format($"{itemTypeError0}"));
            return 0f;
        }
    }
}
