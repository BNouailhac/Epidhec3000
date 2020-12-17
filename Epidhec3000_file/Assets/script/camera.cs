using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform lookAt;
    public Vector3 offset;
    private float distance = 5.0f;
    private float yOffset = 3.5f;

    void Start()
    {
        offset = new Vector3(0, yOffset, distance);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lookAt.position + offset;
    }
}
