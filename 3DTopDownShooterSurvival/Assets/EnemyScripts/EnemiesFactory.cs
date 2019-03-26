using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesFactory : MonoBehaviour
{
    private void Awake()
    {
        //enemyTypes<enemy1> enemybill = new enemyTypes<enemy1>("Enemybill");
        //enemybill.scriptComponent.initialize(
        //    speed: 4,
        //    dir: Random.Range(0, 2) * 2 - 1,
        //    pos: new Vector3(1, 1, 1)
        //    );

        //enemyTypes<Enemy2> enemymask = new enemyTypes<Enemy2>("Enemymask");
        //enemymask.scriptComponent.initialize(
        //    speed:1,
        //    pos:new Vector3(1,1,1)
        //    );

        //enemyTypes<Enemy3> enemyghost = new enemyTypes<Enemy3>("Enemyghost");
        //enemyghost.scriptComponent.initialize(
        //    speed:2,
        //    pos:new Vector3(1,1,1)
        //    );


        //enemyTypes<Enemy4> enemylush = new enemyTypes<Enemy4>("Enemylush");
        //enemylush.scriptComponent.initialize(
        //    speed:Random.Range(6,18),
        //    pos:new Vector3(1,1,1)
        //    );


        //enemyTypes<Enemy5> enemytorque = new enemyTypes<Enemy5>("Enemytorque");
        //enemytorque.scriptComponent.initialize(
        //    speed:3,
        //    dir:Random.Range(0,2)*2-1,
        //    pos:new Vector3(1,1,1)
        //    );

        enemyTypes<Enemy6> enemytweek = new enemyTypes<Enemy6>("Enemytweek");
        enemytweek.scriptComponent.initialize(
            speed:4,
            pos:new Vector3(1,1,1)
            );
    }

}
