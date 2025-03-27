using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    [SerializeField] private GameObject[] _weapons;
    [SerializeField] private int _weaponIndex;

    private void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            if (_weaponIndex < _weapons.Length - 1)
            {
                _weapons[_weaponIndex].SetActive(false);
                _weaponIndex++;
                _weapons[_weaponIndex].SetActive(true);
            }
        }

        if (Input.mouseScrollDelta.y < 0)
        {
            if (_weaponIndex > 0)
            {
                _weapons[_weaponIndex].SetActive(false);
                _weaponIndex--;
                _weapons[_weaponIndex].SetActive(true);
            }
        }
    }
}
