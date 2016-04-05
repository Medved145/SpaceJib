using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    
    public GameObject PlayerShip;
    float inputX;
    float inputY;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        inputX += Input.GetAxis("Mouse X");
        inputY += Input.GetAxis("Mouse Y");
        Vector3 Position = new Vector3(inputX, inputY, 0);
        //Vector3 shipPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //transform.position += shipPosition * Time.deltaTime;
        PlayerShip.transform.position = Position;//3.5f;
        //Debug.Log(Input.mousePosition);
    }
}
