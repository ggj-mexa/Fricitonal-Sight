using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers 
{
    public static float MapRangeF(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
    public static int MapRangeI(float value, float from1, float to1, float from2, float to2)
    {
        return (int)((value - from1) / (to1 - from1) * (to2 - from2) + from2);
    }
}
