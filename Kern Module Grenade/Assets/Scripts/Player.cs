using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

//Quick Player Class for the launching of the bomb.
public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private InputAction moveAction;
    [SerializeField] private UnityEvent ePress;

    private void Awake()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ePress.Invoke();
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>().normalized;
        transform.Translate(speed * Time.fixedDeltaTime * new Vector3(direction.x, 0.0f, direction.y));
    }
}
