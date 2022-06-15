using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Code.ExampleCharacter
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 3f;
        [SerializeField] private float rotationSpeed = 2f;

        private float lastMouseXPosition;
        private void Update()
        {
            Rotate();
            Move();
        }

        private void Move()
        {
            var movement = new Vector3
            {
                x = Input.GetAxisRaw("Horizontal"),
                y = 0f,
                z = Input.GetAxisRaw("Vertical")
            };
            movement.Normalize();
            transform.position += movement * movementSpeed * Time.deltaTime;
        }

        private void Rotate()
        {
            var mousePosition = Input.mousePosition;
            transform.Rotate(Vector3.up,(lastMouseXPosition - mousePosition.x)*rotationSpeed*Time.deltaTime);
            lastMouseXPosition = mousePosition.x;
        }
    }
}
