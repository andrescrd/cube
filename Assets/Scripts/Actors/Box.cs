﻿using Enums;
using Managers;
using Support;
using UnityEngine;

namespace Actors
{
    public class Box : MonoBehaviour
    {
        [SerializeField] private GameObject itemPrefab;
        [SerializeField] private GameObject spawner;
        [SerializeField] private bool canSpawn;
        [SerializeField] private ItemType type;
        
        private float _nextSpawn;
        private GameManager _gameManager;
        private AudioSource _audioSource;

        private void Start()
        {
            _gameManager = FindObjectOfType<GameManager>();
            _audioSource = GetComponent<AudioSource>();
            
            var cubeRenderer = GetComponent<Renderer>();
            cubeRenderer.material.color = Utils.GetColor(type);
        }

        private void Update()
        {
            if (Time.time > _nextSpawn && canSpawn)
            {
                _nextSpawn = Time.time + Random.Range(3f, 8f);
                SpawnItem();
            }
        }

        public void CanSpawn()
        {
            canSpawn = true;
        }

        private void SpawnItem()
        {
            if (itemPrefab)
                Instantiate(itemPrefab, spawner.transform.position, Quaternion.identity);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Item"))
            {
                var item = other.GetComponent<Item>();

                if (type == item.GetItemType())
                {
                    _audioSource.Play();
                    _gameManager.AddScore();
                }
                Destroy(other.gameObject);
            }
        }
    }
}