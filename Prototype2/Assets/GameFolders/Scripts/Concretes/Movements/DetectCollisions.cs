using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Prototype2.MoveForward
{
    public class DetectCollisions : MonoBehaviour
    {

        void Start()
        {

        }


        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

