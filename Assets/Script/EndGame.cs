﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Application.LoadLevel("2_lvl");
        //public static void LoadScene("2_lvl", SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
}
