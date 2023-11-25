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
    }
    [SerializeField] private int materialArmour;
    public virtual int MaterialArmour
    {
        get { return materialArmour; }
    }
    [SerializeField] private float materialWeight;
    public float MaterialWeight
    {
        get { return materialWeight; }
    }
    [SerializeField] private float materialValue;
    public virtual float MaterialValue
    {
        get { return materialValue; }
    }
}
