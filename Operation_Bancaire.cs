using System;
using System.Collections.Generic;
// 
class OperationBancaire{

  private string typeOperation;
  private string dateOperation;
  
  public string TypeOperation{
    get => typeOperation;
    set => typeOperation = value;
  }
  
  public string DateOperation{
    get => dateOperation;
    set => dateOperation = value;
  }

  public void Retrait(Utilisateur utilisateur, int amount){  //utiliser generique
    if(utilisateur.Solde <= 0){
      throw new SoldeIsNegativeOrNullException("Vous ne pouvez pas faire de retrait car votre solde est negative");
    }else{
      utilisateur.Solde -= amount;
    }
  
  }
  public void Crediter(Utilisateur utilisateur, int amount){
    utilisateur.Solde += amount;
  }
  public void Afficher(){}

  public void Historique(){} 

  public override string ToString(){
    return $"operation : {TypeOperation}, fait le {DateOperation}";
  }
}
public class SoldeIsNegativeOrNullException : Exception{
  public SoldeIsNegativeOrNullException(string message): base(message){
    
  }
}