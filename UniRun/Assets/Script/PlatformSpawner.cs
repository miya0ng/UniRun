using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    //transform.position = new Vector3(0, Random.Range(-30, 30), 0);
    public GameObject platformPrefab;
    void Start()
    {
        platformPrefab.transform.position = new Vector3(0, Random.Range(-30, 30), 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlatform()
    {
        Instantiate(platformPrefab, platformPrefab.transform.position, Quaternion.identity);
    }
}
