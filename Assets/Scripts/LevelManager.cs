using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float initialCubeNum;
    public float remainingCubeNum;
    public float progress;
    [SerializeField] 
    private GameObject cubeSpawner;
    [SerializeField]
    private GameObject endCanvas;
    [SerializeField]
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        initialCubeNum = cubeSpawner.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        remainingCubeNum = cubeSpawner.transform.childCount;
        progress = remainingCubeNum / initialCubeNum;
        if (progress == 0)
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        player.transform.localScale -=Vector3.one * (float)2 * Time.deltaTime;
        endCanvas.SetActive(true);

        if (player.transform.localScale.magnitude < 0.1)
        {
            player.SetActive(false);
            StartCoroutine(LoadNextScene());
        }
        
        

    }
    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
