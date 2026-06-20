public class MatchService
{
    // Méthode qui retourne la liste des matchs du jour
    public List<string> GetMatchsDuJour()
    {
        // On retourne une liste de matchs (pour l’instant codée en dur)
        return new List<string>
        {
            // Match entre les Pays-Bas et la Suède
            "Pays-Bas vs Suède",

            // Match entre l’Allemagne et la Côte d’Ivoire
            "Allemagne vs Côte d’Ivoire",

            // Match entre l’Équateur et Curaçao
            "Équateur vs Curaçao",

            // Match entre la Tunisie et le Japon
            "Tunisie vs Japon"
        };
    } //return File.ReadAllLines("matchs.txt").ToList();
}
/*
 public List<string> GetMatchsDuJour()
{
    var today = DateTime.Now.DayOfWeek;

    if (today == DayOfWeek.Saturday)
    {
        return new List<string>
        {
            "Pays-Bas vs Suède",
            "Allemagne vs Côte d’Ivoire"
        };
    }

    return new List<string>();
}*/