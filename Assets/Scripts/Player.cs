using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public GameObject shotPrefab;
 

    private MoveBehavior _movebehavior;
    private Animator _animator;




    // Start is called before the first frame update
    void Awake()
    {
        _movebehavior = GetComponent<MoveBehavior>();
        _animator = GetComponent<Animator>();

    }

  

    // Update is called once per frame



    void FixedUpdate()
    {



        /* float f = Input.GetAxis("Horizontal") * 100.0F;
         f *= Time.deltaTime;
         transform.Rotate(0, 0, -f);



         _movebehavior.move(transform.up * Input.GetAxis("Vertical"));






         float move = Input.GetAxis("Vertical") * 10.0F;
         move *= Time.deltaTime;
         transform.Translate(0,move,0);

         Vector3 mousepos = Input.mousePosition;
         Vector3 p = Camera.main.ScreenToWorldPoint(mousepos);
         p.z = 0;
         float dify = p.y - transform.position.y;
         float difx = p.x - transform.position.x;
         float alfa = Mathf.Atan2(dify, difx);
         transform.rotation = Quaternion.AngleAxis((alfa * Mathf.Rad2Deg)-90, Vector3.forward);


     */
        if (Input.GetKey(KeyCode.D))
        {
            _movebehavior.move(new Vector2(1, 0));
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            _movebehavior.move(new Vector2(0, 1));

        }
        if (Input.GetKey(KeyCode.S))
        {
            _movebehavior.move(new Vector2(0, -1));

        }
        if (Input.GetKey(KeyCode.A))
        {
            _movebehavior.move(new Vector2(-1,0));
            
        }
        
        


        // _point.rotate();





    }
}

