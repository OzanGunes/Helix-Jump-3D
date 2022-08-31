using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > player.position.y)
        {
            FindObjectOfType<AudioManager>().Play("whoosh");
            LevelManager.numberOfPassedRings++;
            LevelManager.score++;
            Destroy(gameObject);
        }
    }
}
