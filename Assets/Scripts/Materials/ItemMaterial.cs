using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMaterial : ScriptableObject
{
    public virtual string MaterialName
    {
        get { return "Empty"; }
    }
    public virtual int MaterialDamageRange
    {
        get { return 0; }
    }
}
