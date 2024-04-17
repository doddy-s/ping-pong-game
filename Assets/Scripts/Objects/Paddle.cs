using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    protected Rigidbody2D _rigidbody2D;
    public float Speed = 10f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
}
