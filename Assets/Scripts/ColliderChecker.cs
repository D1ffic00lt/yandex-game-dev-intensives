using UnityEngine;

public class ColliderChecker : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.gameObject.GetComponent<HingeJoint2D>().enabled)
        {
            // col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));
            col.transform.position = _rigidbody2D.position;
            col.gameObject.GetComponent<HingeJoint2D>().connectedBody = _rigidbody2D;
            // col.gameObject.GetComponent<HingeJoint2D>().anchor = col.ClosestPoint(_rigidbody2D.transform.position);
            col.gameObject.GetComponent<HingeJoint2D>().enabled = true;
        }
        
        // print(1);
    }
    
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        print(_rigidbody2D.tag);
    }
}
