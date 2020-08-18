using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlumberController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d = null;

    void Update()
    {
        GetInput();
    }
    
    void GetInput()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.velocity = Vector2.right * 10;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.velocity = Vector2.left * 10;
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
