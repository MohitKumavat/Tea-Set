using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement: MonoBehaviour
{
    public float mSpeed = 10f;
    Vector3 mVelocity;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        mVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.B))
        {//for 
            transform.Translate( Time.deltaTime * mSpeed,0f,0f);
        }
        if (Input.GetKey(KeyCode.N))
        {
            transform.Translate(-Time.deltaTime * mSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Translate(0f, mSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.Translate(0f, -mSpeed * Time.deltaTime, 0f);
        }
    }
}
