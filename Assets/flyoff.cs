using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyoff : MonoBehaviour
{
    public float speed = 0.2f;

    private void Start()
    {
        Invoke("Die", 1.0f);
        if (randomBoolean())
            speed = -speed;

    }

    private void FixedUpdate()
    {
         transform.Translate(speed,0,0);
    }

    bool randomBoolean()
    {
        if (Random.value >= 0.5)
        {
            return true;
        }
        return false;
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
