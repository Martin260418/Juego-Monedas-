﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpam : MonoBehaviour
{
    float timer;
    public GameObject coinPrefab;
 
    void Update()
    {
       timer += Time.deltaTime;
       if (timer >= 3f)
       {
           timer = 0;
           float x = Random.Range (-8f, 8f);
           Vector3 position = new Vector3 (x, 0, 0);
           Quaternion rotation = new Quaternion();
           Instantiate(coinPrefab, position, rotation);
       } 
    }
}
