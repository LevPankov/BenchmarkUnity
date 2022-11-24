using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModule : MonoBehaviour
{
    [SerializeField] private float rotateAngle;

    private void Update()
    {
        transform.Rotate(rotateAngle * Time.deltaTime, 0f, 0f);
    }
}
