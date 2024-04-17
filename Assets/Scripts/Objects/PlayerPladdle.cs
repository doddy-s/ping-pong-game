using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerPladdle : Paddle
{
    private Vector2 _direction;

    private void OnMove(InputValue value)
    {
        _direction = value.Get<Vector2>();
        // Debug.Log(_direction);
    }

    private void OnSpeedUp(InputValue value)
    {
        Speed = (1 + value.Get<float>()) * 10;
        // Debug.Log(value.Get<float>());
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = _direction * Speed;
    }
}
