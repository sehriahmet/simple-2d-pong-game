using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftStickControls : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        
        if (Keyboard.current != null && Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}
