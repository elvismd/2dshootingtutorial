using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 10;

    public void GetDamage()
    {
        health--;
        Debug.Log("Enemy took damage!");
    }
}
