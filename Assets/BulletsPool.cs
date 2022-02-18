using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsPool : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] int poolSize;

    [SerializeField] Queue<Bullet> bullet;
    private void Start()
    {
       bullet = new Queue<Bullet>();

        for(int i = 0; i < poolSize; i++)
        {
            Bullet obj = Instantiate(bulletPrefab);
            obj.gameObject.SetActive(false);
            bullet.Enqueue(obj);
        }
    }

    public void SpawnFromPool(Vector3 position, Quaternion rotation, Vector3 vector3, int power)
    {
        Bullet bulletToSpawn = bullet.Dequeue();

        bulletToSpawn.gameObject.SetActive(true);
        bulletToSpawn.transform.position = position;
        bulletToSpawn.transform.rotation = rotation;
        bulletToSpawn.Init(vector3, power);
        bullet.Enqueue(bulletToSpawn);
    }

}
