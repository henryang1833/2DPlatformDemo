using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayer : MonoBehaviour
{
    public float speed = 4.5f;
    private Rigidbody2D body;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        body= GetComponent<Rigidbody2D>();
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float dealtX = Input.GetAxis("Horizontal") * speed;
        animator.SetFloat("speed",Mathf.Abs(dealtX));
        if(!Mathf.Approximately(dealtX, 0))
        {
            transform.localScale = new Vector3(Mathf.Sign(dealtX),1,1);
        }
        Vector2 movement = new Vector2(dealtX,body.velocity.y);
        body.velocity = movement;
    }
}
