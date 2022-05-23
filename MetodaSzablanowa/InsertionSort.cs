using System;

public abstract class InsertionSort {
	public void Sort(ref int[] arr){
		for (int i = 0; i < arr.Length; i++)
		{
			var number = arr[i];
			var Index = i - 1;
			while (Index >=0 && Comparator(arr[Index], number))
			{
				arr[Index+1] = arr[Index];
				Index--;
			}

			arr[Index+1] = number;
		}
	}

	public abstract bool Comparator(int a, int b);

}
