using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public GameObject boxSmallPrefab;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RainBox", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RainBox()
    {
        float randomX = Random.Range(-31, -27);
        float randomZ = Random.Range(13, 19);

        Instantiate(boxSmallPrefab, new Vector3(randomX, 5f, randomZ), boxSmallPrefab.transform.rotation);
    }

    public void StopRain()
    {
        CancelInvoke();
    }
}
