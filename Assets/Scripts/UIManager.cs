using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private LevelManager levelManager;
    
    float progress;
    [SerializeField] private Slider slider;


    // Update is called once per frame
     void Update()
     {
        SetProgress(1-levelManager.progress);        
     }

     void SetProgress(float progress)
     {
         slider.value = progress;
     }
}
