using UnityEngine;
using System.Collections;

public class ShotLive : MonoBehaviour {

    public GameObject Shot;
    public float ShotSpeed = 10.0f;
    public float Destroy = 3.0f;
    Vector3 Movement;
	// Use this for initialization
	void Start () {
        Movement = new Vector3(0,1,0);
        //Movement.x += 1;
	}
	
	// Update is called once per frame
	void Update () {
        Shot.transform.position += Movement * Time.deltaTime * ShotSpeed;
        if (Destroy > 0)
        {
            Destroy -= Time.deltaTime;
        }
        if (Destroy <= 0)
           GameObject.Destroy(Shot);     
	}
}
