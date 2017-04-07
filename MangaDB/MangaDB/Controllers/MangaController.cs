using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MangaMetadata;

namespace MangaDB.Controllers
{
    public class MangaController : Controller
    {
        // MangaPage Controller
        public IActionResult MangaPage(string mangaName)
        {
            ViewData["mangaName"] = mangaName;
            return View();
        }
        public JsonResult GetMangaMetadata(string mangaName)
        {
            var metadata = new MangaInfo
            {
                name = "Bleach",
                japaneseName = "ブリーチ",
                author = "Tite Kubo",
                publisher = "Shueisha",
                volumeCount = 74,
                chapterCount = 686,
                imageUri = "/images/AdPanel/bakuman.jpg",
                website = "https://www.viz.com/bleach",
                fansite = "http://www.fanpop.com/clubs/bleach-anime"
            };
            return Json(metadata);

        }
        public JsonResult GetMangaSummary(string mangaName)
        {
            var metadata = new MangaSummary
            {
                name = "Bleach",
                summary = "Ichigo Kurosaki is a teenager who can see ghosts, a talent which lets him meet supernatural trespasser Rukia Kuchiki. Rukia is one of the Soul Reapers, soldiers trusted with ushering the souls of the dead from the World of the Living to the Soul Society (尸魂界（ソウル·ソサエティ） Sōru Sosaeti)—the afterlife realm from which she originates—and with fighting Hollows, monstrous lost souls who can harm both ghosts and humans. When she is severely wounded defending Ichigo from a Hollow she is pursuing, Rukia transfers her Spirit Pressure (霊圧 Reiatsu) to Ichigo so that he may fight in her stead while she recovers her strength. Rukia is thereby trapped in an ordinary human body, and must advise Ichigo as he balances the demands of his substitute Soul Reaper duties and attending high school. For aid in hunting the Hollows, the pair ally with a trio of other spiritually empowered teenagers: Ichigo's high school classmate Orihime Inoue, best friend Yasutora 'Chad' Sado, and the Quincy Uryū Ishida. Eventually, Rukia is arrested by her Soul Reaper superiors and sentenced to death for the illegal act of transferring her powers into a human. Ichigo and friends move to rescue her, and in order to enter the Soul Society they enlist the help ex-Soul Reaper scientist Kisuke Urahara, who enables Ichigo to access his own Soul Reaper powers. Shortly after the party's arrival in the Soul Society, conflict arises among the captains of 13 Court Squads when it seemed that captain Sōsuke Aizen is apparently murdered, and then Soul Society begins to fight amongst themselves. It is only at the climax of the rescue and on the verge of civil war that Aizen reappears, revealed to have faked his death and arranged Rukia's execution to obtain the Hōgyoku that Kisuke planted in Rukia's Gigai. Aizen is then joined by his fellow conspirators, Gin Ichimaru and Kaname Tōsen, as they use Hollows to cover their escape into the Hollows' world Hueco Mundo (虚圏 （ウェコムンド） Weko Mundo). From this point, Ichigo and Rukia are reconciled to the Soul Reapers, who view Ichigo as a powerful ally and designate him as an official Substitute Soul Reaper. Ichigo soon finds himself and his friends in escalating skirmishes with Aizen's army of humanoid Hollows, the Arrancars, as they are joined by the Visoreds, Soul Reapers who were among the victims of Aizen's experiments in creating Soul Reaper/Hollow hybrids. The Visoreds proceed to help Ichigo control his inner Hollow. When the Espada (Aizen's 10 most powerful Arrancars) kidnap Orihime, Ichigo and his allies enter Hueco Mundo to invade Aizen's palace Las Noches (虚夜宮 (ラス・ノーチェス） Rasu Nōchesu). However, as Ichigo rescues Orihime, Aizen reveals her abduction was a distraction as he and his strongest warriors launch an attack on Karakura Town as part of his plan to sacrifice the souls of the living to create an Ohken for his true goal: killing the Soul King who reigns over the Soul Society. Though the Visoreds join the Soul Reapers that remained to face their mutual enemy, Gin revealing his own agenda of assassinating him, Aizen reveals he used the Hōgyoku to become a Hollow-like being and overpowered everyone. But Ichigo, learning his father is a Soul Reaper and that Aizen has been manipulating his progress since birth, is ultimately able to subdue Aizen at the cost of his Soul Reaper powers and becomes a normal human. Months later, preparing for life after high school, Ichigo is called back into action when Xcution, a gang of Fullbringers—supernaturally aware humans like Chad—manipulate him and his loved ones in a scheme to siphon his Fullbring abilities. After his Soul Society allies restore his Soul Reaper status, learning that Xcution's leader Ginjo Kujo was his predecessor and that the Substitute Soul Reapers are not fully trusted, Ichigo defeats Ginjo while resolving to continue fighting with the Soul Society. In the final arc, an army of Quincies known as the Wandenreich appear and declare their own war on the Soul Society, after enslaving the Arrancars. The group is led by Yhwach, the ancient progenitor of the Quincies who was once worshipped as a god on earth. Yhwach has returned from long hibernation in the afterlife, and seeks to kill the Soul King like Aizen. In their first invasion, the Wandenreich killed many Soul Reapers with Head Captain Yamamoto among the deceased. Furthermore, as Uryū is recruited into the Wandenreich, Ichigo learns the truth that his abilities as both a Visored and a Fullbringer were because his mother was a Quincy who was indirectly affected by Aizen's experiments. After coping with the revelation, Ichigo and his friends aid the Soul Society in fighting the Wandenreich's second invasion as Yhwach proceeds to reach the Soul King's Palace in the ensuing chaos and, eventually, slays the Soul King. It is revealed that Uryu joined the Wandenreich as a means to get close to Yhwach, who was responsible for the death of his mother among other Quincies, and joins with Ichigo to fight the elite Quincies. In the final battle, Yhwach returns to the Soul Society in order to conquer it once and for all, but is met by Aizen who joins Ichigo, Renji, and Uryu. With the help of Ryuken Ishida's Still Silver, Uryu and Ichigo ultimately defeat Yhwach. Years later, Rukia becomes the new captain of the thirteenth company and has a daughter with Renji named Ichika. Aizen, who has been returned to his prison, has a monologue in which he offers a rebuttal to Yhwach's vision of a world without death, saying that without fear of death courage could not exist. Ichigo and Orihime have a son named Kazui, who is training to become a Soul Reaper like him."
            };
            return Json(metadata);
        }
        public JsonResult GetMangaChapters(string mangaName)
        {
            var chapters = new List<MangaChapter>();
            foreach(var v in Enumerable.Range(0, 686))
            {
                chapters.Add(new MangaChapter
                {
                    chapterNumber = v,
                    chapterName = "Sample Name " + v
                });
            }
            var volumes = new List<MangaVolume>();
            volumes.Add(new MangaVolume
            {
                volumeNumber = 1,
                chapters = chapters
            });
            var mangaChapters = new MangaChapters
            {
                name = "Bleach",
                volumes = volumes
            };
            return Json(mangaChapters);
        }
    }
}