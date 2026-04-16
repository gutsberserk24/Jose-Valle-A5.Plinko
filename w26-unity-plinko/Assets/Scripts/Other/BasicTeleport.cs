using UnityEngine;

public class BasicTeleport : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.rigidbody.MovePosition(new Vector2(0, 4));
    }
}
