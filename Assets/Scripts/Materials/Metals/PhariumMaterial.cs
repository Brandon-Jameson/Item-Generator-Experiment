using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhariumMaterial : ItemMaterial
{
    public override string MaterialName
    {
        get { return "Pharium"; }
    }
    public override int MaterialDamageRange
    {
        get { return 14; }
    }
}
