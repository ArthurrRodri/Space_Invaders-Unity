using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D _rb;
    
    void FixedUpdate() => Moviment();

    private void Moviment()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var movement = new Vector3(horizontal, 0f, 0f).normalized;

        _rb.AddForce(movement * speed * Time.deltaTime);
    }
}
