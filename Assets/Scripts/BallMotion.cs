using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{
    public static BallMotion instance;  
    public float forwardForce = 700;
    public float sideForce = 80;
    public float jumpForce = 5;
    public GameObject gameOverUI;
    public GameObject scoreUI;

    private Rigidbody rb;
    private bool isGrounded;
    private bool isGameOver = false;

    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameOverUI.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        if (isGameOver) return; 

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space") && isGrounded)
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
        }
    }

    private void GameOver()
    {
        isGameOver = true;
        rb.velocity = Vector3.zero; 
        gameOverUI.SetActive(true); 
        scoreUI.SetActive(false);
    }

    public void GameStop()
    {
        isGameOver = true;
        rb.velocity = Vector3.zero;
        scoreUI.SetActive(false);
    }
}
