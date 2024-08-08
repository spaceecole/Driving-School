using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public float speed = 10f;
    public float rotationSpeed = 100f;
    public float maxAngle = 30f;

    private float horizontalInput;
    private float verticalInput;
  

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Debug.Log(verticalInput);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * verticalInput * Time.fixedDeltaTime);

        float rotation = horizontalInput * rotationSpeed * Time.fixedDeltaTime;
        float angle = transform.rotation.eulerAngles.y + rotation;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
