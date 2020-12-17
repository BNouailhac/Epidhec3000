using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour
{

    float xRot, yRot, zRot;
    public float rotSpeed = 20f;

    void Start()
    {
        Input.compensateSensors = true;
        Input.gyro.enabled = true;
    }

    void FixedUpdate()
    {
        transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, Input.gyro.rotationRateUnbiased.z);
    }
}