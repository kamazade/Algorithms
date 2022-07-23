using System;

namespace InsertionSort
{
    class Program
    {
        public static int[] Insertion(int[] arr){
            
            for(int i = 1; i<arr.Length;i++){
                int step = i;
                while(step>0){
                    if(arr[step-1] > arr[step]){
                        int pre = arr[step-1];
                        arr[step-1] = arr[step] ;
                        arr[step] = pre;
                    }else{
                        break;
                    }
                    step--;
                }
            }


            return arr;
        }

        
        static void Main(string[] args)
        {
            int[] insertion = Insertion(new int[]{22,27,16,2,18,6});
        
            foreach (var item in insertion)
            {
                Console.WriteLine(item);
            }
        }
    }
}
