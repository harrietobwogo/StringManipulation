using System;
using System.Collections.Generic;
using System.Text;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Console.WriteLine(RemoveDuplicates("geeksforgeeks"));
    Console.WriteLine(RemoveDuplicates("Hello World"));
  }
  public static string RemoveDuplicates(string str){
    HashSet<char> hs=new HashSet<char>();
    StringBuilder sb=new StringBuilder();
    for(int i=0; i<str.Length; i++){
      hs.Add(str[i]);
    }
     foreach(var c in hs){
       sb.Append(c);
     }
     return sb.ToString();

  }
}