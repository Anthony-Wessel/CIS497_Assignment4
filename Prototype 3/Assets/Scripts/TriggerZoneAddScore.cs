/*
 * Anthony Wessel
 * Assignment 4 Prototype 3
 * Increments the score when the player hits the attached trigger
 */

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    UIManager uiManager;

    bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !triggered)
            uiManager.score++;
    }
}
