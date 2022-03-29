using System;
using System.Collections;
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
    get {
      return first;
    }
    set{
      first = value;
    }
  }
  public string LastName{
    get{
      return last;
    }
    set{
      last = value;
    }
  }
  public int Solde{
    get{
      return solde;
    } 
    set{
      solde = value;
    }
  }
  
  public override string ToString(){
    return $"{FirstName} {LastName}, solde : {Solde}";
  }
}