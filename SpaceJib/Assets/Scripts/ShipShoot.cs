﻿using UnityEngine;
using System.Collections;

public class ShipShoot : MonoBehaviour {

    public GameObject shot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Ship Shoot");
	}
}
