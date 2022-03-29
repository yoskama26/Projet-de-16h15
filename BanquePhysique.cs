using System;
using System.Collections.Generic;

class BanquePhysique{

  public List<Utilisateur> users = new List<Utilisateur>(); //voir indexer pour getter / setter mettre en private

  private string name;
  private string address;


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