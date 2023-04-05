namespace 测试专用2
{
        class Program
        {
            static int[] ChangeReference(int[] arr)
            {
                arr = new int[] { 9, 9, 9 };
                Console.WriteLine("Inside method: " + string.Join(",", arr));
                return arr;
            }

            static void Main(string[] args)
            {
                int[] t = new int[] { 1, 2, 3 };
                //ChangeReference(t);
                Console.WriteLine("Outside method: " + string.Join(",", ChangeReference(t)));
            }
        }
    
}