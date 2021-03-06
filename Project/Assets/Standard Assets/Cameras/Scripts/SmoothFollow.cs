using UnityEngine;
using System.Collections;
/*
//This camera smoothes out rotation around the y-axis and height.
//Horizontal Distance to the target is always fixed.
//For every of those smoothed values we calculate the wanted value and the current value.
//Then we smooth it using the Lerp function.
//Then we apply the smoothed values to the transform's position.
*/
public class SmoothFollow : MonoBehaviour 
{
	public Transform target;
	public float distance = 100.0f;
	public float height = 105.0f;
	public float heightDamping = 4.0f;
	public float positionDamping = 4.0f;
	public float rotationDamping = 4.0f;
		
	// Update is called once per frame
	void LateUpdate ()
	{
		// Early out if we don't have a target
		if (!target)
			return;
		
		float dt = Time.deltaTime;
		float wantedHeight = target.position.y + height;
		float currentHeight = target.position.y + height;
		// Damp the height
		//currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * dt);

		// Set the position of the camera 
		Vector3 wantedPosition = target.position + target.right * distance;
		transform.position = Vector3.Lerp (transform.position, wantedPosition, positionDamping * dt);
	
		// adjust the height of the camera
		transform.position = new Vector3 (transform.position.x, currentHeight, transform.position.z);

		
		// look at the target

		transform.forward = Vector3.Lerp (transform.forward, (target.position - transform.position) + new Vector3(0,height,0), rotationDamping * dt);

		}
}