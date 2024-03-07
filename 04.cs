public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int[] mergedArray;
        mergedArray = MergeSortedArrays(nums1, nums2);

        double median = 0;
        if(mergedArray.Length % 2 == 0)
        {
            int index1 = mergedArray.Length / 2 - 1;
            int index2 = index1 + 1;
            median = (mergedArray[index1] + mergedArray[index2]) / 2d;
        }
        else
        {
            int index = mergedArray.Length / 2;
            median = mergedArray[index];
        }
        return median;
    }

    public int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            mergedArray[k++] = arr1[i] < arr2[j] ? arr1[i++] : arr2[j++];
        }

        while (i < arr1.Length)
        {
            mergedArray[k++] = arr1[i++];
        }

        while (j < arr2.Length)
        {
            mergedArray[k++] = arr2[j++];
        }

        return mergedArray;
    }
    
}