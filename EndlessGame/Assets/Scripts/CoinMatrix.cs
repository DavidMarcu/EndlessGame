using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMatrix {

    private static List<List<Vector2>> positions = new List<List<Vector2>>();

    public static List<List<Vector2>> loadPositions()
    {
        positions.Add(MatrixOne());
        positions.Add(MatrixTwo());
        positions.Add(MatrixThree());
        positions.Add(MatrixFour());

        return positions;
    }

    private static List<Vector2> MatrixOne()
    {
        List<Vector2> matrix = new List<Vector2>();

        matrix.Add(new Vector2(0,1));
        matrix.Add(new Vector2(-1, 0));
        matrix.Add(new Vector2(1, 0));
        matrix.Add(new Vector2(0, -1));

        return matrix;
    }

    private static List<Vector2> MatrixTwo()
    {
        List<Vector2> matrix = new List<Vector2>();

        matrix.Add(new Vector2(-2, 1));
        matrix.Add(new Vector2(-3, 0));
        matrix.Add(new Vector2(-1, 0));
        matrix.Add(new Vector2(-2, -1));

        return matrix;
    }

    private static List<Vector2> MatrixThree()
    {
        List<Vector2> matrix = new List<Vector2>();

        matrix.Add(new Vector2(2, 1));
        matrix.Add(new Vector2(1, 0));
        matrix.Add(new Vector2(3, 0));
        matrix.Add(new Vector2(2, -1));

        return matrix;
    }

    private static List<Vector2> MatrixFour()
    {
        List<Vector2> matrix = new List<Vector2>();

        matrix.Add(new Vector2(0, 2));
        matrix.Add(new Vector2(-1, 1));
        matrix.Add(new Vector2(-2, 0));
        matrix.Add(new Vector2(-3, -1));
        matrix.Add(new Vector2(-4, -2));

        matrix.Add(new Vector2(1, 1));
        matrix.Add(new Vector2(0, 0));
        matrix.Add(new Vector2(-1, -1));
        matrix.Add(new Vector2(-2, -2));
        matrix.Add(new Vector2(-3, -3));

        matrix.Add(new Vector2(2, 0));
        matrix.Add(new Vector2(1, -1));

        matrix.Add(new Vector2(3, -1));
        matrix.Add(new Vector2(2, -2));

        matrix.Add(new Vector2(4, -2));
        matrix.Add(new Vector2(3, -3));

        return matrix;
    }

}
