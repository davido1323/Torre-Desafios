using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform[] Path;
    [SerializeField]
    private bool PinPong;

    private int k = 1;


    private MoveBehavior _movebehavior;

    [SerializeField]
    private int _nextpoint = 1;


    Vector3 dir;

    void Awake()
    {
        int a = _nextpoint;
        if (_nextpoint == 0) {
            a = 3;
        }
        transform.position = Path[a].position;


        _movebehavior = GetComponent<MoveBehavior>();
        dir = (Path[_nextpoint].position - transform.position);
        

    }

    // Update is called once per frame
    public void path()
    {
        float alfa;
        _movebehavior.move(dir.normalized);
        float dify, difx;
        float d = Vector3.SqrMagnitude(transform.position - Path[_nextpoint].position);
        if (d < 0.001f)
        {
            if (PinPong)
            {
                _nextpoint = (_nextpoint + k) % Path.Length;
                if ((_nextpoint + k == Path.Length) || (_nextpoint == 0))
                {
                    k *= -1;
                }

                dir = (Path[_nextpoint].position - transform.position);
            }

            else
            {
                _nextpoint = (_nextpoint + 1) % Path.Length;
                dir = (Path[_nextpoint].position - transform.position);
            }
        }

        dify = Path[_nextpoint].position.y - transform.position.y;
        difx = Path[_nextpoint].position.x - transform.position.x;
        alfa = Mathf.Atan2(dify, difx);
        transform.rotation = Quaternion.AngleAxis(alfa * Mathf.Rad2Deg, Vector3.forward);
        
    }
}
