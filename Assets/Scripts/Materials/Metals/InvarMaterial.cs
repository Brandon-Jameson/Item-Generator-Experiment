using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvarMaterial : ItemMaterial
{
    public override string MaterialName
    {
        get { return "Invar"; }
    }
    public override int MaterialDamageRange
    {
        get { return 9; }
    }
}
