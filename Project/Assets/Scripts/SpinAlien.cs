using UnityEngine;
using System.Collections;

public class SpinAlien : MonoBehaviour {

	private float spinRate = 60.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (transform.right, spinRate * Time.deltaTime);
	}
}
