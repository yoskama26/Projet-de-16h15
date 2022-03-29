using System;
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
  
  public string affichageUtilisateur(BanqueOnline bankOnline = null, BanquePhysique bankPhysic = null){
    if(bankOnline != null){
      for (int i = 0; i <= bankOnline.users.Count; i++)
      {
        chaine += bankOnline.users[i]; 
      }
    return chaine;
    }
    
    if(bankPhysic != null){
      for (int i = 0; i <= bankPhysic.users.Count; i++)
      {
        chaine += bankPhysic.users[i]; 
      }
    return chaine; 
    }

  return "User not found";
  }
 
}

