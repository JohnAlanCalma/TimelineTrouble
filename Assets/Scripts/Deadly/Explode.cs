﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Deadly" || target.gameObject.tag == "Finish")
        {
            OnExplode();

        }
    }

    void OnExplode()
    {
        Destroy(gameObject);
    }

}
