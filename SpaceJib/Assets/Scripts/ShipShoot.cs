using UnityEngine;
using System.Collections;

public class ShipShoot : MonoBehaviour {

    public GameObject Shot;
    public GameObject PlayerShip;
    private bool IsShoot = false;
    public float ShootCooldawn = 0.1f;
    private float SC = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 PosRes = PlayerShip.transform.position;
        PosRes.y = PosRes.y + 0.15f;
        if (Input.GetMouseButton(0) && IsShoot == false)
        {
            //Debug.Log("Ship Shoot");
            GameObject shot = Instantiate(Shot, PosRes, Quaternion.identity) as GameObject;
            IsShoot = true;
            SC = ShootCooldawn;
        }
        if (SC > 0)
            SC -= Time.deltaTime;
        if (SC <= 0)
            IsShoot = false;
	}
}
