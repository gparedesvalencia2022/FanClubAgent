public class FanClubAgent
{
    // Service d’intelligence artificielle
    // Sert à générer du contenu (ex: posts Facebook)
    private readonly IaService _ia;

    // Service qui fournit les matchs du jour
    private readonly MatchService _match;

    // Service responsable de publier sur Facebook
    private readonly FacebookService _facebook;

    // Constructeur de la classe
    // Permet d'injecter les dépendances nécessaires à l’agent
    public FanClubAgent(IaService ia, MatchService match, FacebookService facebook)
    {
        _ia = ia;              // On assigne le service IA
        _match = match;        // On assigne le service des matchs
        _facebook = facebook;  // On assigne le service Facebook
    }

    // Méthode principale de l’agent
    // Elle exécute toute la logique automatiquement
    public async Task Run()
    {
        // Récupération de la liste des matchs du jour
        var matchs = _match.GetMatchsDuJour();

        // Boucle sur chaque match
        foreach (var match in matchs)
        {
            // Génération d’un post avec l’intelligence artificielle
            // Le contenu est basé sur le match actuel
            var post = await _ia.GenerarPost(match);

            // Publication du post sur Facebook
            //await _facebook.Publier(post);
            Console.WriteLine(post);

            // Affichage dans la console pour suivi/debug
            Console.WriteLine("Publicado: " + match);

            // Pause de 5 secondes entre chaque publication
            // pour éviter le spam ou les limites de l’API Facebook
            await Task.Delay(5000);
        }
    }
}