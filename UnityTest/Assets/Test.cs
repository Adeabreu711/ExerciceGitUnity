using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int dog;

    void Start()
    {
        dog = 403;
    }

    // Update is called once per frame
    void Update()
    {
        if (dog == 403)
        {
            Debug.Log("WHICH BOOMBOCLAT DOG AM I ?");
        } 
    }
}
