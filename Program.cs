class Program
{
    // Méthode principale du programme (point d'entrée)
    // "async" permet d'utiliser des appels asynchrones avec "await"
    static async Task Main()
    {
        // Création du service d'intelligence artificielle (le cerveau de l’agent)
        // On lui passe la clé API pour communiquer avec le modèle IA
        var ia = new IaService();//  IaService("TON_API_KEY");

        // Création du service qui fournit les matchs du jour
        // (pour l'instant, les matchs sont définis manuellement)
        var match = new MatchService();

        // Création du service qui permet de publier sur Facebook via l’API Graph
        var facebook = new FacebookService();

        // Création de l’agent principal
        // On injecte les dépendances : IA + Matchs + Facebook
        var agent = new FanClubAgent(ia, match, facebook);

        // Lancement de l’agent
        // Cette méthode va :
        // 1. Récupérer les matchs
        // 2. Générer des posts avec l’IA
        // 3. Publier automatiquement sur Facebook
        await agent.Run();
    }
}