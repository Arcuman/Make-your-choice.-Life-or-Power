﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearBullet_add : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Character character = collider.GetComponent<Character>();
        if (character)
        {
            character.nearCount += 1;
            character.nearCountText.text = "FarBullet: " + character.nearCount;
            Destroy(gameObject);
        }
    }
}
