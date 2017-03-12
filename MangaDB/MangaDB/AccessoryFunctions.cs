using System.Linq;
using System.IO;

namespace MangaDB
{
    public struct NewsArticle
    {
        public string title;
        public string content;
    }
    public class AccessoryFunctions
    {
        public static string[] GetImages(string path)
        {
            return (
                from filePath
                in Directory.GetFiles(Startup.envPath + path, "*.jpg")
                select System.IO.Path.GetFileNameWithoutExtension(filePath)
            ).ToArray();
        }
        public static NewsArticle[] GetNews()
        {
            NewsArticle[] naa = new NewsArticle[5];
            naa[0].title = "Berserk Manga Returns on March 24";
            naa[0].content = "It's a good time to be a Berserk fan, especially if you dig both the new anime adaptation and Kentaro Miura's long-running manga. The former's second season premieres on April 7, and now we have an official date for the return of Miura's manga.";
            naa[1].title = "Masaaki Yuasa’s Lu Over the Wall Film Gets New Teaser";
            naa[1].content = "If there’s a prize for the hardest working person in anime, director Masaaki Yuasa is definitely in the running. The guy behind off-the-wall series like The Tatami Galaxy, Ping-Pong and one of anime’s first crowdsourced success stories, Kick-Heart, has not one but two full-length feature films coming out this year. There’s a new teaser out for one of those two films, Lu Over the Wall, so go Over the Jump and check it out.";
            naa[2].title = "Ancient Magus’ Bride Gets TV Anime This October";
            naa[2].content = "Folks who thought a mere three episodes was too few for The Ancient Magus’ Bride: it’s time to party. The popular manga series is set for a series adaptation this October.";
            naa[3].title = "Hunter x Hunter Creator’s Advice to Would-Be Manga-ka: Study Storytelling, Not Art";
            naa[3].content = "YuYu Hakusho and Hunter x Hunter creator Yoshihiro Togashi may take more hiatuses than his fans would like, but with two of the most successful shonen franchises ever under his belt, there’s no doubt aspiring manga creators have something to learn from the guy. Now a piece of advice from Togashi aimed at would-be manga - ka is making the Japanese social media rounds, and it’s an interesting one.";
            naa[4].title = "Romance Anime Tsuki ga Kirei Premiere Date Revealed";
            naa[4].content = "We have been remiss in reporting any news on Tsuki ga Kirei (The Moon is Beautiful), the new romance anime from studio feel., but the announcement of its airdate has given us a chance to correct that error. Dig into the kirei details below.";
            return naa;
        }
    }
}
