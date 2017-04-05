using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour 
{
	public float mouseSensitivity = 100.0f;
	public float clampAngle = 80.0f;

	private float rotY = 0.0f; //rotation of the y axis
	private float rotX = 0.0f; //rotation of the x axis

	// Use this for initialization
	void Start () 
	{
		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;
	}

    // Update is called once per frame
    void Update()
    {
        /*
        *This IF is temporary, just for simplicity on the PC prototype for now
        *This is to keep the camera steeady when the player just wants to press a button
        */
        if (Input.GetKey(KeyCode.LeftShift)){

            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            rotY += mouseX * mouseSensitivity * Time.deltaTime;
            rotX -= mouseY * mouseSensitivity * Time.deltaTime; //use minues equals so y axis not inverted

            rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

            Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
            transform.rotation = localRotation;
        }
	}
}
