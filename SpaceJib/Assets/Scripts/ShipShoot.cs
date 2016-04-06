using UnityEngine;
using System.Collections;

public class ShipShoot : MonoBehaviour {

    public GameObject Shot;
    public GameObject PlayerShip;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 PosRes = PlayerShip.transform.position;
        PosRes.y = PosRes.y + 0.15f;
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Ship Shoot");
            GameObject shot = Instantiate(Shot, PosRes, Quaternion.identity) as GameObject;
        }
	}
}
