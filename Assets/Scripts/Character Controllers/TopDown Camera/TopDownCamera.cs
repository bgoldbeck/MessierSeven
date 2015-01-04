using UnityEngine;
using System.Collections;

public class TopDownCamera : MonoBehaviour {
	public Transform lookAtTarget;

	public float defaultDistance           = 7f;
	public float minimumDistanceFromTarget = 3f;
	public float maximumDistanceFromTarget = 15f;

	private float currentDistanceFromTarget;
	private Vector2 currentMousePosition;
	
	
	void Awake() {
	}
	
	void Start() {
		currentDistanceFromTarget = defaultDistance;
		currentDistanceFromTarget = Mathf.Clamp(currentDistanceFromTarget, 
		                                        minimumDistanceFromTarget, 
		                                        maximumDistanceFromTarget );
		
		Camera.main.transform.localPosition = new Vector3(lookAtTarget.transform.localPosition.x, 
		                                                  lookAtTarget.transform.localPosition.y + defaultDistance, 
		                                                  lookAtTarget.transform.localPosition.z - 3f);
	}
	
	void LateUpdate() {
		//We must figure out if our target we are looking at has moved and calculate what our
		//new position should be.
		
		Camera.main.transform.LookAt(lookAtTarget);
		//Update Position.
	}


}
