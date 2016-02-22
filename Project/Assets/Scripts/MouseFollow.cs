using UnityEngine;
using System.Collections;

public class MouseFollow : MonoBehaviour {
	/*
	public GameObject player;
	public Vector3 zAxis;
	public Vector3 pos;

	*/
	public Vector3 mousePos;
	// Use this for initialization
	void Start () {
		//player = GameObject.Find ("BallAlien");
	}
	
	// Update is called once per frame
	void Update () {
		/*

		zAxis = player.transform.forward.normalized;
		pos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0));
		float temp = pos.z - transform.position.z;
		transform.rotation =  Quaternion.Euler(new Vector3(pos.x,pos.y,zAxis.z*temp));
		*/

		//broken ass shiat 
		//fuck
		mousePos = Input.mousePosition;
		Vector3 target = new Vector3 (mousePos.x,mousePos.y, 0);
		//new try
		transform.RotateAround (target, Vector3.up, 10 * Time.deltaTime);	}
}
