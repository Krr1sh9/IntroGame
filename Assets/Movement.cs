using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Movement : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;
    public float sensitivity = 10f;
    public float maxYAngle = 80f;

    // This is for initialisation
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey ("w")) {
            transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        else if (Input.GetKey ("s")) {
            transform.Translate(Vector3.back * Time.deltaTime * 5);
        }
        if (Input.GetKey ("a")) {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        else if (Input.GetKey ("d")) {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }

        rotationX += Input.GetAxis("Mouse X") * sensitivity;
        rotationY += Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, -maxYAngle, maxYAngle);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}