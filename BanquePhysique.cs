using System;
using System.Collections;
using System.Collections.Generic;

class BanquePhysique{

  public List<Utilisateur> users = new List<Utilisateur>(); 

  private string name;
  private string address;

  public List<Utilisateur> Users this[int index]
  {
    get => users[index];
    set => users[index] = value;
  }

  public string Name{
    get => name;
    set => name = value;
  }
  public string Address{
    get => address; 
    set => address = value;
  }
  
  public override string ToString(){
    return $"Banque : {Name}, adresse : {Address}";
  }
}