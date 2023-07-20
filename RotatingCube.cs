using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this to control the movement speed

    void Update()
    {
        // Move the cube along the X and Z axes based on arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        MoveCube(moveHorizontal, moveVertical);
    }

    // Function to move the cube in the specified direction
    void MoveCube(float horizontal, float vertical)
    {
        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // Move the cube using Transform.Translate
        transform.Translate(movement, Space.World);

        // Keep the cube above the Plane (modify this part according to your needs)
        float newYPosition = Mathf.Max(transform.position.y, 0.5f); // Adjust 0.5f as needed to keep the cube above the Plane
        transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
    }
}

