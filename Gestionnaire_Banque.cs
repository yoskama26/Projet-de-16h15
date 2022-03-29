using System;
using System.Collections;
using System.Collections.Generic;


class GestionBancaire{

  public string chaine;

  public void addUser(Utilisateur utilisateur, BanqueOnline bankOnline = null, BanquePhysique bankPhysic = null){
    if(bankOnline != null){
      bankOnline.users.Add(utilisateur);
    }
    if(bankPhysic != null){
      bankPhysic.users.Add(utilisateur);
    }
    
  }

  public void addOparation(Utilisateur utilisateur, OperationBancaire operationBancaire){
    utilisateur.operations.Add(operationBancaire);

  }
  
  public void affichageOperation(Utilisateur utilisateur){
    
 
}

