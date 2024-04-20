using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace Player
{
    public class PlayerControls : MonoBehaviour
    {
        public float baseSpeed = 10.0f;

        void Start()
        {

        }

        void Update()
        {
            Vector3 newMovementVector = Vector3.zero;

            // Forward
            if (Input.GetKey(KeyCode.W))
            {
                newMovementVector += Vector3.forward;
            }

            // Backward
            if (Input.GetKey(KeyCode.S))
            {
                newMovementVector += Vector3.back;
            }

            // Left
            if (Input.GetKey(KeyCode.A))
            {
                newMovementVector += Vector3.left;
            }

            // Right
            if (Input.GetKey(KeyCode.D))
            {
                newMovementVector += Vector3.right;
            }

            transform.Translate(newMovementVector.normalized * (baseSpeed * Time.deltaTime), Space.Self);
        }
    }
}
