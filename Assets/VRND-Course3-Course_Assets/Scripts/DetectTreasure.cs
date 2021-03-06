﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTreasure : MonoBehaviour {

    public Animator openTreasureChest;

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10))
        {
            openTreasureChest.SetBool("OpenBool", true);
            print("There be treasure here!!!");
        }
        else
        {
            openTreasureChest.SetBool("OpenBool", false);
        }
    }
}
