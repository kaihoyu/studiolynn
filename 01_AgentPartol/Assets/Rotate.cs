using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(x, y, z, Space.Self);
    }
}
