using System;

class TernarySearch
{
    static int TernarySearchAlgorithm(int[] arr, int left, int right, int key)
    {
        if (right >= left)
        {
            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3;

            if (arr[mid1] == key)
                return mid1;

            if (arr[mid2] == key)
                return mid2;

            if (key < arr[mid1])
                return TernarySearchAlgorithm(arr, left, mid1 - 1, key);
            else if (key > arr[mid2])
                return TernarySearchAlgorithm(arr, mid2 + 1, right, key);
            else
                return TernarySearchAlgorithm(arr, mid1 + 1, mid2 - 1, key);
        }

        return -1;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int key = 11;
        int result = TernarySearchAlgorithm(arr, 0, arr.Length - 1, key);

        if (result == -1)
            Console.WriteLine("Elemento não encontrado");
        else
            Console.WriteLine("Elemento encontrado no índice: " + result);
    }
}
