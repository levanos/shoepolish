using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brush : MonoBehaviour
{
    public float distance = 3.3f;
    private float r;
    private float g;
    private float b;
    [SerializeField]
    private float speed;
    Vector3 destination;
    float sens = 10;
    public GameObject clean;
    private Vector3 spawnHere;

    void Update()
    {
        MoveBrush();
    }

    void MoveBrush()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distance;
        destination = Camera.main.ScreenToWorldPoint(mousePosition);
        GetComponent<Rigidbody>().velocity = (destination - transform.position) * sens;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.GetComponent<Renderer>().materials.Length == 2)
        {
            if (other.GetComponent<Renderer>().materials[1].color.g < 1.1 || other.GetComponent<Renderer>().materials[1].color.r < 1.1 || other.GetComponent<Renderer>().materials[1].color.b < 1.1)
            {
                Debug.Log(other.GetComponent<Renderer>().materials[1].color.g);
                g = other.GetComponent<Renderer>().materials[1].color.g + speed / 255f;
                r = other.GetComponent<Renderer>().materials[1].color.r + speed / 255f;
                b = other.GetComponent<Renderer>().materials[1].color.b + speed / 255f;
                Debug.Log(other.GetComponent<Renderer>().materials[1].color);
                other.GetComponent<Renderer>().materials[1].color = new Color(r, g, b);
            }
        }
        else
        {
            if (other.GetComponent<Renderer>().materials[0].color.g < 1.1 || other.GetComponent<Renderer>().materials[0].color.r < 1.1 || other.GetComponent<Renderer>().materials[0].color.b < 1.1)
            {
                Debug.Log(other.GetComponent<Renderer>().materials[0].color.g);
                g = other.GetComponent<Renderer>().materials[0].color.g + speed / 255f;
                r = other.GetComponent<Renderer>().materials[0].color.r + speed / 255f;
                b = other.GetComponent<Renderer>().materials[0].color.b + speed / 255f;
                Debug.Log(other.GetComponent<Renderer>().materials[0].color);
                other.GetComponent<Renderer>().materials[0].color = new Color(r, g, b);
            }
        }
    }

}