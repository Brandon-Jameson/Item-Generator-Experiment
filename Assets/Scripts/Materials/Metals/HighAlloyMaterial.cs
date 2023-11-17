using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighAlloyMaterial : ItemMaterial
{
    public override string MaterialName
    {
        get { return "High-Alloy"; }
    }
    public override int MaterialDamageRange
    {
        get { return 11; }
    }
}
