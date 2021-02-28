using System.Collections.Generic;
using UnityEngine;

namespace Actors
{
    public class BoxGroup : MonoBehaviour
    {
        [SerializeField] private float offset = 100;
        [SerializeField] private float speed = 10;

       private LinkedList<Box> _children;
        
        private bool _moveLeft;
        private bool _moveRight;
        private Vector3 _targetPosition;

        private void Start()
        {
            _children = new LinkedList<Box>();
            var boxes =  GetComponentsInChildren<Box>();

            foreach (var t in boxes)
                _children.AddLast(t);
        }

        private void Update()
        {
            if (_moveLeft || _moveRight)
                transform.position = Vector3.MoveTowards(transform.position, _targetPosition, speed * Time.deltaTime);

            if (transform.position.x <= _targetPosition.x)
                _moveLeft = false;

            if (transform.position.x >= _targetPosition.x)
                _moveRight = false;
        }

        public void MoveToLeft()
        {
            _moveLeft = true;
            var position = transform.position;
            position.x -= offset;
            _targetPosition = position;


            var firstElem = _children.First;
            var lastElem = _children.Last;

            _children.RemoveFirst();

            var newPosition = lastElem.Value.transform.position;
            newPosition.x += offset;

            firstElem.Value.transform.position = newPosition;

            _children.AddLast(firstElem);
        }

        public void MoveToRight()
        {
            _moveRight = true;
            var position = transform.position;
            position.x += offset;
            _targetPosition = position;

            var firstElem = _children.First;
            var lastElem = _children.Last;

            _children.RemoveLast();

            var newPosition = firstElem.Value.transform.position;
            newPosition.x -= offset;

            lastElem.Value.transform.position = newPosition;

            _children.AddFirst(lastElem);
        }
    }
}