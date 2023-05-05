using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _pointMove;
    [SerializeField] private Animator _animator;

    private Vector3 _target;
    private int _currentIndex;

    private void Start()
    {
        _target = _pointMove[0].position;
    }

    private void Update()
    {
        MoveTowards();
        CheckTarget();
    }

    private void MoveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        Vector2 moveX = _target - transform.position;
        ChecKSide(moveX.x);
        
    }

    private void ChecKSide(float moveX)
    {
        if (moveX == 0) return;

        float scaleX = transform.localScale.x;

        scaleX = moveX > 0 ? Mathf.Abs(scaleX) : Mathf.Abs(scaleX) * (-1);

        transform.localScale = new Vector2(scaleX, transform.localScale.y);
    }

    private void CheckTarget()
    {
        if(transform.position == _target)
        {
            ChangTarget();
        }
    }

    private void ChangTarget()
    {
        _currentIndex++;

        if(_currentIndex >= _pointMove.Length)
        {
            _currentIndex = 0;
        }

        _target = _pointMove[_currentIndex].position;
    }
}
