using UnityEngine;
using System.Collections;

public class moveTeapot : MonoBehaviour {
    public float mSpeed=10;
    Vector3 mVelocity;
    public ParticleSystem liq;

	// Use this for initialization
	void Start () {
        liq.Stop();

    }
	
	// Update is called once per frame
	void Update () {
        mVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.X)){//for 
            mVelocity.z = 1.0f;
        } else if (Input.GetKey(KeyCode.Z)){
            mVelocity.z = -1.0f;
        }

        if (Input.GetKey(KeyCode.L)){
            mVelocity.x = 1.0f;
        }
        else if (Input.GetKey(KeyCode.J)){
            mVelocity.x= -1.0f;
        }
        if (Input.GetKey(KeyCode.I))
        {
            mVelocity.y = 1.0f;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            mVelocity.y = -1.0f;
        }
        transform.Translate(mVelocity.normalized * Time.deltaTime*mSpeed);
        if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(0.0f,0.0f, 40 * Time.deltaTime);
            liq.Stop();
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, 0.0f, -40 * Time.deltaTime);
            liq.Play();
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(0.0f, 40 * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(0.0f, -40 * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate( 40 * Time.deltaTime,0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(-40 * Time.deltaTime, 0.0f, 0.0f);
        }

    }
}
