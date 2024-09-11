namespace HackerRankPractice {
    internal class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hello, max number checker!");

            //int maxVal = 0;

            //Random rand = new Random();

            //for (int i = 0; i < 10; i++) {
            //    int nbr = rand.Next(1, 100);
            //    Console.WriteLine($"nbr: {nbr}");
            //    maxVal = Math.Max(maxVal, nbr);
            //}

            //Console.WriteLine($"maxVal {maxVal}");

            // int[] nbrs = [2,7,11,15];
            // int[] nbrs = [3,2,4];
            int[] nbrs = [3,3];
            int[] idxs = TwoSum(nbrs, 6);
            Console.WriteLine($"idxs = {PrintIt(idxs)}");


        }

        public static string PrintIt(int[] nbrs ) {
            string retStr = "";
            foreach(int nbr in nbrs) {
                retStr += nbr + " ";
            }
            return retStr;
        }
        public static int[] TwoSum(int[] nums, int target) {
            int[] idxs = [];
            for (int i = 0; i < nums.Length; i++) {
                if (idxs.Length > 0) {
                    break;
                }
                for (int j = 0; j < nums.Length; j++) {
                    if (j == i) {
                        continue;
                    }
                    else if (nums[i] + nums[j] == target) {
                            Console.WriteLine($"target!: {i}:{nums[i]} + {j}:{nums[j]}");
                            idxs = [i, j];
                            break;
                    }
                }
            }
            return idxs;
        }

    }
}
