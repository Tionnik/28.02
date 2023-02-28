int mass (int[] arr){
    int N=0;
    for (int i=0; i<arr.Length;i++){
        if (arr[i]>0) N++;
    }
return N;
}
Console.Clear();
Console.WriteLine("Введите массив");
int[] arr = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
Console.WriteLine($"[ {string.Join(" ", arr)} ]");
Console.WriteLine(mass(arr));