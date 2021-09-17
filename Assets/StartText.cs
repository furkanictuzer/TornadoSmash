using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    [SerializeField] private Text text;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            text.enabled = false;
        }
    }
}
