using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Animate : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float vertical = CrossPlatformInputManager.GetAxis("Horizontal");
		if(vertical != 0){
			gameObject.GetComponent<Animation>().Play("Take 001");
		}
	}
}
