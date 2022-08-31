using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] helixRings;
    [SerializeField] private float ySpawn = 0;
    [SerializeField] private float ringsDistance = 5;
    public int numberOfRings;
    
    void Start()
    {
        numberOfRings = LevelManager.currentLevelIndex + 5;
        
        for (int i = 0; i < numberOfRings; i++)
        {
            if (i==0)
            {
                SpawnRing(0);
            }
            else
            {
                SpawnRing(Random.Range(1, helixRings.Length - 1));
            }
            
        }

        SpawnRing(helixRings.Length - 1);

    }
    
    public void SpawnRing(int ringIndex)
    {
        GameObject go = Instantiate(helixRings[ringIndex], transform.up * ySpawn, Quaternion.identity);
        go.transform.parent = transform;
        ySpawn -= ringsDistance;
    }
}
