var alist = new int[] { 22, 53, 21, 67, 87, 65, 12, 34, 98, 56 };

var blist = MergeSort(alist);

var rsrs = 1;

int[] MergeSort(int[] array)
{
    if (array.Length <= 1)
        return array;

    var midIndex = array.Length / 2;

    var leftValues = array[..midIndex];

    var rightValues = array[midIndex..];

    leftValues = MergeSort(leftValues);

    rightValues = MergeSort(rightValues);

    int[] sortedValues = new int[(leftValues.Length + rightValues.Length)];

    var leftIndex = 0;

    var rightIndex = 0;

    var resultIndex = 0;

    while (leftIndex < leftValues.Length || rightIndex < rightValues.Length)
    {
        if (leftIndex < leftValues.Length && rightIndex < rightValues.Length)
        {
            if (leftValues[leftIndex] <= rightValues[rightIndex])
            {
                sortedValues[resultIndex] = leftValues[leftIndex];
                leftIndex++;
            }
            else
            {
                sortedValues[resultIndex] = rightValues[rightIndex];
                rightIndex++;
            }
        }
        else if (leftIndex < leftValues.Length)
        {
            sortedValues[resultIndex] = leftValues[leftIndex];
            leftIndex++;
        }
        else
        {
            sortedValues[resultIndex] = rightValues[rightIndex];
            rightIndex++;
        }

        resultIndex++;
    }

    return sortedValues;
}

int[] merge(int[] left, int[] right)
{
    int resultLength = right.Length + left.Length;
    int[] result = new int[resultLength];
    //
    int indexLeft = 0, indexRight = 0, indexResult = 0;
    //while either array still has an element
    while (indexLeft < left.Length || indexRight < right.Length)
    {
        //if both arrays have elements  
        if (indexLeft < left.Length && indexRight < right.Length)
        {
            //If item on left array is less than item on right array, add that item to the result array 
            if (left[indexLeft] <= right[indexRight])
            {
                result[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }
            // else the item in the right array wll be added to the results array
            else
            {
                result[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }
        }
        //if only the left array still has elements, add all its items to the results array
        else if (indexLeft < left.Length)
        {
            result[indexResult] = left[indexLeft];
            indexLeft++;
            indexResult++;
        }
        //if only the right array still has elements, add all its items to the results array
        else if (indexRight < right.Length)
        {
            result[indexResult] = right[indexRight];
            indexRight++;
            indexResult++;
        }
    }
    return result;
}

int[] Merge(int[] leftValues, int[] rightValues)
{
    int[] sortedValues = new int[(leftValues.Length + rightValues.Length)];


    var leftIndex = 0;

    var rightIndex = 0;

    var resultIndex = 0;

    while (leftIndex < leftValues.Length || rightIndex < rightValues.Length)
    {
        if (leftIndex < leftValues.Length && rightIndex < rightValues.Length)
        {
            if (leftValues[leftIndex] <= rightValues[rightIndex])
            {
                sortedValues[resultIndex] = leftValues[leftIndex];
                leftIndex++;
            }
            else
            {
                sortedValues[resultIndex] = rightValues[rightIndex];
                rightIndex++;
            }
        }
        else if (leftIndex < leftValues.Length)
        {
            sortedValues[resultIndex] = leftValues[leftIndex];
            leftIndex++;
        }
        else
        {
            sortedValues[resultIndex] = rightValues[rightIndex];
            rightIndex++;
        }

        resultIndex++;
    }

    // tempSortedValues.Concat(leftValues[leftIndex..]);
    // tempSortedValues.Concat(rightValues[rightIndex..]);

    return sortedValues;

}