using UnityEngine;

public class FlowPlayer : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
