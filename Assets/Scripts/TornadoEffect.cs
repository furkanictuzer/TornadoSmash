using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoEffect : MonoBehaviour
{

    public Transform tornadoCenter;
    public float refreshRate;
    public float pullForce;
    public float scaleRate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube") && other.gameObject != null)
        {
            
            StartCoroutine(Tornado(other));
        }
    }

    IEnumerator Tornado(Collider collider)
    {
        if (collider.gameObject != null)
        {
            Vector3 ForDir = tornadoCenter.position - collider.transform.position;
            collider?.GetComponent<Rigidbody>().AddForce(ForDir.normalized * pullForce * Time.deltaTime);
            yield return refreshRate;
            if (collider != null)
            {
                CubeScaleResize(collider.gameObject);
                CubeDestroyer(collider.gameObject);
                StartCoroutine(Tornado(collider));
            }
            
          
        }
        
    }

    void CubeScaleResize(GameObject cube) 
    {
        cube.transform.localScale -= Vector3.one * scaleRate * Time.deltaTime;
    }
    void CubeDestroyer(GameObject cube)
    {
        if(cube.transform.localScale.magnitude < 0.1)
        {
            Destroy(cube);
        }
    }
}
