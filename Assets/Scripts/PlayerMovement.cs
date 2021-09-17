using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Touch touch;
    Vector3 firstTouchPos;
    float deltaSwipeX, lastXPosition;
    private float xMin = -15f, xMax = 15f;

    float deltaSwipeZ, lastZPosition;
    private float zMin = -20f, zMax = 20f;
   

    // Update is called once per frame
    void Update()
    {
        SwipeControl();
        
    }

    void SwipeControl()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                firstTouchPos = touch.position;
                lastXPosition = transform.position.x;
                lastZPosition = transform.position.z;
            }
            deltaSwipeX = touch.position.x - firstTouchPos.x;
            deltaSwipeZ = touch.position.y - firstTouchPos.y;
            if (touch.phase == TouchPhase.Ended)
            {
                //lastXPosition = transform.position.x;
                //deltaSwipeX = 0;
                //lastZPosition = transform.position.z;
                //deltaSwipeX = 0;
            }
            SideMovingControls();
        }
    }


    void SideMovingControls()
    {
        transform.position = new Vector3(Mathf.Clamp((deltaSwipeX / 30 + lastXPosition), xMin, xMax), transform.position.y, Mathf.Clamp((deltaSwipeZ / 30 + lastZPosition), zMin, zMax));
    }
}
