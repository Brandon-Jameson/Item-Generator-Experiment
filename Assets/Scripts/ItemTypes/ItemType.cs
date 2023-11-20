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
        set { itemTypeName = value; }
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
    [SerializeField] private float itemTypeProtection;
    public virtual float ItemTypeProtection
    {
        get { return itemTypeProtection; }
        set { itemTypeProtection = value; }
    }
    [SerializeField] private float itemTypeDamage;
    public virtual float ItemTypeDamage
    {
        get { return itemTypeDamage; }
        set { itemTypeDamage = value;}
    }
}
