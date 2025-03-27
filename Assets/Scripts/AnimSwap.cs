using UnityEngine;
public class AnimSwap : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private int _animNumber;

    private void Start()
    {
        _animNumber = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        { 
            _animNumber = 1; 
            AnimSwaper(_animNumber);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _animNumber = 2;
            AnimSwaper(_animNumber);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _animNumber = 3;
            AnimSwaper(_animNumber);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _animNumber = 4;
            AnimSwaper(_animNumber);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _animNumber = 5;
            AnimSwaper(_animNumber);
        }
    }

    private void AnimSwaper(int swaperNumber)
    {
        _anim.SetInteger("AnimNumber", swaperNumber);
    }

    
}
