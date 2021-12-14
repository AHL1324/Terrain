using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update

    public float mouseSensitivity = 100f;
    //Velocidad del ratón o sensibilidad
    float xRotation = 0f;
    //Rotacion alrededor eje X
    public Transform playerBody;
    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //No mostrar el ratón al empezar el juego
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        //-= así para que la rotación no se invierta 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
