using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlumberController2 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d = null;

    void Update()
    {
        GetInput();
    }
    
    void GetInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = Vector2.right * 10;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = Vector2.left * 10;
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
