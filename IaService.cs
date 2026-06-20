using OpenAI;         // Bibliothèque principale OpenAI
using OpenAI.Chat;    // Gestion des conversations (Chat)


public class IaService
{
    private static Random _random = new Random();

    public async Task<string> GenerarPost(string match)
    {
        // Simulamos latencia (como si fuera IA real)
        await Task.Delay(300);

        // Variantes de frases
        var intro = new[]
        {
            "⚜️ Québec en feu!",
            "🧢 Ambiance Coupe du Monde à Québec!",
            "⚜️🔥 La ville vibre déjà!",
            "🧢⚽ Préparez-vous Québec!"
        };

        var middle = new[]
        {
            $"Aujourd’hui: {match}",
            $"Match du jour: {match}",
            $"C’est l’heure de {match}",
            $"{match} – ça va être énorme!"
        };

        var outro = new[]
        {
            "Grande Allée prête à exploser ⚡",
            "Le centre-ville va vibrer 🌆",
            "Toute la ville en mode mondial ⚽",
            "Rassemblez-vous et vibrez ensemble ⚜️"
        };

        // Selección aleatoria
        var text =
            intro[_random.Next(intro.Length)] + "\n\n" +
            middle[_random.Next(middle.Length)] + "\n\n" +
            outro[_random.Next(outro.Length)];

        return text;
    }
}

//public class IaService
//{
//    // Client permettant de communiquer avec le modèle IA
//    private ChatClient _client;

//    // Constructeur : initialise le client avec le modèle et la clé API
//    public IaService(string apiKey)
//    {
//        _client = new ChatClient("gpt-4.1", apiKey);
//    }

//    // Méthode qui génère un post Facebook à partir d’un match
//    public async Task<string> GenerarPost(string match)
//    {
//        // Appel au modèle IA avec une conversation (system + user)
//        var response = await _client.CompleteChatAsync(
//            new ChatMessage[]
//            {
//                // Message système : définit le rôle et le style de l’agent
//                new SystemChatMessage("Tu es un community manager passionné de football à Québec. Écris en français québécois avec émotion ⚜️🧢"),

//                // Message utilisateur : demande de générer un post pour un match
//                new UserChatMessage(
//                    $"Créer un post Facebook pour le match suivant : {match}. " +
//                    "Style festif, parlant de Québec, Grande Allée et ambiance Coupe du Monde.")
//            }
//        );

//        // ✅ Lecture correcte de la réponse pour OpenAI 2.x
//        return response?.Value?.Content?[0]?.Text ?? "Erreur génération IA";       
//    }
//}