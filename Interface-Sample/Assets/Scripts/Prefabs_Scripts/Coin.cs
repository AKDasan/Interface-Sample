using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        // Coin toplan�ld���n'da yap�lacak i�lemler
        Destroy(gameObject);
    }
}
