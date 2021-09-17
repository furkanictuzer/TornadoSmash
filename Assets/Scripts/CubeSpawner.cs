using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    GameObject spawnedCube;
    public int cubeNum = 10;
    void Awake()
    {
        CubeSpawn(cube);
    }

    void CubeSpawn(GameObject cube)
    {
        for(int x = -cubeNum; x <= cubeNum; x++)
        {
            for(int z = 0; z < cubeNum; z++)
            {
                spawnedCube = Instantiate(cube, transform.position + new Vector3(x, 1f, z - cubeNum/2), Quaternion.identity);
                spawnedCube.transform.parent = transform;
            }
        }
    }
}
