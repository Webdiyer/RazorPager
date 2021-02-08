﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Samples.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Gender", "IpAddress", "LastName" },
                values: new object[,]
                {
                    { 1, "abrandli0@ebay.co.uk", "Arturo", "M", "86.11.70.13", "Brandli" },
                    { 171, "mnewbegin4q@army.mil", "Melodee", "F", "82.229.115.6", "Newbegin" },
                    { 172, "drawlcliffe4r@nps.gov", "Dorene", "F", "250.171.166.36", "Rawlcliffe" },
                    { 173, "igouthier4s@abc.net.au", "Ingelbert", "M", "45.237.222.48", "Gouthier" },
                    { 174, "apinkerton4t@mapy.cz", "Addy", "M", "46.4.181.29", "Pinkerton" },
                    { 175, "cwilson4u@fda.gov", "Cornell", "M", "24.91.136.138", "Wilson" },
                    { 176, "nhatz4v@va.gov", "Nial", "M", "112.184.172.217", "Hatz" },
                    { 177, "ksowthcote4w@over-blog.com", "Kristopher", "M", "140.172.75.132", "Sowthcote" },
                    { 178, "mcorteney4x@weibo.com", "Mart", "M", "68.56.253.10", "Corteney" },
                    { 179, "srundall4y@photobucket.com", "Sandye", "F", "25.203.169.183", "Rundall" },
                    { 180, "deardley4z@google.es", "Danna", "F", "246.230.160.42", "Eardley" },
                    { 181, "gvannoni50@who.int", "Gerhardine", "F", "176.254.178.6", "Vannoni" },
                    { 182, "tkingsman51@springer.com", "Theobald", "M", "200.58.237.79", "Kingsman" },
                    { 183, "medscer52@rambler.ru", "Mirna", "F", "225.118.192.199", "Edscer" },
                    { 184, "mhemphrey53@ox.ac.uk", "Melanie", "F", "156.21.3.68", "Hemphrey" },
                    { 185, "misaac54@google.nl", "Merle", "M", "183.199.161.206", "Isaac" },
                    { 186, "eroches55@yahoo.com", "Emiline", "F", "224.17.1.109", "Roches" },
                    { 187, "bpecha56@nytimes.com", "Billy", "M", "234.50.251.170", "Pecha" },
                    { 188, "dungaretti57@aboutads.info", "Debby", "F", "110.42.108.26", "Ungaretti" },
                    { 189, "abrampton58@mapy.cz", "Antonius", "M", "180.55.155.240", "Brampton" },
                    { 190, "pstorrs59@ed.gov", "Pincas", "M", "67.139.158.156", "Storrs" },
                    { 191, "jrosone5a@moonfruit.com", "Jeddy", "M", "169.229.118.24", "Rosone" },
                    { 192, "jeastridge5b@unc.edu", "Janaye", "F", "60.151.47.173", "Eastridge" },
                    { 193, "tlangstaff5c@buzzfeed.com", "Trula", "F", "13.104.64.136", "Langstaff" },
                    { 194, "mcauson5d@mozilla.com", "Meggy", "F", "143.195.211.11", "Causon" },
                    { 195, "slambot5e@mapquest.com", "Stanislas", "M", "176.225.18.91", "Lambot" },
                    { 196, "medmund5f@xing.com", "Melody", "F", "127.63.30.60", "Edmund" },
                    { 197, "eoilier5g@ifeng.com", "Erwin", "M", "230.211.241.199", "OIlier" },
                    { 198, "pdury5h@netvibes.com", "Petrina", "F", "95.187.36.7", "Dury" },
                    { 199, "msayce5i@hibu.com", "Meriel", "F", "106.115.176.237", "Sayce" },
                    { 170, "zkiddey4p@woothemes.com", "Zed", "M", "36.246.0.6", "Kiddey" },
                    { 169, "sriddich4o@jalbum.net", "Sheppard", "M", "99.244.201.30", "Riddich" },
                    { 168, "ctims4n@weebly.com", "Courtney", "F", "106.175.213.155", "Tims" },
                    { 167, "mpennick4m@yahoo.com", "Merissa", "F", "61.74.61.152", "Pennick" },
                    { 137, "ogrzesiak3s@vk.com", "Oswald", "M", "141.165.84.23", "Grzesiak" },
                    { 138, "lwanek3t@about.com", "Lorens", "M", "63.76.225.213", "Wanek" },
                    { 139, "ashiell3u@timesonline.co.uk", "Aluino", "M", "65.53.114.71", "Shiell" },
                    { 140, "nrennenbach3v@redcross.org", "Nelli", "F", "126.167.153.25", "Rennenbach" },
                    { 141, "pdenton3w@lycos.com", "Patricio", "M", "31.194.144.30", "Denton" },
                    { 142, "mphilipet3x@networkadvertising.org", "Michele", "F", "245.62.253.134", "Philipet" },
                    { 143, "mgorbell3y@marriott.com", "Mathe", "M", "99.138.114.156", "Gorbell" },
                    { 144, "nwarboys3z@qq.com", "Noll", "M", "231.152.121.12", "Warboys" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Gender", "IpAddress", "LastName" },
                values: new object[,]
                {
                    { 145, "wmacdunlevy40@indiatimes.com", "Waldon", "M", "74.47.224.60", "MacDunlevy" },
                    { 146, "cdrage41@eventbrite.com", "Corie", "F", "18.87.171.77", "Drage" },
                    { 147, "nburgan42@mapquest.com", "Nalani", "F", "166.133.34.198", "Burgan" },
                    { 148, "fdominick43@google.fr", "Fenelia", "F", "167.138.99.190", "Dominick" },
                    { 149, "gjakoubek44@statcounter.com", "Ginger", "M", "243.133.162.170", "Jakoubek" },
                    { 150, "arobb45@g.co", "Allyson", "F", "222.117.88.117", "Robb" },
                    { 200, "sraithby5j@163.com", "Shepherd", "M", "216.84.107.92", "Raithby" },
                    { 151, "dfumagallo46@cpanel.net", "Daven", "M", "208.68.229.244", "Fumagallo" },
                    { 153, "fmerry48@blog.com", "Flem", "M", "118.55.83.89", "Merry" },
                    { 154, "pbodycombe49@prweb.com", "Pat", "F", "97.254.10.165", "Bodycombe" },
                    { 155, "ohalvorsen4a@cargocollective.com", "Otha", "F", "32.138.184.155", "Halvorsen" },
                    { 156, "wmcmurraya4b@bizjournals.com", "Wilmer", "M", "246.84.240.254", "McMurraya" },
                    { 157, "zmarkwelley4c@epa.gov", "Zechariah", "M", "202.229.9.157", "Markwelley" },
                    { 158, "mmcgrah4d@examiner.com", "Madelaine", "F", "135.106.100.252", "McGrah" },
                    { 159, "jchismon4e@last.fm", "Jenine", "F", "156.208.3.9", "Chismon" },
                    { 160, "tstanger4f@dmoz.org", "Tracie", "F", "166.114.241.116", "Stanger" },
                    { 161, "cstoak4g@dion.ne.jp", "Carmella", "F", "47.31.99.151", "Stoak" },
                    { 162, "tpryell4h@g.co", "Tobi", "F", "203.234.155.204", "Pryell" },
                    { 163, "sible4i@goo.gl", "Sharona", "F", "144.175.144.32", "Ible" },
                    { 164, "kgammons4j@youtu.be", "Konstantine", "M", "154.15.218.116", "Gammons" },
                    { 165, "weatherton4k@wikimedia.org", "Wendie", "F", "153.17.244.10", "Eatherton" },
                    { 166, "bbiddleston4l@baidu.com", "Beckie", "F", "120.102.70.146", "Biddleston" },
                    { 152, "izettoi47@google.com", "Irv", "M", "153.6.223.180", "Zettoi" },
                    { 201, "mbaumaier5k@behance.net", "Misti", "F", "107.129.75.142", "Baumaier" },
                    { 202, "rtrow5l@behance.net", "Rodrigo", "M", "248.88.141.226", "Trow" },
                    { 203, "gainscow5m@loc.gov", "Gherardo", "M", "187.227.23.136", "Ainscow" },
                    { 238, "rmuris6l@people.com.cn", "Rikki", "M", "49.96.65.206", "Muris" },
                    { 239, "sledur6m@china.com.cn", "Sarajane", "F", "73.197.190.147", "Ledur" },
                    { 240, "yrenfree6n@bing.com", "Yorgo", "M", "189.57.135.160", "Renfree" },
                    { 241, "frangeley6o@independent.co.uk", "Felic", "M", "50.120.90.111", "Rangeley" },
                    { 242, "kclowney6p@e-recht24.de", "Kahaleel", "M", "173.244.60.147", "Clowney" },
                    { 243, "tmaffin6q@blogspot.com", "Terry", "F", "91.15.123.197", "Maffin" },
                    { 244, "jarlidge6r@slideshare.net", "Jess", "M", "180.227.0.236", "Arlidge" },
                    { 245, "ewenderoth6s@sbwire.com", "Ellyn", "F", "151.217.104.135", "Wenderoth" },
                    { 246, "skear6t@fotki.com", "Sloan", "M", "92.22.169.36", "Kear" },
                    { 247, "mbrownbill6u@dot.gov", "Mina", "F", "125.124.59.39", "Brownbill" },
                    { 248, "ltalbot6v@deviantart.com", "Lowe", "M", "83.23.200.36", "Talbot" },
                    { 249, "kgrishelyov6w@g.co", "Ker", "M", "45.32.117.197", "Grishelyov" },
                    { 250, "afashion6x@amazon.de", "Aarika", "F", "245.177.135.113", "Fashion" },
                    { 251, "mbates6y@apache.org", "Marlow", "M", "97.61.141.54", "Bates" },
                    { 237, "tfenton6k@reference.com", "Tori", "F", "26.155.241.152", "Fenton" },
                    { 252, "uhildred6z@comcast.net", "Urban", "M", "69.209.21.165", "Hildred" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Gender", "IpAddress", "LastName" },
                values: new object[,]
                {
                    { 254, "tdimsdale71@discuz.net", "Tannie", "M", "9.160.112.221", "Dimsdale" },
                    { 255, "rgilli72@themeforest.net", "Rudiger", "M", "99.126.150.149", "Gilli" },
                    { 256, "rdahlman73@princeton.edu", "Rebecca", "F", "195.205.69.118", "Dahlman" },
                    { 257, "holenchenko74@devhub.com", "Haleigh", "M", "115.155.38.136", "Olenchenko" },
                    { 258, "cmullane75@1688.com", "Clem", "F", "48.29.181.142", "Mullane" },
                    { 259, "ipetrillo76@ifeng.com", "Ivy", "F", "253.7.155.250", "Petrillo" },
                    { 260, "ckaret77@cloudflare.com", "Cayla", "F", "129.71.43.248", "Karet" },
                    { 261, "rrey78@mediafire.com", "Rozanne", "F", "121.18.102.161", "Rey" },
                    { 262, "asaggs79@posterous.com", "Alla", "F", "196.222.230.8", "Saggs" },
                    { 263, "rmoreman7a@xrea.com", "Rudolf", "M", "145.213.191.15", "Moreman" },
                    { 264, "tmadge7b@umich.edu", "Tamas", "M", "142.23.72.228", "Madge" },
                    { 265, "ccottham7c@addtoany.com", "Cilka", "F", "58.45.100.111", "Cottham" },
                    { 266, "jsparway7d@independent.co.uk", "Jeana", "F", "204.38.59.255", "Sparway" },
                    { 267, "jbrozsset7e@smugmug.com", "Jedd", "M", "135.110.171.219", "Brozsset" },
                    { 253, "demerson70@dailymotion.com", "Dayna", "F", "209.125.83.251", "Emerson" },
                    { 136, "pcaudelier3r@unesco.org", "Phil", "F", "64.122.53.63", "Caudelier" },
                    { 236, "rskatcher6j@yellowbook.com", "Rory", "M", "180.25.192.37", "Skatcher" },
                    { 234, "fsjollema6h@auda.org.au", "Faith", "F", "191.145.72.44", "Sjollema" },
                    { 204, "mniche5n@dedecms.com", "Mohandis", "M", "80.0.173.14", "Niche" },
                    { 205, "mroyden5o@hubpages.com", "Maureen", "F", "45.230.52.19", "Royden" },
                    { 206, "geasun5p@qq.com", "Grove", "M", "247.91.74.220", "Easun" },
                    { 207, "cdelgardillo5q@indiegogo.com", "Crissy", "F", "68.137.218.225", "Delgardillo" },
                    { 208, "marmour5r@icio.us", "Maisie", "F", "153.49.121.159", "Armour" },
                    { 209, "vyanov5s@google.nl", "Vivien", "F", "53.2.230.173", "Yanov" },
                    { 210, "imactrustrie5t@geocities.com", "Iseabal", "F", "130.252.101.94", "MacTrustrie" },
                    { 211, "zleestut5u@psu.edu", "Zane", "M", "252.51.203.83", "LeEstut" },
                    { 212, "eziemke5v@usda.gov", "Edvard", "M", "121.60.247.163", "Ziemke" },
                    { 213, "kmcrobb5w@technorati.com", "Karon", "F", "34.132.181.253", "McRobb" },
                    { 214, "nhalgarth5x@npr.org", "Nanice", "F", "73.201.124.160", "Halgarth" },
                    { 215, "kgarvill5y@deviantart.com", "Konrad", "M", "189.117.252.24", "Garvill" },
                    { 216, "kbrant5z@alexa.com", "Katha", "F", "37.39.107.205", "Brant" },
                    { 217, "rrollason60@fda.gov", "Rube", "M", "35.178.151.159", "Rollason" },
                    { 235, "gworham6i@vistaprint.com", "Gabi", "F", "92.55.99.107", "Worham" },
                    { 218, "jgemeau61@feedburner.com", "Jacki", "F", "93.14.103.50", "Gemeau" },
                    { 220, "lduddan63@hatena.ne.jp", "Lalo", "M", "128.250.7.255", "Duddan" },
                    { 221, "rwoofinden64@tiny.cc", "Riva", "F", "115.128.240.237", "Woofinden" },
                    { 222, "jrubinsohn65@wordpress.com", "Johannes", "M", "202.181.18.229", "Rubinsohn" },
                    { 223, "fwarnes66@umich.edu", "Frants", "M", "228.104.137.149", "Warnes" },
                    { 224, "aling67@mtv.com", "Austin", "F", "76.63.134.107", "Ling" },
                    { 225, "sbowland68@msu.edu", "Shandra", "F", "235.172.10.192", "Bowland" },
                    { 226, "apury69@ezinearticles.com", "Andeee", "F", "197.149.248.206", "Pury" },
                    { 227, "soconnell6a@umich.edu", "Sander", "M", "111.122.33.188", "O'Connell" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Gender", "IpAddress", "LastName" },
                values: new object[,]
                {
                    { 228, "emessam6b@stumbleupon.com", "Eldon", "M", "40.25.194.151", "Messam" },
                    { 229, "ccord6c@utexas.edu", "Cristine", "F", "195.99.213.234", "Cord" },
                    { 230, "mstreather6d@answers.com", "Morley", "M", "124.13.128.5", "Streather" },
                    { 231, "slyal6e@trellian.com", "Sharleen", "F", "235.118.128.162", "Lyal" },
                    { 232, "ebrunn6f@dot.gov", "Erik", "M", "98.88.77.170", "Brunn" },
                    { 233, "dcamilli6g@sakura.ne.jp", "Doris", "F", "8.50.106.216", "Camilli" },
                    { 219, "kwethered62@dyndns.org", "Kamila", "F", "74.32.74.99", "Wethered" },
                    { 268, "premington7f@tripadvisor.com", "Pembroke", "M", "92.137.43.199", "Remington" },
                    { 135, "rmoncreiff3q@taobao.com", "Rowan", "M", "137.95.252.29", "Moncreiff" },
                    { 133, "habramovici3o@sakura.ne.jp", "Hermine", "F", "95.83.133.240", "Abramovici" },
                    { 36, "lmckaguez@boston.com", "Lucien", "M", "168.179.75.223", "McKague" },
                    { 37, "tthreadkell10@nature.com", "Taylor", "M", "149.75.21.38", "Threadkell" },
                    { 38, "predgrave11@rakuten.co.jp", "Pauly", "M", "72.102.176.141", "Redgrave" },
                    { 39, "gthomke12@china.com.cn", "Griswold", "M", "194.250.65.253", "Thomke" },
                    { 40, "fverdy13@vinaora.com", "Francine", "F", "198.65.3.83", "Verdy" },
                    { 41, "fgravey14@stanford.edu", "Faulkner", "M", "131.197.253.109", "Gravey" },
                    { 42, "jrawle15@seattletimes.com", "Jeffie", "M", "4.7.65.45", "Rawle" },
                    { 43, "jtatlowe16@squidoo.com", "Jacquette", "F", "210.229.36.157", "Tatlowe" },
                    { 44, "rgleaves17@cnet.com", "Reube", "M", "120.18.104.179", "Gleaves" },
                    { 45, "tvarvell18@psu.edu", "Toiboid", "M", "128.250.200.30", "Varvell" },
                    { 46, "obetser19@webmd.com", "Oberon", "M", "241.156.55.84", "Betser" },
                    { 47, "gdemaine1a@howstuffworks.com", "Gerhardt", "M", "167.37.88.214", "Demaine" },
                    { 48, "mproughten1b@usgs.gov", "Marilee", "F", "167.152.67.112", "Proughten" },
                    { 49, "mmarlon1c@nytimes.com", "Maribelle", "F", "5.169.210.222", "Marlon" },
                    { 50, "oalesbrook1d@yellowbook.com", "Olwen", "F", "67.227.239.150", "Alesbrook" },
                    { 51, "dprewett1e@trellian.com", "Delainey", "M", "234.56.48.126", "Prewett" },
                    { 52, "tmarrow1f@squidoo.com", "Torin", "M", "205.199.139.233", "Marrow" },
                    { 53, "anorgan1g@dedecms.com", "Augustin", "M", "56.201.170.21", "Norgan" },
                    { 54, "dclampe1h@macromedia.com", "Deina", "F", "6.233.69.108", "Clampe" },
                    { 55, "eschanke1i@zdnet.com", "Editha", "F", "91.41.30.249", "Schanke" },
                    { 56, "bmeany1j@google.cn", "Barris", "M", "251.105.176.169", "Meany" },
                    { 57, "ahave1k@flickr.com", "Andriana", "F", "197.69.11.124", "Have" },
                    { 58, "wprester1l@reuters.com", "Wilie", "F", "170.200.50.58", "Prester" },
                    { 59, "mtowner1m@indiatimes.com", "Massimiliano", "M", "70.187.147.59", "Towner" },
                    { 60, "lfumagall1n@wikimedia.org", "Lane", "M", "75.92.142.13", "Fumagall" },
                    { 61, "crosekilly1o@tmall.com", "Corie", "F", "131.150.102.68", "Rosekilly" },
                    { 62, "jpedracci1p@gov.uk", "Jo-anne", "F", "246.71.111.68", "Pedracci" },
                    { 63, "cdechelle1q@youku.com", "Cori", "M", "31.14.159.14", "Dechelle" },
                    { 64, "obrunotti1r@simplemachines.org", "Oliy", "F", "118.111.129.179", "Brunotti" },
                    { 35, "greiseny@domainmarket.com", "Gisela", "F", "81.27.232.0", "Reisen" },
                    { 34, "tpeax@yellowbook.com", "Terence", "M", "133.123.185.61", "Pea" },
                    { 33, "sbeamentw@ft.com", "Sayres", "M", "101.64.223.47", "Beament" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Gender", "IpAddress", "LastName" },
                values: new object[,]
                {
                    { 32, "bkenningleyv@blogger.com", "Benson", "M", "143.83.179.39", "Kenningley" },
                    { 2, "jjarley1@t.co", "Juli", "F", "85.229.109.174", "Jarley" },
                    { 3, "gbims2@exblog.jp", "Griswold", "M", "130.184.198.144", "Bims" },
                    { 4, "qstivani3@last.fm", "Quintus", "M", "175.37.47.243", "Stivani" },
                    { 5, "sreedie4@oaic.gov.au", "Sawyer", "M", "161.178.238.247", "Reedie" },
                    { 6, "ypoate5@usatoday.com", "Yevette", "F", "7.229.22.215", "Poate" },
                    { 7, "hironside6@umn.edu", "Heinrik", "M", "39.188.138.16", "Ironside" },
                    { 8, "bmelbourn7@ucla.edu", "Broderic", "M", "191.47.195.232", "Melbourn" },
                    { 9, "florenc8@123-reg.co.uk", "Forester", "M", "203.158.170.176", "Lorenc" },
                    { 10, "rsauniere9@go.com", "Raoul", "M", "155.136.153.120", "Sauniere" },
                    { 11, "bzanazzia@mac.com", "Bartlet", "M", "104.239.70.67", "Zanazzi" },
                    { 12, "smolyneauxb@wikia.com", "Suki", "F", "25.211.41.253", "Molyneaux" },
                    { 13, "jpearcec@arizona.edu", "Jakie", "M", "122.142.107.69", "Pearce" },
                    { 14, "mdominichettid@pagesperso-orange.fr", "Merrel", "M", "114.17.155.11", "Dominichetti" },
                    { 15, "mfolane@tmall.com", "Max", "F", "147.95.209.75", "Folan" },
                    { 65, "aloweth1s@webmd.com", "Augusto", "M", "238.64.212.71", "Loweth" },
                    { 16, "vwebbbowenf@hibu.com", "Vita", "F", "86.83.93.69", "Webb-Bowen" },
                    { 18, "sblumfieldh@techcrunch.com", "Salvidor", "M", "153.225.228.124", "Blumfield" },
                    { 19, "ctreagusi@google.it", "Coretta", "F", "162.84.170.241", "Treagus" },
                    { 20, "nlongwoodj@squarespace.com", "Nicoli", "F", "212.46.23.51", "Longwood" },
                    { 21, "rhallank@digg.com", "Ron", "M", "136.198.217.16", "Hallan" },
                    { 22, "tkaasmannl@mac.com", "Tootsie", "F", "108.57.14.226", "Kaasmann" },
                    { 23, "glemingm@sfgate.com", "Gearalt", "M", "237.106.207.72", "Leming" },
                    { 24, "cmenguyn@ucla.edu", "Claudine", "F", "232.145.168.110", "Menguy" },
                    { 25, "wshankstero@eventbrite.com", "Wylie", "M", "27.100.103.20", "Shankster" },
                    { 26, "fiskovp@mail.ru", "Frants", "M", "158.165.179.44", "Iskov" },
                    { 27, "srashleighq@wiley.com", "Starlene", "F", "211.111.63.34", "Rashleigh" },
                    { 28, "lstorerr@123-reg.co.uk", "Lind", "M", "231.49.50.103", "Storer" },
                    { 29, "dlangcasters@netlog.com", "Douglas", "M", "159.190.171.17", "Langcaster" },
                    { 30, "jkohringt@shop-pro.jp", "Jerrine", "F", "225.149.234.11", "Kohring" },
                    { 31, "tpicottu@archive.org", "Tobye", "F", "221.174.76.90", "Picott" },
                    { 17, "fdaoustg@about.com", "Frankie", "F", "156.131.66.187", "Daoust" },
                    { 66, "afores1t@yahoo.co.jp", "Alyda", "F", "120.23.110.222", "Fores" },
                    { 67, "rcrangle1u@vimeo.com", "Rafaela", "F", "250.90.48.132", "Crangle" },
                    { 68, "sgane1v@over-blog.com", "Stormi", "F", "193.48.11.240", "Gane" },
                    { 103, "ggoddard2u@rediff.com", "Gunar", "M", "217.167.166.189", "Goddard" },
                    { 104, "dlarmouth2v@bigcartel.com", "Dory", "M", "114.157.231.151", "Larmouth" },
                    { 105, "rmcnirlin2w@delicious.com", "Reggis", "M", "195.102.111.94", "McNirlin" },
                    { 106, "jmirfield2x@spotify.com", "Jobie", "F", "234.204.50.155", "Mirfield" },
                    { 107, "mpipkin2y@friendfeed.com", "Mufinella", "F", "149.131.103.145", "Pipkin" },
                    { 108, "rkuzemka2z@fotki.com", "Randa", "F", "91.128.196.68", "Kuzemka" },
                    { 109, "ggodball30@myspace.com", "Glenda", "F", "126.169.239.244", "Godball" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Gender", "IpAddress", "LastName" },
                values: new object[,]
                {
                    { 110, "mlodemann31@whitehouse.gov", "Mel", "M", "241.187.203.246", "Lodemann" },
                    { 111, "ktasseler32@omniture.com", "Karina", "F", "249.182.31.6", "Tasseler" },
                    { 112, "hbradnocke33@foxnews.com", "Holt", "M", "22.199.125.61", "Bradnocke" },
                    { 113, "kshergold34@google.it", "Kliment", "M", "56.211.216.2", "Shergold" },
                    { 114, "ckorting35@wufoo.com", "Christabella", "F", "219.245.98.50", "Korting" },
                    { 115, "kafield36@imageshack.us", "Kyle", "M", "81.34.191.183", "A'field" },
                    { 116, "hbanck37@nytimes.com", "Hailey", "M", "252.20.76.46", "Banck" },
                    { 102, "hgerran2t@is.gd", "Harley", "M", "149.112.222.87", "Gerran" },
                    { 117, "dwillavoys38@time.com", "Denver", "M", "199.255.20.142", "Willavoys" },
                    { 119, "pkobisch3a@google.com.hk", "Pattin", "M", "169.87.22.11", "Kobisch" },
                    { 120, "khedney3b@buzzfeed.com", "Kyle", "M", "117.65.202.67", "Hedney" },
                    { 121, "flodevick3c@mapquest.com", "Fenelia", "F", "73.193.46.3", "Lodevick" },
                    { 122, "gmacnaughton3d@mail.ru", "Gerry", "M", "232.207.247.94", "MacNaughton" },
                    { 123, "fwyson3e@zdnet.com", "Fabe", "M", "177.83.234.8", "Wyson" },
                    { 124, "dalflat3f@springer.com", "Devin", "M", "233.7.231.100", "Alflat" },
                    { 125, "ckleimt3g@google.co.jp", "Cooper", "M", "106.76.116.15", "Kleimt" },
                    { 126, "dkemwall3h@admin.ch", "Denis", "M", "215.78.121.44", "Kemwall" },
                    { 127, "rstopher3i@cisco.com", "Randie", "F", "19.200.86.63", "Stopher" },
                    { 128, "bstoak3j@sbwire.com", "Brendon", "M", "165.217.179.168", "Stoak" },
                    { 129, "smantrip3k@e-recht24.de", "Sigfrid", "M", "1.158.207.107", "Mantrip" },
                    { 130, "ghoggin3l@apple.com", "Gretal", "F", "7.18.152.241", "Hoggin" },
                    { 131, "tfills3m@gov.uk", "Tootsie", "F", "9.75.132.70", "Fills" },
                    { 132, "cstollmeyer3n@berkeley.edu", "Cad", "M", "138.190.25.135", "Stollmeyer" },
                    { 118, "ljoannet39@tmall.com", "Lauren", "M", "45.193.131.234", "Joannet" },
                    { 134, "rbelderfield3p@abc.net.au", "Ryley", "M", "81.223.99.194", "Belderfield" },
                    { 101, "smoorton2s@photobucket.com", "Shepard", "M", "168.252.239.247", "Moorton" },
                    { 99, "pberinger2q@tinypic.com", "Paloma", "F", "86.234.6.112", "Beringer" },
                    { 69, "jedsell1w@opensource.org", "Jeno", "M", "191.198.78.164", "Edsell" },
                    { 70, "kgrouvel1x@youtu.be", "Kamila", "F", "253.176.27.171", "Grouvel" },
                    { 71, "dgooderidge1y@free.fr", "Daryl", "M", "3.151.82.81", "Gooderidge" },
                    { 72, "mscamadin1z@mozilla.org", "Madelin", "F", "3.216.182.243", "Scamadin" },
                    { 73, "hsaenz20@1688.com", "Hatty", "F", "134.83.78.130", "Saenz" },
                    { 74, "lbenardeau21@g.co", "Liza", "F", "183.183.213.34", "Benardeau" },
                    { 75, "bweippert22@elegantthemes.com", "Berni", "F", "60.203.198.211", "Weippert" },
                    { 76, "cclucas23@ox.ac.uk", "Cora", "F", "222.112.191.225", "Clucas" },
                    { 77, "jselburn24@youtu.be", "Jessi", "F", "172.163.2.69", "Selburn" },
                    { 78, "ldymick25@ibm.com", "Lawry", "M", "215.14.203.113", "Dymick" },
                    { 79, "ctrass26@mozilla.com", "Coretta", "F", "104.180.15.48", "Trass" },
                    { 80, "abrunini27@bbc.co.uk", "Annamaria", "F", "0.227.171.57", "Brunini" },
                    { 81, "fwolstencroft28@acquirethisname.com", "Faulkner", "M", "137.204.58.135", "Wolstencroft" },
                    { 82, "apatten29@vkontakte.ru", "Adina", "F", "55.246.13.239", "Patten" },
                    { 100, "bduchasteau2r@google.pl", "Bobbye", "F", "33.98.196.58", "Duchasteau" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "Gender", "IpAddress", "LastName" },
                values: new object[,]
                {
                    { 83, "kwenzel2a@moonfruit.com", "Kirstin", "F", "96.157.219.118", "Wenzel" },
                    { 85, "csallenger2c@google.pl", "Codi", "F", "146.154.140.45", "Sallenger" },
                    { 86, "kfatscher2d@uol.com.br", "Kennan", "M", "199.245.16.3", "Fatscher" },
                    { 87, "agranham2e@auda.org.au", "Avrit", "F", "39.3.103.2", "Granham" },
                    { 88, "ghonatsch2f@kickstarter.com", "Gonzalo", "M", "244.172.212.253", "Honatsch" },
                    { 89, "mmcleese2g@blogs.com", "Mal", "M", "239.27.222.81", "McLeese" },
                    { 90, "edavern2h@deliciousdays.com", "Elna", "F", "37.28.242.193", "Davern" },
                    { 91, "ddavinet2i@thetimes.co.uk", "Duane", "M", "157.118.50.10", "Davinet" },
                    { 92, "anewark2j@squarespace.com", "Arnold", "M", "142.100.81.206", "Newark" },
                    { 93, "bthorntondewhirst2k@si.edu", "Blane", "M", "242.240.165.31", "Thornton-Dewhirst" },
                    { 94, "plabatie2l@census.gov", "Packston", "M", "88.141.41.22", "La Batie" },
                    { 95, "lmahood2m@51.la", "Laurice", "F", "90.192.14.63", "Mahood" },
                    { 96, "khazley2n@tuttocitta.it", "Kaspar", "M", "226.60.204.186", "Hazley" },
                    { 97, "rvanvuuren2o@sun.com", "Rolfe", "M", "18.201.107.15", "Van Vuuren" },
                    { 98, "jwase2p@gravatar.com", "Jefferey", "M", "102.151.158.10", "Wase" },
                    { 84, "mmillhouse2b@senate.gov", "Mirna", "F", "23.174.20.219", "Millhouse" },
                    { 269, "oscollick7g@dmoz.org", "Olive", "F", "51.104.206.198", "Scollick" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
