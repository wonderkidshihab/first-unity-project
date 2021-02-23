using UnityEngine;

public class collisionManager : MonoBehaviour
{
    public PlayerScript movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle") {
            movement.enabled = false;
            Debug.Log(collision.collider.name);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
