using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed; 
    // как жить, когда говорили, что приватные переменные нужно начинать с _, но Rider говорит, что нужно заменить на speed:(
    
    private Rigidbody2D _rigidBody2D;
    
    private void Awake()
    {
        _rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        _rigidBody2D.AddForce(new Vector2(horizontalInput * _speed * Time.deltaTime, 0));
    }
}
