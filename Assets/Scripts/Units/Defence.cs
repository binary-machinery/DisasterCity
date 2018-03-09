﻿using System;
using UnityEngine;

public class Defence : UnitComponent
{
    public event Action onDestroyed;

    [SerializeField]
    GameObject[] _explosionsPrefabs;

    public void ReceiveAttack()
    {
        GameObject explosion = Instantiate(_explosionsPrefabs[UnityEngine.Random.Range(0, _explosionsPrefabs.Length)],
            transform.position, Quaternion.identity);
        explosion.transform.localScale = Vector3.one * 10f;
        Destroy(explosion, 1f);

        if (onDestroyed != null)
            onDestroyed();
    }
}