/*
 * This script is used for Main Camera to rotate.
 * Target: an object/point that will be used to orbit about, to be linked with Center Focus in the Unity
*/
using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class CameraController : MonoBehaviour {

	public Transform target;
	public float distance = 200.0f;
	public float xSpeed = 0.02f;
	public float ySpeed = 20.0f;
    public float scrollSpeed = 20;

    public float yMinLimit = 00f;
	public float yMaxLimit = 90f;

	public float distanceMin = 100;
	public float distanceMax = 300;

	private Rigidbody rigidbody;

	float x = 0.0f;
	float y = 0.0f;

	// Use this for initialization
	void Start () {
        Vector3 angles = transform.eulerAngles;
		x = angles.y;
		y = angles.x;
        rigidbody = GetComponent<Rigidbody>();

		// Make the rigid body not change rotation
		if (rigidbody != null) {
				rigidbody.freezeRotation = true;
		}
	}

	void LateUpdate () {

        //Once theres a target object(linked by "Center Focus" Object), and one of the key input is given
        //Manipulate camera movements
		if (target && (Input.GetMouseButton(1) || Input.GetAxis("Mouse ScrollWheel") != 0)) {
			x += Input.GetAxis("Mouse X") * xSpeed * distance;
			y -= Input.GetAxis("Mouse Y") * ySpeed;

			y = ClampAngle(y, yMinLimit, yMaxLimit);

			Quaternion rotation = Quaternion.Euler(y, x, 0);

			distance = Mathf.Clamp(distance - Input.GetAxis("Mouse ScrollWheel") * scrollSpeed, distanceMin, distanceMax);
                
			Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
			Vector3 position = rotation * negDistance + target.position;

			transform.rotation = rotation;
			transform.position = position;
		}
	}

	public static float ClampAngle(float angle, float min, float max) {
		if (angle < -360F)
				angle += 360F;
		if (angle > 360F)
				angle -= 360F;
		return Mathf.Clamp(angle, min, max);
	}
}
