using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDirt : MonoBehaviour
{
    public GameObject clean;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.tag == "Brush")
        {
            Instantiate(clean, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
