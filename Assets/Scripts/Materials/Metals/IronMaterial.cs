using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMaterial : ItemMaterial
{
    public override string MaterialName
    {
        get { return "Iron"; }
    }
    public override int MaterialDamageRange
    {
        get { return 6; }
    }
}
