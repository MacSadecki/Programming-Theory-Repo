using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCar : Vehicle
{
    protected override void Rotate()
    {
        transform.Rotate(new Vector3(0, 0, RotationSpeed) * Time.deltaTime);
    }
}
