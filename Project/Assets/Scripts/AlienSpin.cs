using UnityEngine;
using System.Collections;

public class AlienSpin : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.Play ("Take 001", 0);
	}
}
