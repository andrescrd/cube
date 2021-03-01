using Enums;
using Support;
using UnityEngine;

namespace Actors
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private float speed = 150;
        [SerializeField] private ItemType type;
        [SerializeField] private GameObject model;

        private Rigidbody _rigidbody;

        private void Start()
        {
            type = Utils.GetRandomType();
            model.GetComponent<MeshFilter>().sharedMesh = GetRandomModel().GetComponent<MeshFilter>().sharedMesh;

            _rigidbody = GetComponent<Rigidbody>();

            if (_rigidbody)
                _rigidbody.AddForce(Vector3.up * speed);

            var cubeRenderer = model.GetComponent<Renderer>();
            cubeRenderer.material.color = Utils.GetColor(type);
        }

        private static GameObject GetRandomModel()
        {
            var models = Utils.Models;
            return models[Random.Range(0, models.Length)];
        }

        public ItemType GetItemType()
        {
            return type;
        }
    }
}