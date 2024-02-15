public class Etudiant{
        public string Nom{get; set;}
        public string Prenom{get;set;}
        
        public Etudiant(string nom,string prenom){
            Nom = nom;
            Prenom = prenom;
        }
        public override string ToString(){
            return $"Nom : {Nom}, Prenom : {Prenom}";
        }
}

