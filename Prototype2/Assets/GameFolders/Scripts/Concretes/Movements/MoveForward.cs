using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movements.MoveForward
{
    public class MoveForward : MonoBehaviour
    {
        [SerializeField] float _speed = 40.0f;
        void Start()
        {

        }

        
        void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
    }

}

