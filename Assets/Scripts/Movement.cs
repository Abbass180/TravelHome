using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    public Rigidbody rigid;

    public Vector3 RotateAmount;

    void Start()
    {
        speed = 11f;
        //speed is only applicable in game mode and must be changed here
        
    }

    void Update()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
        //Movement via the WASD keys

        transform.Rotate(RotateAmount * Time.deltaTime);
    }
}
