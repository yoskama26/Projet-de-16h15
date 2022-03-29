using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
    const int MAX_USER = 1;
    const int MAX_OPERATION = 1;

    //instantiation gestionnaire
    GestionBancaire manager = new GestionBancaire();
    
  
    //instantiation banque
    BanquePhysique LaPost = new BanquePhysique();
    BanqueOnline Boursorama = new BanqueOnline();
    
    
    //instantiation users
    List<Utilisateur> users = new List<Utilisateur>();
  
    for(int i=0; i<= MAX_USER-1; i++){
      Utilisateur user = new Utilisateur();
      
      Console.WriteLine("Nom:");
      user.LastName = Console.ReadLine();
      Console.WriteLine("Prenom:");
      user.FirstName = Console.ReadLine();
      Console.WriteLine("votre solde:");
      user.Solde = int.Parse(Console.ReadLine());
      
      users.Add(user);
    }

    Console.WriteLine(users[0]+"\n");
    manager.addUser(users[0], bankPhysic: LaPost);

    List<OperationBancaire> operations = new List<OperationBancaire>();

    for(int i=0; i<= MAX_OPERATION-1; i++){
      OperationBancaire operation = new OperationBancaire();

      Console.WriteLine("type operation");
      operation.TypeOperation = Console.ReadLine();
      Console.WriteLine("date operation");
      operation.DateOperation = Console.ReadLine();
      
      operation.Retrait(users[0], 50);
      operations.Add(operation);
    }
      
    Console.WriteLine(operations[0]);
    manager.addOparation(users[0], operations[0]);
    Console.WriteLine(users[0]+"\n");

    //affichage listes utilisateur
    Console.WriteLine(manager.affichageUtilisateur(bankPhysic: LaPost));
  
  }
}