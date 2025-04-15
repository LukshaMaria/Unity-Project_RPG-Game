using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMove : MonoBehaviour
{
    public float speed = 6f; //скорость движения соперника
    public GameObject[] checkpoints; //массив чек-поинтов
    private int checkpointId = 0; //номер чек-поинта
    float step; //шаг, с которым движется персонаж на сцене

    void Start()
    {
        step = speed * Time.deltaTime;
        checkpoints = GameObject.FindGameObjectsWithTag("checkPoint");  
    }
}
