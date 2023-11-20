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
        set { materialName = value; }
    }
    [SerializeField] private int materialDamageRange;
    public virtual int MaterialDamageRange
    {
        get { return materialDamageRange; }
        set { materialDamageRange = value; }
    }
}
