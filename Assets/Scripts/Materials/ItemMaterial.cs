using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemMaterial : MonoBehaviour
{
    public abstract string MaterialName
    {
        get;
    }
    public abstract int MaterialDamageRange
    {
        get;
    }
}
