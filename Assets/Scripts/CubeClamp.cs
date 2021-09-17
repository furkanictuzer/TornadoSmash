using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClamp : MonoBehaviour
{
    Vector3 pos;
    public float minX = -14.8f, maxX = 14.8f;
    public float minZ = -19.8f, maxZ = 19.8f;
    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
        transform.position = pos;
    }
}
