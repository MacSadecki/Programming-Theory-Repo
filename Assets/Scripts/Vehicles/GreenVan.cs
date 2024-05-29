using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenVan : Vehicle // INHERITANCE
{
    // POLYMORPHISM
    protected override void Rotate()
    {
        transform.Rotate(new Vector3(RotationSpeed, 0, 0) * Time.deltaTime);
    }
}
