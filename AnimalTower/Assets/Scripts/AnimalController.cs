using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    float speed = 5;

    void update()
    {
        MoveGameObject();
    }

    private void MoveGameObject()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            rg.transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
        }
    }
}
