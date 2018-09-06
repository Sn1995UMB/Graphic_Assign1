using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapController : MonoBehaviour {

    public float speed = 10.0f;
    public float sensitivity = 2.0f;
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        float rotateX = x * sensitivity;
        float rotateY = y * sensitivity;
        Vector3 currRotation = transform.rotation.eulerAngles;
        currRotation.x -= rotateY;
        currRotation.y += rotateX;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);
        transform.rotation = Quaternion.Euler(currRotation);
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
