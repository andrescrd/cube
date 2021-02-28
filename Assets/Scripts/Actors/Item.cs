using System;
using Enums;
using Support;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Actors
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private float speed = 150;
        [SerializeField] private ItemType type;
    
        private Rigidbody _rigidbody;

        private void Start()
        {
            type = Utils.GetRandomType();

            var cubeRenderer = GetComponent<Renderer>();
            cubeRenderer.material.color = Utils.GetColor(type);
        
            _rigidbody = GetComponent<Rigidbody>();

            if (_rigidbody)
            {
                _rigidbody.AddForce(Vector3.up * speed);
            }
        }

        public ItemType GetItemType()
        {
            return type; 
        }
    }
}
