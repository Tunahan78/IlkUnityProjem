using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [Header("Player Movement")]

   [SerializeField] float speed;
   [SerializeField] float horizontalSpeed;

   [Header("Components")]
   [SerializeField] Rigidbody rb;
   


   private void Awake()
   {
      rb = GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {
      rb.AddForce(0, 0, speed * Time.deltaTime);

      if (Input.GetKey("d"))
      {
         rb.AddForce(horizontalSpeed * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
      }
      if (Input.GetKey("a"))
      {
         rb.AddForce(-horizontalSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }
   }






}
