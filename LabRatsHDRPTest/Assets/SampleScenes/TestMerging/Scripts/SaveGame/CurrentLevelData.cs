using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CurrentLevelData
{
    private static bool newGame = true;
    private static int id = 0;
    private static float[] checkpointCoords = new float[3] { -0.3f, 0.1f, 2.4f };


public static int Id { get => id; set => id = value; }
    public static float[] CheckpointCoords { get => checkpointCoords; set => checkpointCoords = value; }
    public static bool NewGame { get => newGame; set => newGame = value; }
}
