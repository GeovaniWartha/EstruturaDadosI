public static class MergeSorter
{
    public static void MergeSort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int[] tempArray = new int[arr.Length];
        MergeSort(arr, tempArray, 0, arr.Length - 1);
    }

    private static void MergeSort(int[] arr, int[] tempArray, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, tempArray, left, mid);
            MergeSort(arr, tempArray, mid + 1, right);
            Merge(arr, tempArray, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int[] tempArray, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
            {
                tempArray[k] = arr[i];
                i++;
            }
            else
            {
                tempArray[k] = arr[j];
                j++;
            }
            k++;
        }

        while (i <= mid)
        {
            tempArray[k] = arr[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            tempArray[k] = arr[j];
            j++;
            k++;
        }

        for (int l = left; l <= right; l++)
        {
            arr[l] = tempArray[l];
        }
    }
}
