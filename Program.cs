// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var nums = new int[]{2,7,11,15,3,4,28,5,20,12};
//var target = 9;

// var result = TwoSum(nums, target);

// if(result != null)
//     Console.WriteLine("AsnWriter is  " + result[0] + " "+ result[1]);
// else
//     Console.WriteLine("AsnWriter is  - Nothing found");

// var result = FindingRepeatingElements(nums);

// Console.WriteLine($"Answer is  - {result.ToString()}");

// var result = new Anagram().IsAnagram("pim","ipm");

var result = new LongestSubstringWithoutRepeatingChars().GetLongestSubstringWithoutRepeatingChars("reality");

Console.WriteLine($"Answer is  - {result.ToString()}");

Console.ReadLine();

//Two Sum
int[] TwoSum(int[] nums,int target)
{
for(int i=0; i < nums.Length; i++)
{
    for(int j=i; j < nums.Length; j++)
    {
      if(nums[i] + nums[j] == target)
        {
            return new int[2] {i,j};
        }
    }
}
return null;
}

//Return True If any value appears at least twice in an array. Else ,false

bool FindingRepeatingElements(int[] nums)
{
    HashSet<int> availableNumbers = new HashSet<int>();

    foreach(int num in nums)
    {
        if(availableNumbers.Contains(num))
        {
            return true;
        }

        availableNumbers.Add(num);
    }
    return false;
}