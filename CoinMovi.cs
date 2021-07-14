﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovi : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject scripter = GameObject.Find("Scriter");
        scripter.GetComponent<ScoreManager>().RaiserScore(1);

        Destroy (gameObject);
    }
}
