using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Vehicle : MonoBehaviour
{
    // ENCAPSULATION
    private float m_RotationSpeed = 20f;
    protected float RotationSpeed
    {
        get { return m_RotationSpeed;}
        set 
        {            
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative rotation speed!");
            }
            else
            {
                m_RotationSpeed = value;
            }                
        }
    }


    private void Update() 
    {
        if(Input.GetKey(KeyCode.Space))
        {   
            // ABSTRACTION 
            Rotate();
        }
    }

    protected abstract void Rotate();
   
}
