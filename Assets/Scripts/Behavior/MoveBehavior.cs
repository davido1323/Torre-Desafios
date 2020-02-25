using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class MoveBehavior : MonoBehaviour
{
    [SerializeField]
    private Vector2 _direction; //direction of advance

    [SerializeField]
    private float _speed; //Units of speed

    public Vector2 direction;

    private Rigidbody2D _rb;

    public void Awake()
    {

        _rb = GetComponent<Rigidbody2D>();
        direction = _direction;
    }
    public void move()
    {

        _rb.MovePosition(new Vector2(transform.position.x + direction.x * _speed * Time.deltaTime,
                                     transform.position.y + direction.y * _speed * Time.deltaTime));

    }


    public void move(Vector2 newdir)
    {
        _rb.MovePosition(new Vector3(transform.position.x + newdir.x * _speed * Time.deltaTime,
                                     transform.position.y + newdir.y * _speed * Time.deltaTime,
                                     0));
    }




    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }
}
