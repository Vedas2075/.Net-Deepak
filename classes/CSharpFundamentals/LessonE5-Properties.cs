// using System;
// public class Person
// {
//     string name;
//     // Full property syntax
//     public string Name
//     {
//         get
//         {
//             return name;
//         }
//         set
//         {
//             if (value.Length > 2)
//                 name = value;
//         }
//     }

//     // Auto implemeted property
//     public DateTime Dob { get; set; }

//     // Readonly property
//     public string Address { get; set; }

//     // Default value
//     public char Gen { get; set; } = 'F';
//     public Gender Sex { get; private set; } = Gender.Female;
// }

// public enum Gender
// {
//     Male,
//     Female,
//     Others   
// }