using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

      
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        
        movement.Normalize();

     
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
