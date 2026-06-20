using System.Net.Http; // Permet d’envoyer des requêtes HTTP (API Facebook)
using System.Text;     // Utile pour manipuler le texte (pas encore utilisé ici)

public class FacebookService
{
    // ID de ta page Facebook (à remplacer avec le vrai ID)
    private readonly string _pageId = "TU_PAGE_ID";

    // Token d'accès à l'API Facebook (authentification)
    private readonly string _accessToken = "TU_TOKEN";

    // Méthode qui publie un message sur Facebook
    public async Task Publier(string message)
    {
        // Création d'un client HTTP pour faire l’appel API
        using var client = new HttpClient();

        // Création du contenu du POST (format clé/valeur)
        var content = new FormUrlEncodedContent(new[]
        {
            // Le message à publier sur la page
            new KeyValuePair<string, string>("message", message),

            // Le token d’accès pour autoriser la requête
            new KeyValuePair<string, string>("access_token", _accessToken)
        });

        // Envoi de la requête POST vers l'API Graph de Facebook
        var response = await client.PostAsync(
            $"https://graph.facebook.com/{_pageId}/feed",
            content);

        // Affiche la réponse de Facebook (utile pour debug)
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
}