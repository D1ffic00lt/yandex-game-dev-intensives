using UnityEngine;

public class RopeGrip : MonoBehaviour
{
    private HingeJoint2D _hingeJoint2D;
    
    private void Awake()
    {
        _hingeJoint2D = gameObject.GetComponent<HingeJoint2D>();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("LeftMousePressed");
            _hingeJoint2D.enabled = false;
            
        }
    }
}
