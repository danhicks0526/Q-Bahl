using UnityEngine;
using System.Collections;

public class GunRotation : MonoBehaviour {

	//values that will be set in the Inspector
	public Vector3 mousePos;
	public Vector3 targetRotation;

	void Start(){
	
	}


	// Update is called once per frame
	void Update()
	{
		mousePos = Input.mousePosition;
		mousePos = new Vector3 (mousePos.x, mousePos.y, mousePos.z);
		transform.LookAt (mousePos);
	}  
}