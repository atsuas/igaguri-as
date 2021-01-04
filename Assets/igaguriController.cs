﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igaguricontroller : MonoBehaviour
{
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        shoot(new Vector3(0, 200, 2000));
    }

}
