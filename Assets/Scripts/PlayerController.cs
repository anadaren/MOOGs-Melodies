using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;

   private Vector2 movement;
   private Vector2 moveVelocity;
   public float speed;

   public AudioSource moveSound;

 
   // Start is called before the first frame update
   void Start()
   {
       // Gets players Rigidbody to move it
       rb = GetComponent<Rigidbody2D>();
   }
 
   // Update is called once per frame
   void Update()
   {
       // Movement
       movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       moveVelocity = movement.normalized * speed;

        

   }
 
   void FixedUpdate()
   {
       rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
   }
}
