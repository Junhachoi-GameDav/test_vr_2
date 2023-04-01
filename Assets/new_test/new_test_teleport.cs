using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_test_teleport : MonoBehaviour
{
    public int point;
    Vector3 CalculateQuadraticBezier(Vector3 p0, Vector3 p1, Vector3 p2, float t)
    {
        return (1 - t) * (1 - t) * p0 + 2 * t * p1 * (1 - t) + t * t * p2;
    }

    Vector3 CalculateLinearBezier(Vector3 p0, Vector3 p1, float t)
    {
        return (1 - t) * p0 + t * p1;
    }
    /*
    private void DrawLinearCurve()
    {
        for (int i = 1; i < point + 1; i++)
        {
            float t = i / (float)point;
            positions[i - 1] = CalculateLinearBezier(point0.position, point1.position, t);
        }

        line.SetPositions(positions);
    }
    */
}
