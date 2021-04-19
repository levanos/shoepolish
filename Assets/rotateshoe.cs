using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateshoe : MonoBehaviour
{
    [SerializeField]
    private float speed = 50.0f;

    private void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
}
