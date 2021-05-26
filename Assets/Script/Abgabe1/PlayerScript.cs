using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6;

    private void Update()
    {
        //Movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(moveHorizontal, 0f, moveVertical) * _speed * Time.deltaTime;
        transform.Translate(moveDirection, Space.Self);


    }

    private void FixedUpdate()
    {
        //Rotation
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.LookRotation(new Vector3(Mathf.Sin(-0.02f), 0, Mathf.Cos(-0.02f)));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.LookRotation(new Vector3(Mathf.Sin(0.02f), 0, Mathf.Cos(0.02f)));
        }
    }
}