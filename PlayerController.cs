using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody rb;
    public float jumpforce = 2f;
    private bool isGrounded = true;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask Collectible;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical).normalized * speed * Time.deltaTime; ;


        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isGrounded = false;
            //Debug.Log("Elemelkedtünk a földtõl.");
            //Debug.Log(isGrounded);

        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Érintkezünk a földdel.");
        //Debug.Log("Layer index: " + collision.gameObject.layer);

        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            isGrounded = true;
            //Debug.Log(isGrounded);
        }
    }
}

   
