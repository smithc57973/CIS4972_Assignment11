/*
 * Chris Smith
 * PlayerController
 * Assignment 11
 * A script for managing player input.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Facade f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            f.MakeDinner(f.guests);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            f.CleanUp();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            UIManager.Instance.text.text = "";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
