using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype2.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] float _horizontalInput;
        [SerializeField] float _speed = 10f;
        private float _xRange = 15;
        [Header("Fire")]
        [SerializeField] GameObject _projectilePrefab;

        private void Update()
        {
            PlayerMovement();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(_projectilePrefab, transform.position, _projectilePrefab.transform.rotation);
            }
        }

        private void PlayerMovement()
        {
            if (transform.position.x < -_xRange)
            {
                transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x > _xRange)
            {
                transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
            }
            _horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);
        }
    }
}

