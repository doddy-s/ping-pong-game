using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 10f;

    protected Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Vector2 xy = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.4f, 0.4f)).normalized;
        _rigidbody2D.velocity = xy * Speed;
    }
}
