using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float moveSpd = 1500f;
    public GameObject Basket;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(playerRb != null)
        {
            ApplyInput();
        }
        else
        {
            Debug.LogWarning("No Rigidbody on Player " + gameObject.name + " found");
        }
    }

    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xForce = xInput * moveSpd * Time.deltaTime;

        Vector2 force = new Vector2(xForce, 0);
        playerRb.AddForce(force);

        if(xForce >= 0.0f)
        {
            Basket.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            Basket.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
