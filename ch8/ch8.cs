using System;
using static System.Console;
using System.Linq;

class HW8 {
    static int Main(string[] args) {
        //exercise 1:
        int first = 1;
        int middle = 5;
        int last =99;
        Swap3(ref first, ref middle, ref last);
        WriteLine("first: {0}, last {1}", first, last);

        //exercise 2:
        int max ;
        int min;
        int[] nums = new int[10];
        IntegerFacts(out max, out min,  nums);
        WriteLine(string.Join(" ", nums));
        WriteLine("max is {0}, min is {1}", max, min);

        //exercise 7:
        Averages(1,5, 12);
        Averages(1,5, 13, 14, 17);
        Averages(1,5, 13,10, 100, 1000, 911,999);

        //exercise 8:
        // you know what to do...

       //challenges
       string[] roster1 = {"John", "Jill", "Jessica"};
       string[] roster2 = {"jill", "john", "johhny"};
       bool same = areRostersIdentical(roster1, roster2);

       int[] roster3 ={100, 200};
       int[] roster4 = {200, 100};

       bool same2 = areRostersIdentical(roster3, roster4);

       //calling optional/default parameter
       float area = calcCircleArea(10.0f, 3.14159265258979f);
       WriteLine("the area is {0}", area);
        return 0;
    }

    static void Swap3( ref int first, ref int mid, ref int last){
        mid = first;
        first = last;
        last = mid;
    }

    static void IntegerFacts(out int max, out int min, int[] nums){
        int COUNT = 10;
        int SENTINEL = 911;
        int cnt = 0;
        do {
            WriteLine("Give me one more number");
            //int n = Convert.ToInt32(ReadLine());  //normal way to convert/cast from string to integer
            int n ;
            //second way to cast from string to integer
            bool successful = int.TryParse(ReadLine(), out n);
            if( !successful){
                WriteLine("Invalid entry");
                continue;  //skip current iteration, come back to the loop
            }
            if (n == SENTINEL)
                break;  //completely break out of the loop
            nums[cnt] = n;
            cnt++;
        }while(cnt < COUNT);

        max = nums.Max();
        min = nums.Min();
    }

    //exercise 7 think of 'params'
    static void Averages(params int[] nums){
        int sum =0;
        foreach (int n in nums){
            sum += n;
        }
        int mean = sum / nums.Length;
        WriteLine("The average is {0}", mean);
    }

    //method overloading
    static bool areRostersIdentical(string[] roster1, string[] roster2){
       
        Array.Sort(roster1);
        Array.Sort(roster2);
        string s1 = string.Join(" ", roster1).ToUpper();
        string s2 = string.Join(" ", roster2).ToUpper();
        return s1.Equals(s2);
    }
    //method overloading
    
    static bool areRostersIdentical(int[] roster1, int[] roster2){
        Array.Sort(roster1);
        Array.Sort(roster2);

        if (roster1.Length != roster2.Length )
            return false;
        else {
            for (int i = 0; i < roster1.Length; i++) {
                if (roster1[i] != roster2[i])
                    return false;
            }
            return true;
        }
    }

    //optional parameters (aka default parameter)
    static float calcCircleArea(float radius, float pi = 3.14f) {
        return radius*radius*pi;
    }
}