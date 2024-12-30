using UnityEngine;

public class AnimTestController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private bool _off = false;
    [SerializeField] private bool _walk = false;

    private void OffAnimation()
    {
        _animator.SetBool("Walk", false);
    }

    void Update()
    {
        if (_off)
        {
            OffAnimation();
            _off = false;
        }

        if (_walk)
        {
            _animator.SetBool("Walk", true);
        }
    }
}