using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 scaleChange;
    Vector3 m;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {

        m.x = 0.0f;
        m.y = 0.0f;
        m.z = 0.0f;
    }

    // Update is called once per frame
    void Update()

    {

        if (Input.GetKey(KeyCode.W))
        {
            m.x = 0.1f;
            transform.Rotate(m.x, m.y, m.z);
            m.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {

            m.x = -0.1f;
            transform.Rotate(m.x, m.y, m.z);
            m.x = 0.0f;

        }
        if (Input.GetKey(KeyCode.D))
        {
            m.z = -0.1f;
            transform.Rotate(m.x, m.y, m.z);
            m.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            m.z = 0.1f;
            transform.Rotate(m.x, m.y, m.z);
            m.z = 0f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            m.y = 0.1f;
            transform.Rotate(m.x, m.y, m.z);
            m.y = 0f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            m.y = -0.1f;
            transform.Rotate(m.x, m.y, m.z);
            m.y = 0f;
        }







    }
}
