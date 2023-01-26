using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Prototype2.MoveForward
{
    public class DestroyOutOfBounds : MonoBehaviour
    {
        [SerializeField] float _topBound = 30;
        [SerializeField] float _lowerBound = -10;
        void Start()
        {

        }

        
        void Update()
        {
            if (transform.position.z> _topBound)
            {
                Destroy(gameObject);
            }
            else if (transform.position.z<_lowerBound)
            {
                Destroy(gameObject);
            }
        }
    }

}
