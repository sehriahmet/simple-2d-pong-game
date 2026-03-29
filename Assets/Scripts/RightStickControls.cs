using UnityEngine;
using UnityEngine.InputSystem;

public class RightStickControls : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        
        if (Keyboard.current != null && Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}
