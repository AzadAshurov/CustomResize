using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
int[] arr ={1,2,3,4};
CustomResize(ref arr,5,6,7);
for(int i = 0; i<arr.Length;i++){
Console.WriteLine(arr[i]); } }

public static  void CustomResize( ref int[] arr, params int[] nums){
int[] arrTwo = new int[arr.Length + nums.Length];
for(int i = 0; i<arr.Length;i++){
arrTwo[i]=arr[i];
}
for(int i = arr.Length; i<arr.Length + nums.Length; i++){
arrTwo[i]=nums[i-arr.Length];}

arr = arrTwo;
}}
