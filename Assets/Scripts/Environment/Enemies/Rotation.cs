using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float DefaultSpeed;
    private float RotateSpeed;
    public float direction;
    private float wait = 0;


    // Start is called before the first frame update
    void Start()
    {
        RotateSpeed = DefaultSpeed;
    }

    void FixedUpdate()
    {
        float angle = transform.eulerAngles.z;

        if ((int)angle % 90 == 0)
        {
            wait += Time.deltaTime;
            RotateSpeed = 0;
            if (wait > 0.01f)
            {
                wait = 0;
                RotateSpeed = DefaultSpeed;
            }
        }
        transform.Rotate(0, 0, RotateSpeed * direction * Time.deltaTime);
    }
    
}
