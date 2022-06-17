using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animu.Data.Migrations
{
    public partial class SeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "Id", "ImageUrl", "Synopsis", "Title" },
                values: new object[,]
                {
                    { new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), "https://cdn.myanimelist.net/images/anime/8/77831l.jpg", "After dying a laughable and pathetic death on his way back from buying a game, high school student and recluse Kazuma Satou finds himself sitting before a beautiful but obnoxious goddess named Aqua. She provides the NEET with two options: continue on to heaven or reincarnate in every gamer's dream—a real fantasy world! Choosing to start a new life, Kazuma is quickly tasked with defeating a Demon King who is terrorizing villages. But before he goes, he can choose one item of any kind to aid him in his quest, and the future hero selects Aqua. But Kazuma has made a grave mistake—Aqua is completely useless! Unfortunately, their troubles don't end here; it turns out that living in such a world is far different from how it plays out in a game. Instead of going on a thrilling adventure, the duo must first work to pay for their living expenses. Indeed, their misfortunes have only just begun!", "Kono Subarashii Sekai ni Shukufuku wo!" },
                    { new Guid("abab9632-5b43-4fb9-8377-43b698686445"), "https://cdn.myanimelist.net/images/anime/7/88019l.jpg", "The final hour of the popular virtual reality game Yggdrasil has come. However, Momonga, a powerful wizard and master of the dark guild Ainz Ooal Gown, decides to spend his last few moments in the game as the servers begin to shut down. To his surprise, despite the clock having struck midnight, Momonga is still fully conscious as his character and, moreover, the non-player characters appear to have developed personalities of their own! Confronted with this abnormal situation, Momonga commands his loyal servants to help him investigate and take control of this new world, with the hopes of figuring out what has caused this development and if there may be others in the same predicament.", "Overlord" },
                    { new Guid("dac27489-f999-48ec-a8de-661d192b08eb"), "https://cdn.myanimelist.net/images/anime/1071/106675l.jpg", "The Fifth Holy Grail War in Fuyuki City has reached a turning point in which the lives of all participants are threatened as the hidden enemy finally reveals itself. As Shirou Emiya, Rin Toosaka, and Illyasviel von Einzbern discover the true, corruptive nature of the shadow that has been rampaging throughout the city, they realize just how dire the situation is. In order to protect their beloved ones, the group must hold their own against the seemingly insurmountable enemy force—even if some of those foes were once their allies, or perhaps, something more intimate. As the final act of this chaotic war commences, the ideals Shirou believes will soon be challenged by an excruciating dilemma: is it really possible to save a world where everything seems to have gone wrong?", "Fate/stay night: Heaven's Feel - III. Spring Song" },
                    { new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), "https://cdn.myanimelist.net/images/anime/7/72533l.jpg", "The seemingly unimpressive Saitama has a rather unique hobby: being a hero. In order to pursue his childhood dream, Saitama relentlessly trained for three years, losing all of his hair in the process. Now, Saitama is so powerful, he can defeat any enemy with just one punch. However, having no one capable of matching his strength has led Saitama to an unexpected problem—he is no longer able to enjoy the thrill of battling and has become quite bored.  One day, Saitama catches the attention of 19-year-old cyborg Genos, who witnesses his power and wishes to become Saitama’s disciple. Genos proposes that the two join the Hero Association in order to become certified heroes that will be recognized for their positive contributions to society. Saitama, who is shocked that no one knows who he is, quickly agrees. Meeting new allies and taking on new foes, Saitama embarks on a new journey as a member of the Hero Association to experience the excitement of battle he once felt.", "One Punch Man" },
                    { new Guid("9c571d74-b29c-4541-b396-e5d0770b9a46"), "https://cdn.myanimelist.net/images/anime/1065/117105l.jpg", "The Fifth Holy Grail War continues, and the ensuing chaos results in higher stakes for all participants. Shirou Emiya continues to participate in the war, aspiring to be a hero of justice who saves everyone. He sets out in search of the truth behind a mysterious dark shadow and its murder spree, determined to defeat it. Meanwhile, Shinji Matou sets his own plans into motion, threatening Shirou through his sister Sakura Matou. Shirou and Rin Toosaka battle Shinji, hoping to relieve Sakura from the abuses of her brother. But the ugly truth of the Matou siblings begins to surface, and many dark secrets are exposed. Fate/stay night Movie: Heaven's Feel - II. Lost Butterfly continues to focus on the remaining Masters and Servants as they fight each other in the hopes of obtaining the Holy Grail. However, as darkness arises within Fuyuki City, even the state of their sacred war could be in danger.", "Fate/stay night: Heaven's Feel - II. Lost Butterfly" },
                    { new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), "https://cdn.myanimelist.net/images/anime/5/79183l.jpg", "Eighth-grader Shigeo \"Mob\" Kageyama has tapped into his inner wellspring of psychic prowess at a young age. But the power quickly proves to be a liability when he realizes the potential danger in his skills. Choosing to suppress his power, Mob's only present use for his ability is to impress his longtime crush, Tsubomi, who soon grows bored of the same tricks. In order to effectuate control on his skills, Mob enlists himself under the wing of Arataka Reigen, a con artist claiming to be a psychic, who exploits Mob's powers for pocket change. Now, exorcising evil spirits on command has become a part of Mob's daily, monotonous life. However, the psychic energy he exerts is barely the tip of the iceberg; if his vast potential and unrestrained emotions run berserk, a cataclysmic event that would render him completely unrecognizable will be triggered. The progression toward Mob's explosion is rising and attempting to stop it is futile.", "Mob Psycho 100" },
                    { new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), "https://cdn.myanimelist.net/images/anime/1441/122795l.jpg", "Corrupt politicians, frenzied nationalists, and other warmongering forces constantly jeopardize the thin veneer of peace between neighboring countries Ostania and Westalis. In spite of their plots, renowned spy and master of disguise \"Twilight\" fulfills dangerous missions one after another in the hope that no child will have to experience the horrors of war. In the bustling Ostanian city of Berlint, Twilight dons the alias of \"Loid Forger,\" an esteemed psychiatrist. However, his true intention is to gather intelligence on prominent politician Donovan Desmond, who only appears rarely in public at his sons' school: the prestigious Eden Academy. Enlisting the help of unmarried city hall clerk Yor Briar to act as his wife and adopting the curious six-year-old orphan Anya as his daughter, Loid enacts his master plan. He will enroll Anya in Eden Academy, where Loid hopes she will excel and give him the opportunity to meet Donovan without arousing suspicion. Unfortunately for Loid, even a man of his talents has trouble playing the figure of a loving father and husband. And just like Loid is hiding his true identity, Yor—who is an underground assassin known as \"Thorn Princess\"—and Anya—an esper who can read people's minds—have no plans to disclose their own secrets either. Although this picture-perfect family is founded on deception, the Forgers gradually come to understand that the love they share for one another trumps all else.", "Spy x Family" },
                    { new Guid("f50a5dbd-8fcf-4977-90d9-fd416b1ffff5"), "https://cdn.myanimelist.net/images/anime/1883/117106l.jpg", "The Holy Grail War: a violent battle between mages in which seven masters and their summoned servants fight for the Holy Grail, a magical artifact that can grant the victor any wish. Nearly 10 years ago, the final battle of the Fourth Holy Grail War wreaked havoc on Fuyuki City and took over 500 lives, leaving the city devastated. Shirou Emiya, a survivor of this tragedy, aspires to become a hero of justice like his rescuer and adoptive father, Kiritsugu Emiya. Despite only being a student, Shirou is thrown into the Fifth Holy Grail War when he accidentally sees a battle between servants at school and summons his own servant, Saber. When a mysterious shadow begins a murderous spree in Fuyuki City, Shirou aligns himself with Rin Toosaka, a fellow participant in the Holy Grail War, in order to stop the deaths of countless people. However, Shirou's feelings for his close friend Sakura Matou lead him deeper into the dark secrets surrounding the war and the feuding families involved.", "Fate/stay night: Heaven's Feel - I. Presage Flower" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0207d09a-18ed-4216-b1f8-1a09d7d9a8c2", "77af0181-ea5d-4358-92ab-c768cb900b85", "User", "USER" },
                    { "07090e31-f8aa-483b-beab-d6283397f417", "d30205b4-57a2-4878-8902-1a09327ccc9a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02e1a366-d7fe-40de-97d1-75609b134609", 0, "3aa6bc49-bb3e-4c79-882a-adf3a4fb6f12", "user@abv.bg", false, true, null, "USER@ABV.BG", "USER@ABV.BG", "AQAAAAEAACcQAAAAECZFsYqsEL3pyQMswJFXTHyyAz38cg4HquY5t+3UsmlFOcL8s4qlaEpBcWdwzBmggw==", null, false, "WCJAHPAJPP25QOL6QKTSBLBQVJLWDKXG", false, "user@abv.bg" },
                    { "852e04c1-3bed-47e3-83f1-91bd27665215", 0, "978785aa-63dd-40be-a891-8fbe66e4da17", "admin@abv.bg", false, true, null, "ADMIN@ABV.BG", "ADMIN@ABV.BG", "AQAAAAEAACcQAAAAEC4yWooIOwEVd+yOsNYSBiDXGIV16ZqeeTqOBRUe8KdxdqoNi2/Ev8uu78ubZcsfJw==", null, false, "4OETGRAEQCBGW2N3J5EM36QY4XIZPWGV", false, "admin@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c8706d54-6814-4a77-9edd-04fc36dce612"), "Comedy" },
                    { new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976"), "Action" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "07090e31-f8aa-483b-beab-d6283397f417", "852e04c1-3bed-47e3-83f1-91bd27665215" },
                    { "0207d09a-18ed-4216-b1f8-1a09d7d9a8c2", "02e1a366-d7fe-40de-97d1-75609b134609" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "AnimeId", "Number", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("a43c2816-e471-4754-bec0-d87742ddfcc4"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 5, "The Ultimate Mentor", "https://rapid-cloud.ru/embed-6/Ll3bzNuIuy87" },
                    { new Guid("c65a5457-b7e2-48f7-be7f-de6b1ce8a044"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 3, "The Obsessive Scientist", "https://rapid-cloud.ru/embed-6/gqLR3t46hUiu" },
                    { new Guid("8556adba-fcf7-4d84-96f8-f45d2a09ed4b"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 8, "The Deep Sea King", "https://rapid-cloud.ru/embed-6/NwuICrNNKF7L" },
                    { new Guid("3993668c-b04f-49bb-b837-02c89909cfe4"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 8, "The Older Brother Bows: Destructive Intent", "https://rapid-cloud.ru/embed-6/Zo7KpQEPMTri" },
                    { new Guid("b89d0ea5-1d1a-40e7-817a-07b38e5b609a"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 10, "The Heinous Aura: Mastermind", "https://rapid-cloud.ru/embed-6/EwgQL0ZTdRyP" },
                    { new Guid("13c2721d-83ff-436c-a1fb-0b8edc270df7"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 5, "Ochimusa: Psychic Powers and Me", "https://rapid-cloud.ru/embed-6/Pkur7ZX2Aq4z" },
                    { new Guid("42f1bdda-2032-44bb-ba7f-1b9e93daa996"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 1, "Self-Proclaimed Psychic Reigen Arataka: And Mob", "https://rapid-cloud.ru/embed-6/bWIC8dlQixTs" },
                    { new Guid("fb99035b-9f98-4ac4-8d10-32208ae5a0d2"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 11, "Master: Leader", "https://rapid-cloud.ru/embed-6/7vfTxR11Zuc9" },
                    { new Guid("9605a205-07c1-4fdf-944a-3ac610258fd2"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 7, "Exaltation: I've Obtained Loss", "https://rapid-cloud.ru/embed-6/k67I3HTiCbCD" },
                    { new Guid("06666464-bba4-40b1-af25-84c962d7f05a"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 9, "\"Claw\": 7th Division", "https://rapid-cloud.ru/embed-6/DHNd1gyPo8sq" },
                    { new Guid("db9ce3e0-8f72-4298-98fe-90c0860b653f"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 6, "Discord: To Become One", "https://rapid-cloud.ru/embed-6/fpQ12LYUDlr5" },
                    { new Guid("78082805-b3ea-4992-bc90-b37ec7c58e6b"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 4, "Idiots Only Event: Kin", "https://rapid-cloud.ru/embed-6/J6lzLG1T2C4L" },
                    { new Guid("af9ac3f1-23ea-4d16-9d6a-cdce86d5934b"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 2, "Doubts About Youth: The Telepathy Club Appears", "https://rapid-cloud.ru/embed-6/FTID8eN7bmaf" },
                    { new Guid("fc10a19e-7fe7-48be-b0c5-f1d0d62bdcf7"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 3, "An Invite to a Meeting: Simply Put, I Just Want to Be Popular", "https://rapid-cloud.ru/embed-6/s8tiCNwNc6YD" },
                    { new Guid("adfc1b37-f553-4f8d-b764-f453d406aab1"), new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), 12, "Mob and Reigen: A Giant Tsuchinoko Appears", "https://rapid-cloud.ru/embed-6/ipXtooFVN5G8" },
                    { new Guid("416a5b51-e36d-4c49-a74e-1c1fb1b7e4dc"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 4, "The Prestigious School's Interview", "https://rapid-cloud.ru/embed-6/ZK7GX6YoAjhy" },
                    { new Guid("dd3465ad-0f09-48f8-b026-2d05eb481bf7"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 8, "The Counter-Secret Police Cover Operation", "https://rapid-cloud.ru/embed-6/BQgUFsmlH6qI" },
                    { new Guid("93013965-f4e1-40f4-8af1-52cb7fc654a0"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 1, "Operation〈Strix〉", "https://rapid-cloud.ru/embed-6/Cx2LxhSjvzIl" },
                    { new Guid("575a7183-ef82-4d12-901c-59c319c5f2a2"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 6, "The Friendship Scheme", "https://rapid-cloud.ru/embed-6/opRXdgfY7WYZ" },
                    { new Guid("dfbfb49f-cfa2-41d4-b761-5b4063be1529"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 3, "Prepare for the Interview", "https://rapid-cloud.ru/embed-6/Aj1qF2XU6mcW" },
                    { new Guid("57ceaba5-9478-4dc8-be16-822eb2178808"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 10, "The Great Dodgeball Plan", "https://rapid-cloud.ru/embed-6/OVFpoAF0UD9O" },
                    { new Guid("429d3c6a-e661-45b7-bc3f-89886e62e57c"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 9, "Show Off How in Love You Are", "https://rapid-cloud.ru/embed-6/yLi5ZDECJvvP" },
                    { new Guid("a34bf3d1-04f8-40bf-8fe8-a6d83258f034"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 5, "Will They Pass or Fail", "https://rapid-cloud.ru/embed-6/qRmlFup6t81H" },
                    { new Guid("846636da-9f99-4996-848e-ad70f862fa66"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 2, "Secure a Wife", "https://rapid-cloud.ru/embed-6/Us7g0JAeiZHa" },
                    { new Guid("730b50af-c3dc-4a42-a05c-f40625f45d14"), new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), 7, "The Target's Second Son", "https://rapid-cloud.ru/embed-6/JoQtIAC6IKft" },
                    { new Guid("a7151915-aeac-435f-80af-796a27ce01d0"), new Guid("f50a5dbd-8fcf-4977-90d9-fd416b1ffff5"), 1, "Full", "https://rapid-cloud.ru/embed-6/bpKOub3l6Gm1" },
                    { new Guid("da333d65-d81d-4146-a7ee-9c53a61b85de"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 2, "The Lone Cyborg", "https://rapid-cloud.ru/embed-6/xpsSYz8hVnbH" },
                    { new Guid("398ef1aa-b97d-42b3-aba3-825ec775e605"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 7, "The Ultimate Disciple", "https://rapid-cloud.ru/embed-6/dwXXQaNdQERR" },
                    { new Guid("75b038d2-7b2a-4dd7-b6f2-5fb10c176d9e"), new Guid("9c571d74-b29c-4541-b396-e5d0770b9a46"), 1, "Full", "https://rapid-cloud.ru/embed-6/jE9bfWi1qXON" },
                    { new Guid("4f82bcad-64f4-4c8f-9232-4d5ec50c7af8"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 4, "The Modern Ninja", "https://rapid-cloud.ru/embed-6/E39nLWDhxN4c" },
                    { new Guid("33ebeebf-b22c-4ad3-8393-2b58d469a26c"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 9, "God's Blessing on This Wonderful Shop!", "https://rapid-cloud.ru/embed-6/bDSsVvwvF1lb" },
                    { new Guid("68749189-fa2a-4bf3-afae-2fd5fe3b732b"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 5, "A Price for This Cursed Sword!", "https://rapid-cloud.ru/embed-6/1SnPE2DneFfJ" },
                    { new Guid("286d2695-4841-4c2b-a11f-6c6a281f771f"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 4, "Explosion Magic for This Formidable Enemy!", "https://rapid-cloud.ru/embed-6/mRMoDddXkslG" },
                    { new Guid("618bc35d-5dda-450e-b918-84fe748f6d45"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 7, "A Second Death in This Freezing Season!", "https://rapid-cloud.ru/embed-6/yddK4WkNwozl" },
                    { new Guid("10cdcae2-c578-4cdd-a6fc-ce4382b74f1f"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 10, "Final Flame for This Over-the-Top Fortress!", "https://rapid-cloud.ru/embed-6/hcugTYnowxbM" },
                    { new Guid("5ec138a9-73af-416c-8d60-d9a926248b71"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 6, "A Conclusion to This Worthless Fight!", "https://rapid-cloud.ru/embed-6/uhlbzQBxVNTP" },
                    { new Guid("afd7eaaa-e818-4003-99fa-e85ec34ada97"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 3, "A Panty Treasure in This Right Hand!", "https://rapid-cloud.ru/embed-6/lZlteKlBUBSx" },
                    { new Guid("c4600512-ce9a-4d52-8b51-ec5a95741b10"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 2, "An Explosion for This Chunibyo!", "https://rapid-cloud.ru/embed-6/FNyOwCh68gIl" },
                    { new Guid("3b27a9e4-d3b7-4f12-aa84-7fa478cae2f6"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 10, "Unparalleled Peril", "https://rapid-cloud.ru/embed-6/VEk1CxisgBAk" },
                    { new Guid("699d9a1a-247e-4008-9bcc-0571dcef2862"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 2, "Floor Guardians", "https://rapid-cloud.ru/embed-6/vPQM1RP3AN0D" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "AnimeId", "Number", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("a376844d-e59d-4998-a915-114cedf2c972"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 9, "The Dark Warrior", "https://rapid-cloud.ru/embed-6/CBwLjsNUjVxM" },
                    { new Guid("d1f8cb2b-3b01-4b66-aa34-30f283228fe5"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 8, "Twin Swords of Slashing Death", "https://rapid-cloud.ru/embed-6/RBVvIoXkxOO6" },
                    { new Guid("27440846-c2cb-44e7-b3d2-4c9304e48335"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 3, "Battle at Carne Village", "https://rapid-cloud.ru/embed-6/vIVR9y88VCiR" },
                    { new Guid("8020b824-19c9-4614-bf65-52c6a7295b1e"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 12, "The Bloody Valkyrie", "https://rapid-cloud.ru/embed-6/mZihm4ohYKZx" },
                    { new Guid("b0fd5dd6-7f79-437c-b59f-f1f949a8d375"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 8, "A Loving Hand for Out Party When We Can't Make It Through Winter!", "https://rapid-cloud.ru/embed-6/NAR8odfd096D" },
                    { new Guid("403d0f80-3466-4d66-ac54-76af1706472a"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 1, "End and Begging", "https://rapid-cloud.ru/embed-6/xdOEopgCoCcU" },
                    { new Guid("e5ae251e-ed37-46c8-a77b-75bd6868b538"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 11, "Confusion and Understanding", "https://rapid-cloud.ru/embed-6/VMQrtpfgWCIc" },
                    { new Guid("13994651-c4e3-4df0-b9be-22a11c8459ae"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 6, "The Terrifying City", "https://rapid-cloud.ru/embed-6/m4dOAkVTjaST" },
                    { new Guid("ffb9c0e6-a0e3-44df-9a41-1e2a60b67b50"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 11, "The Dominator of the Universe", "https://rapid-cloud.ru/embed-6/qSgtNZSAvqSN" },
                    { new Guid("30ae2e53-6ace-4f22-a4bc-1724cfa57ec7"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 1, "The Strongest Man", "https://rapid-cloud.ru/embed-6/cUMvPNAPKyWu" },
                    { new Guid("60c25d57-3552-4a0f-93fc-0a47e368d4a4"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 12, "The Strongest Hero", "https://rapid-cloud.ru/embed-6/imChvKvSHNP7" },
                    { new Guid("be647c99-fcd1-4485-9768-54299e17d82a"), new Guid("dac27489-f999-48ec-a8de-661d192b08eb"), 1, "Full", "https://rapid-cloud.ru/embed-6/TdDzKPpzhXLV" },
                    { new Guid("28cb4451-4035-4e7b-8514-22dd43156a7b"), new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), 9, "Unyielding Justice", "https://rapid-cloud.ru/embed-6/E2YWSUjxdehK" },
                    { new Guid("173d44d4-4b0b-4562-b8b4-d03be69d2276"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 6, "Journey", "https://rapid-cloud.ru/embed-6/SoHCsvdCrE4Y" },
                    { new Guid("f337c35e-5736-4364-ba33-dd5d19aa358f"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 10, "True Vampire", "https://rapid-cloud.ru/embed-6/xLOTRSQX3LSr" },
                    { new Guid("b6454f33-ce23-420f-9100-a4306027cbfb"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 13, "Player VS Non Player Character", "https://rapid-cloud.ru/embed-6/XvOTzmIfmqmW" },
                    { new Guid("3c66f509-4808-4842-b0bd-1e1525b3e576"), new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), 1, "The Self-Proclaimed Goddess and Reincarnation in Another World!", "https://rapid-cloud.ru/embed-6/a3seTc4fpCKx" },
                    { new Guid("c24f422f-295e-4e6e-b0d4-bc75fcdd1b4a"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 5, "Two Adventurers", "https://rapid-cloud.ru/embed-6/Yr4L8CNpZ8sg" },
                    { new Guid("72a25996-5caa-4377-aa0d-c71fa728db72"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 4, "Ruler of Death", "https://rapid-cloud.ru/embed-6/6p36OszqNlVY" },
                    { new Guid("1032c177-0d48-43a7-ab66-b949cea78bf2"), new Guid("abab9632-5b43-4fb9-8377-43b698686445"), 7, "Wise King of Forest", "https://rapid-cloud.ru/embed-6/TZfmSzIGXojU" }
                });

            migrationBuilder.InsertData(
                table: "TagAnimes",
                columns: new[] { "AnimeId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") },
                    { new Guid("abab9632-5b43-4fb9-8377-43b698686445"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") },
                    { new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") },
                    { new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") },
                    { new Guid("abab9632-5b43-4fb9-8377-43b698686445"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") },
                    { new Guid("dac27489-f999-48ec-a8de-661d192b08eb"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") },
                    { new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") },
                    { new Guid("9c571d74-b29c-4541-b396-e5d0770b9a46"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") },
                    { new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") },
                    { new Guid("f50a5dbd-8fcf-4977-90d9-fd416b1ffff5"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") },
                    { new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0207d09a-18ed-4216-b1f8-1a09d7d9a8c2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0207d09a-18ed-4216-b1f8-1a09d7d9a8c2", "02e1a366-d7fe-40de-97d1-75609b134609" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07090e31-f8aa-483b-beab-d6283397f417", "852e04c1-3bed-47e3-83f1-91bd27665215" });

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("06666464-bba4-40b1-af25-84c962d7f05a"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("1032c177-0d48-43a7-ab66-b949cea78bf2"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("10cdcae2-c578-4cdd-a6fc-ce4382b74f1f"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("13994651-c4e3-4df0-b9be-22a11c8459ae"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("13c2721d-83ff-436c-a1fb-0b8edc270df7"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("173d44d4-4b0b-4562-b8b4-d03be69d2276"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("27440846-c2cb-44e7-b3d2-4c9304e48335"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("286d2695-4841-4c2b-a11f-6c6a281f771f"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("28cb4451-4035-4e7b-8514-22dd43156a7b"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("30ae2e53-6ace-4f22-a4bc-1724cfa57ec7"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("33ebeebf-b22c-4ad3-8393-2b58d469a26c"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("398ef1aa-b97d-42b3-aba3-825ec775e605"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("3993668c-b04f-49bb-b837-02c89909cfe4"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("3b27a9e4-d3b7-4f12-aa84-7fa478cae2f6"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("3c66f509-4808-4842-b0bd-1e1525b3e576"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("403d0f80-3466-4d66-ac54-76af1706472a"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("416a5b51-e36d-4c49-a74e-1c1fb1b7e4dc"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("429d3c6a-e661-45b7-bc3f-89886e62e57c"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("42f1bdda-2032-44bb-ba7f-1b9e93daa996"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("4f82bcad-64f4-4c8f-9232-4d5ec50c7af8"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("575a7183-ef82-4d12-901c-59c319c5f2a2"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("57ceaba5-9478-4dc8-be16-822eb2178808"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("5ec138a9-73af-416c-8d60-d9a926248b71"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("60c25d57-3552-4a0f-93fc-0a47e368d4a4"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("618bc35d-5dda-450e-b918-84fe748f6d45"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("68749189-fa2a-4bf3-afae-2fd5fe3b732b"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("699d9a1a-247e-4008-9bcc-0571dcef2862"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("72a25996-5caa-4377-aa0d-c71fa728db72"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("730b50af-c3dc-4a42-a05c-f40625f45d14"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("75b038d2-7b2a-4dd7-b6f2-5fb10c176d9e"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("78082805-b3ea-4992-bc90-b37ec7c58e6b"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("8020b824-19c9-4614-bf65-52c6a7295b1e"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("846636da-9f99-4996-848e-ad70f862fa66"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("8556adba-fcf7-4d84-96f8-f45d2a09ed4b"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("93013965-f4e1-40f4-8af1-52cb7fc654a0"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("9605a205-07c1-4fdf-944a-3ac610258fd2"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("a34bf3d1-04f8-40bf-8fe8-a6d83258f034"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("a376844d-e59d-4998-a915-114cedf2c972"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("a43c2816-e471-4754-bec0-d87742ddfcc4"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("a7151915-aeac-435f-80af-796a27ce01d0"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("adfc1b37-f553-4f8d-b764-f453d406aab1"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("af9ac3f1-23ea-4d16-9d6a-cdce86d5934b"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("afd7eaaa-e818-4003-99fa-e85ec34ada97"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("b0fd5dd6-7f79-437c-b59f-f1f949a8d375"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("b6454f33-ce23-420f-9100-a4306027cbfb"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("b89d0ea5-1d1a-40e7-817a-07b38e5b609a"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("be647c99-fcd1-4485-9768-54299e17d82a"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("c24f422f-295e-4e6e-b0d4-bc75fcdd1b4a"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("c4600512-ce9a-4d52-8b51-ec5a95741b10"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("c65a5457-b7e2-48f7-be7f-de6b1ce8a044"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("d1f8cb2b-3b01-4b66-aa34-30f283228fe5"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("da333d65-d81d-4146-a7ee-9c53a61b85de"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("db9ce3e0-8f72-4298-98fe-90c0860b653f"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("dd3465ad-0f09-48f8-b026-2d05eb481bf7"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("dfbfb49f-cfa2-41d4-b761-5b4063be1529"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("e5ae251e-ed37-46c8-a77b-75bd6868b538"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("f337c35e-5736-4364-ba33-dd5d19aa358f"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("fb99035b-9f98-4ac4-8d10-32208ae5a0d2"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("fc10a19e-7fe7-48be-b0c5-f1d0d62bdcf7"));

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("ffb9c0e6-a0e3-44df-9a41-1e2a60b67b50"));

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("abab9632-5b43-4fb9-8377-43b698686445"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), new Guid("c8706d54-6814-4a77-9edd-04fc36dce612") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("9c571d74-b29c-4541-b396-e5d0770b9a46"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("abab9632-5b43-4fb9-8377-43b698686445"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("dac27489-f999-48ec-a8de-661d192b08eb"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") });

            migrationBuilder.DeleteData(
                table: "TagAnimes",
                keyColumns: new[] { "AnimeId", "TagId" },
                keyValues: new object[] { new Guid("f50a5dbd-8fcf-4977-90d9-fd416b1ffff5"), new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976") });

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("0891b02f-6ed9-43b9-9f73-2848be072b20"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("4b3d577b-f39f-4d25-80a8-fc9015ca273e"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("6503eae0-a8c8-4a30-9b71-9d1f689aa5ce"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("9c571d74-b29c-4541-b396-e5d0770b9a46"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("abab9632-5b43-4fb9-8377-43b698686445"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("c08bdbf7-cd84-4351-be0d-f738c4e6955b"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("dac27489-f999-48ec-a8de-661d192b08eb"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("f50a5dbd-8fcf-4977-90d9-fd416b1ffff5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07090e31-f8aa-483b-beab-d6283397f417");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02e1a366-d7fe-40de-97d1-75609b134609");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "852e04c1-3bed-47e3-83f1-91bd27665215");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c8706d54-6814-4a77-9edd-04fc36dce612"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c8880554-0cde-4c8a-9fe9-e65d227f4976"));
        }
    }
}
