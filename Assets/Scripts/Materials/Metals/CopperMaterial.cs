using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperMaterial : ItemMaterial
{
    public override string MaterialName
    {
        get { return "Copper"; }
    }
    public override int MaterialDamageRange
    {
        get { return 4; }
    }
}
