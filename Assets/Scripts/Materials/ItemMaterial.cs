using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemMaterial", menuName = "ItemMaterials/New ItemMaterial")]
public class ItemMaterial : ScriptableObject
{
    [SerializeField] private string materialName;
    public virtual string MaterialName 
    {
        get { return materialName; }
    }
    [SerializeField] private int materialDamage;
    public virtual int MaterialDamage
    {
        get { return materialDamage; }
        set { materialDamage = value; }
    }
    [SerializeField] private float materialValue;
    public virtual float MaterialValue
    {
        get { return materialValue; }
        set { materialValue = value; }
    }
}
