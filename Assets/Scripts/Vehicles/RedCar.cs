using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCar : Vehicle // INHERITANCE
{
    // POLYMORPHISM
    protected override void Rotate()
    {
        transform.Rotate(new Vector3(0, RotationSpeed, 0) * Time.deltaTime);
    }
}
