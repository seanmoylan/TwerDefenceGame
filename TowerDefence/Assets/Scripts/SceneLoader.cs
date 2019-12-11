using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader: MonoBehaviour
{
    private static double spawnRateIncrement = 1.8;
    

    private static int sceneCount = 0;

    public double GetSpawnRate(){return spawnRateIncrement;}
}
