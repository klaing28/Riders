﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : Fighter
{
    protected override void Death()
    {
        Destroy(gameObject);
    }

}
