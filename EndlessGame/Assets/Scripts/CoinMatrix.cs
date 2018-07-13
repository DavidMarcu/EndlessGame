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

        matrix.Add(new Vector2(0,0));
        matrix.Add(new Vector2(-1, -1));
        matrix.Add(new Vector2(1, -1));
        matrix.Add(new Vector2(0, -2));

        return matrix;
    }

    private static List<Vector2> MatrixTwo()
    {
        List<Vector2> matrix = new List<Vector2>();

        matrix.Add(new Vector2(-2, 0));
        matrix.Add(new Vector2(-3, -1));
        matrix.Add(new Vector2(-1, -1));
        matrix.Add(new Vector2(-2, -2));

        return matrix;
    }

    private static List<Vector2> MatrixThree()
    {
        List<Vector2> matrix = new List<Vector2>();

        matrix.Add(new Vector2(2, 0));
        matrix.Add(new Vector2(1, -1));
        matrix.Add(new Vector2(3, -1));
        matrix.Add(new Vector2(2, -2));

        return matrix;
    }

    private static List<Vector2> MatrixFour()
    {
        List<Vector2> matrix = new List<Vector2>();

        matrix.Add(new Vector2(0, 0));
        matrix.Add(new Vector2(-1, -1));
        matrix.Add(new Vector2(-2, -2));
        matrix.Add(new Vector2(-3, -3));
        matrix.Add(new Vector2(-4, -4));

        matrix.Add(new Vector2(1, -1));
        matrix.Add(new Vector2(0, -2));
        matrix.Add(new Vector2(-1, -3));
        matrix.Add(new Vector2(-2, -4));
        matrix.Add(new Vector2(-3, -5));

        matrix.Add(new Vector2(2, -2));
        matrix.Add(new Vector2(1, -3));

        matrix.Add(new Vector2(3, -3));
        matrix.Add(new Vector2(2, -4));

        matrix.Add(new Vector2(4, -4));
        matrix.Add(new Vector2(3, -5));

        return matrix;
    }

}
