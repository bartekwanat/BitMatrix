using System;
using System.Collections;

// prostokątna macierz bitów o wymiarach m x n
namespace BitMatrixNameSpace;
public class BitMatrix
{
    private BitArray data;
    public int NumberOfRows { get; }
    public int NumberOfColumns { get; }
    public bool IsReadOnly => false;

    // tworzy prostokątną macierz bitową wypełnioną `defaultValue`
    public BitMatrix(int numberOfRows, int numberOfColumns, int defaultValue = 0)
    {
        if (numberOfRows < 1 || numberOfColumns < 1)
            throw new ArgumentOutOfRangeException("Incorrect size of matrix");
        data = new BitArray(numberOfRows * numberOfColumns, BitToBool(defaultValue));
        NumberOfRows = numberOfRows;
        NumberOfColumns = numberOfColumns;
    }

    


    public static int BoolToBit(bool boolValue) => boolValue ? 1 : 0;
    public static bool BitToBool(int bit) => bit != 0;

    

    public override string ToString()
    {
        string result = "";

        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int j = 0; j < NumberOfColumns; j++)
            {
               
                result += BoolToBit(data.Get(j)) + " ";
            }
            result += "\n"; 
        }
        return result;
    }

   
}