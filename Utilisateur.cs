using System;
using System.Collections.Generic;

class Utilisateur{

  public List<OperationBancaire> operations = new List<OperationBancaire>(); 

  private string first;
  private string last;
  private int solde;

  public Utilisateur(){
    solde = 0;
  }
  
  public string FirstName{
    get => first;
    set => first = value;
  }
  public string LastName{
    get => last;
    set => last = value; 
  }
  public int Solde{
    get => solde;
    set => solde = value;
  }
  
  public override string ToString(){
    return $"utilisateur : {FirstName} {LastName}, solde : {Solde}";
  }
}