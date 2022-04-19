using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display(){
      string hiddenPass = "";
      if(Hidden == true){
        foreach(char c in this.Password){
          hiddenPass += '*';
        }
        Console.WriteLine(hiddenPass);
      }
      else{
        Console.WriteLine(this.Password);
      }
    }

    public void Reset(){
      this.Hidden = false;
      this.Password = "";
    }

  }
}