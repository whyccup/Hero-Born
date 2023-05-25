using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float vInput;
    private float hInput;
    private Rigidbody _rb;

	private void Start()
	{
        _rb = GetComponent<Rigidbody>();
	}


	private void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        // this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        // this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
    }

	private void FixedUpdate()
	{
        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + Time.fixedDeltaTime * vInput * this.transform.forward);
        _rb.MoveRotation(_rb.rotation * angleRot);

	}
}
