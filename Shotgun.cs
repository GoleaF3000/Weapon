using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private float _scatter;    

    private float _tempValueY;

    public override void Shoot(Transform shootPoint)
    {
        _tempValueY = shootPoint.position.y;            
        shootPoint.position = new Vector2(shootPoint.position.x, shootPoint.position.y - _scatter * 2);        

        for (int i = 0; i < 3; i++)
        {
            shootPoint.position = new Vector2(shootPoint.position.x, shootPoint.position.y + _scatter);
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);            
        }

        shootPoint.position = new Vector2(shootPoint.position.x, _tempValueY);
    }
}
