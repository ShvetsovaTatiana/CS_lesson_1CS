int n = 10;
int[] arr = new int[n];

void FillArray(int[] arr)
{
    int i = 0;
    while (i < n)
    {
        arr[i] = i + 1;
        i++;
    }
}
FillArray(arr);

void PrintArray(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        Console.Write($"{arr[i]} ");
        i++;
    }
}

PrintArray(arr);

int GetSumOfElements(int[] arr)
{
    int i = 0;
    int sum = 0;
    while (i < arr.Length)
    {
        sum = sum + arr[i];
        i++;
    }
    return sum;
}
int sum = GetSumOfElements(arr);

Console.WriteLine(sum);

int GetProductOfElements(int[] arr)
{
    int i = 0;
    int product = 1;
    while (i < arr.Length)
    {
        product = product * arr[i];
        i++;
    }
    return product;
}

int product = GetProductOfElements(arr);

Console.WriteLine(product);