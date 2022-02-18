using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFire : MonoBehaviour
{
    [SerializeField] Transform _spawnPoint;
    [SerializeField] BulletsPool bulletsPool;

    public void FireBullet(int power)
    {
        // Récupère un bullet de la pool
        bulletsPool.SpawnFromPool(_spawnPoint.transform.position, Quaternion.identity, _spawnPoint.TransformDirection(Vector3.right), power);
    }

}
