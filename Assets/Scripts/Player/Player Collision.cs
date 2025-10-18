using Unity.VisualScripting;
using UnityEngine;

public class PlayerColli : MonoBehaviour
{

    [SerializeField] PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag== "Obstagle")
        movement.enabled = false;
    }
}
