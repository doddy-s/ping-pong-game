using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPaddle : Paddle
{
    public Rigidbody2D Ball;

    private void FixedUpdate()
    {
        if (Ball.velocity.x > 0)
        {
            if (Ball.position.y > transform.position.y)
            {
                _rigidbody2D.velocity = Vector2.up * Speed;
            }
            else if (Ball.position.y < transform.position.y)
            {
                _rigidbody2D.velocity = Vector2.down * Speed;
            }
            else
            {
                _rigidbody2D.velocity = Vector2.zero;
            }
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
    }
}
