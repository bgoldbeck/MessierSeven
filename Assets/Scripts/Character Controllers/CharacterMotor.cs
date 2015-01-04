using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class CharacterMotor : MonoBehaviour {
	[Range(1f, 20f)]
	public float speed = 7f;
	[Range(1f, 20f)]
	public float strafeSpeed = 7f;
	[Range(-20f, 20f)]
	public float gravity = 9.81f;
	
	private CharacterController characterController;

	void Awake() {
		characterController = GetComponent<CharacterController>();
	}

	void Start() {
	}

	void Update() {
		//Our charater's forward motion.
		Vector3 velocity = Vector3.forward * Input.GetAxis("Vertical")   * speed;
		//Our charater's stafing motion.
		velocity        += Vector3.right   * Input.GetAxis("Horizontal") * strafeSpeed;


		velocity = new Vector3(velocity.x, -gravity, velocity.z);
		characterController.Move(velocity * Time.deltaTime);

	


	}
}
