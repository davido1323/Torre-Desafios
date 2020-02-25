using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleEnemy : MonoBehaviour
{

    private MoveBehavior _movebehavior;
    private PathBehavior _pathbehavior;
    //Constructors


    public void Start()
    {
        

        _pathbehavior = GetComponent<PathBehavior>();
    }

    public void FixedUpdate()
    {


        _pathbehavior.path();

    }
    //Funcions






}