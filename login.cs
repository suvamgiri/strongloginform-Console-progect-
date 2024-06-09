using System;

using System.Linq;

class Program{

  public static void Main(string[] args){
    
bool invalid = true;

    int contain=0;
    while(invalid!){
      contain++;

      if(contain==4){
        invalid = false;
      }
string email= Console.ReadLine();

    char[] number ={'1', '2', '3', '4', '5', '6', '7', '8', '9','0'};
    char[] specail= {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')'};
      
if(email.Length>6 || email.Length<16){
if(email.Any(c=> number.Contains(c))){
  if(email.Contains("@")){

    if(email.Contains(".")){
      while(invalid!){
contain++;

      
string password = Console.ReadLine();

if(password.Length>4 && password.Length<16){
          if(contain==4){
          invalid = false;
        }

  if(password.Any(c=> number.Contains(c))){
        if(contain==4){
          invalid = false;
        }
 
      
    if(password.Any(c=>specail.Contains(c))){
      Console.WriteLine("your password is created seacessfully");
        if(contain==4){
          invalid = false;
        }
    
     
    }
    else{
      Console.WriteLine("password must contain a specail character");
    }
  }
  else{
    Console.WriteLine("please enter a number also");
  }
}else{
Console.WriteLine("please enter more then 4");
  
}

      }
      
    }else{
    Console.WriteLine("email need to be contain .");
    }
  }
  else{
    Console.WriteLine(" email need to be conteind the @");
  }
}else{
  Console.WriteLine("email need to be contained the number");
}
}
  

  else{
Console.WriteLine("please enter the email again");

  
}
      }
  }
}
