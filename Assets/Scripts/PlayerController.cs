using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    
    private Rigidbody rb;

    private AudioManager audioManager;
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        audioManager.Play("bounce");
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if (materialName== "SafeMaterial (Instance)")
        {
            
        }
        else if (materialName== "UnSafeMaterial (Instance)")
        {
            LevelManager.gameOver = true;
            audioManager.Play("game over");
        }
        else if (materialName== "LastRing (Instance)" && !LevelManager.levelCompleted)
        {
            LevelManager.levelCompleted = true;
            audioManager.Play("win level");
        }
    }
}
