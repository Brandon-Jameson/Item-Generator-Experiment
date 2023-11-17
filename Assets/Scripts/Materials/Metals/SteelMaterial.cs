using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelMaterial : ItemMaterial
{
    public override string MaterialName
    {
        get { return "Steel"; }
    }
    public override int MaterialDamageRange
    {
        get { return 7; }
    }
}
