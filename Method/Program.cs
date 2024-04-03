int[] arrays = { 2, 3, 4, 5 };
int maxElement=arraymaxElement(arrays);

int arraymaxElement(int[] arrays){
    int maxElement = arrays[0];
    for (int i = 1; i < arrays.Length; i++)
    {
        if (arrays[i] > maxElement)
        {
            maxElement = arrays[i];
        }
    }
    return maxElement;
}
Console.WriteLine(maxElement);



