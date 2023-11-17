using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleveriumMaterial : ItemMaterial
{
    public override string MaterialName
    {
        get { return "Maleverium"; }
    }
    public override int MaterialDamageRange
    {
        get { return 15; }
    }
}
