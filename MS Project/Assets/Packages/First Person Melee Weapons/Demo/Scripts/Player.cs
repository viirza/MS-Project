using UnityEngine;

public class Player : MonoBehaviour
{

	private float lookSpeed = 2.0f;
	private float rotationX = 0;
    private Camera mainCamera; 
	
private void Start()
    {
	   mainCamera = GetComponentInChildren<Camera>();
	   Cursor.lockState = CursorLockMode.Locked;
	   Cursor.visible = false;
    }


private void Update()
    {	
		rotationX -= Input.GetAxis("Mouse Y") * lookSpeed;
		rotationX = Mathf.Clamp(rotationX, -80, 80);
		mainCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
		transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
	}
}