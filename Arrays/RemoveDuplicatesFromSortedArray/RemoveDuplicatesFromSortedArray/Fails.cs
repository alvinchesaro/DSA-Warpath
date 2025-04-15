// // See https://aka.ms/new-console-template for more information
// string[] pLanguages = {"Perl", "Python", "Java", "JS", "C++", "C"};
// int[] numbers = {1, 34, 25, 23442, 56, 56, 56, 100};


// Console.WriteLine("Position 0: "+ pLanguages[0]);
// Console.WriteLine("Position 5: "+ pLanguages[5]);

// pLanguages[0] = "Prolog";
// pLanguages[1] = "Lisp";

// foreach (string i in pLanguages)
// {
//     Console.WriteLine(i);
// }
// // Array Length
// Console.WriteLine("Length of Array: " + pLanguages.Length);

// for (int x = 0; x < pLanguages.Length; x++){
//     Console.WriteLine("Index of " + x + " Value: " + pLanguages[x]);
// }
// // Using PreBuilt Method
// Array.Sort(numbers);

// foreach (int i in numbers)
// {
//     Console.WriteLine(i);
// }

// // Linq Operations
// Console.WriteLine("Sum: " + numbers.Sum());
// Console.WriteLine("Max: " + numbers.Max());
// Console.WriteLine("Min: " + numbers.Min());


// // Resource Link - WebDevPro - C# Tutorial 13 - Array Operations
// // https://www.youtube.com/watch?v=MYk1itlp6-8


// // Using Bubble Sort
// // Resource Link - TutorialsPoint - C# Arrays
// // https://www.youtube.com/watch?v=daFdTssjm3w
// int temp;

// for (int i = 0; i < numbers.Length; i++)
// {
//     for (int j = 0; j < numbers.Length -1; j++)
//     {
//         // Compare Number to Its Next Counterpart
//         if (numbers[j] > numbers[j + 1]){
//             temp = numbers[j];
//             numbers[j] = numbers[j + 1];
//             numbers[j + 1] = temp; 
//         }
//     }
// }

// foreach (int i in numbers){
//     Console.WriteLine(i);
// }

// Console.ReadLine();