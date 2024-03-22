using System.Collections.Generic;

public static class ProductTitleMapping
{
    public static Dictionary<string, string> Mapping { get; } = new Dictionary<string, string>
    {
        // Install discs
        { "BCJX96010", "パペッティア" },
        { "BCAS20136", "3D Collection" },
        { "BCAS20319", "Lost in the Rain" },
        { "BCJX96004", "PlayStation 3 Special Demo Disc" },
        { "BCAX90003", "PlayStation 3 Big Hit Titles' Demo Collection" },
        { "BCAS20127", "PlayStation 3 Big Hit Titles' Demo Collection Vol. 2" },
        { "BCAS20158", "PlayStation 3 Big Hit Titles' Demo Collection Vol. 3" },
        { "BCAS20226", "All About PlayStation Game Hits Vol. 1" },
        { "BCAX90001", "Demo & Trailer Collection for Asia" },
        { "BCAX90004", "PlayStation Move Starter Disc" },
        { "BCED00060", "Official PlayStation Magazine Issue 07: July 2007" },
        { "BCED00084", "Official PlayStation Magazine Issue 08: August 2007" },
        { "BCED00085", "Official PlayStation Magazine Issue 09: September 2007" },
        { "BCED00086", "Official PlayStation Magazine Issue 10: October 2007" },
        { "BCED00087", "Official PlayStation Magazine Issue 11: November 2007" },
        { "BCED00088", "Official PlayStation Magazine Issue 12: December 2007" },
        { "BCED00181", "Official PlayStation Magazine Issue 13: Christmas 2007" },
        { "BCED00202", "Official PlayStation Magazine Issue 14: January 2008" },
        { "BCED00203", "Official PlayStation Magazine Issue 15: February 2008" },
        { "BCED00204", "Official PlayStation Magazine Issue 16: March 2008" },
        { "BCED00205", "Official PlayStation Magazine Issue 17: April 2008" },
        { "BCED00206", "Official PlayStation Magazine Issue 18: May 2008" },
        { "BCED00207", "Official PlayStation Magazine Issue 19: June 2008" },
        { "BCED00208", "Official PlayStation Magazine Issue 20: July 2008" },
        { "BCED00209", "Official PlayStation Magazine Issue 21: August 2008" },
        { "BCED00210", "Official PlayStation Magazine Issue 22: September 2008" },
        { "BCED00211", "Official PlayStation Magazine Issue 23: October 2008" },
        { "BCED00212", "Official PlayStation Magazine Issue 24: November 2008" },
        { "BCED00213", "Official PlayStation Magazine Issue 25: December 2008" },
        { "BCED00214", "Official PlayStation Magazine Issue 26: Christmas 2008" },
        { "BCED00426", "Official PlayStation Magazine Issue 27: January 2009" },
        { "BCED00427", "Official PlayStation Magazine Issue 28: February 2009" },
        { "BCED00428", "Official PlayStation Magazine Issue 29: March 2009" },
        { "BCED00429", "Official PlayStation Magazine Issue 30: April 2009" },
        { "BCED00430", "Official PlayStation Magazine Issue 31: May 2009" },
        { "BCED00431", "Official PlayStation Magazine Issue 32: June 2009" },
        { "BCED00432", "Official PlayStation Magazine Issue 33: July 2009" },
        { "BCED00433", "Official PlayStation Magazine Issue 34: August 2009" },
        { "BCED00434", "Official PlayStation Magazine Issue 35: September 2009" },
        { "BCED00435", "Official PlayStation Magazine Issue 36: October 2009" },
        { "BCED00436", "Official PlayStation Magazine Issue 37: November 2009" },
        { "BCED00437", "Official PlayStation Magazine Issue 38: December 2009" },
        { "BCED00438", "Official PlayStation Magazine Issue 39: Christmas 2009" },
        { "BCED00439", "Official PlayStation Magazine Issue 40: January 2010" },
        { "BCED00803", "Official PlayStation Magazine Issue 41: February 2010" },
        { "BCED00804", "Official PlayStation Magazine Issue 42: March 2010" },
        { "BCED00805", "Official PlayStation Magazine Issue 43: April 2010" },
        { "BCED00806", "Official PlayStation Magazine Issue 44: May 2010" },
        { "BCED00807", "Official PlayStation Magazine Issue 45: June 2010" },
        { "BCED00808", "Official PlayStation Magazine Issue 46: July 2010" },
        { "BCED00809", "Official PlayStation Magazine Issue 47: August 2010" },
        { "BCED00810", "Official PlayStation Magazine Issue 48: September 2010" },
        { "BCED00811", "Official PlayStation Magazine Issue 49: October 2010" },
        { "BCED00812", "Official PlayStation Magazine Issue 50: November 2010" },
        { "BCED00813", "Official PlayStation Magazine Issue 51: December 2010" },
        { "BCED00814", "Official PlayStation Magazine Issue 52: Christmas 2010" },
        { "BCED00815", "Official PlayStation Magazine Issue 53: January 2011" },
        { "BCED01196", "Official PlayStation Magazine Issue 54: February 2011" },
        { "BCED01197", "Official PlayStation Magazine Issue 55: March 2011" },
        { "BCED01198", "Official PlayStation Magazine Issue 56: April 2011" },
        { "BCED01199", "Official PlayStation Magazine Issue 57: May 2011" },
        { "BCED01200", "Official PlayStation Magazine Issue 58: June 2011" }, // It's also issue 59???
        { "BCED01202", "Official PlayStation Magazine Issue 60: August 2011" },
        { "BCED01203", "Official PlayStation Magazine Issue 61: September 2011" },
        { "BCED01204", "Official PlayStation Magazine Issue 62: October 2011" },
        { "BCED01205", "Official PlayStation Magazine Issue 63: November 2011" },
        { "BCED01206", "Official PlayStation Magazine Issue 64: December 2011" },
        { "BCED01207", "Official PlayStation Magazine Issue 65: Christmas 2011" },
        { "BCED01208", "Official PlayStation Magazine Issue 66: January 2012" },
        { "BCED01209", "Official PlayStation Magazine Issue 67: February 2012" },
        { "BCED01539", "Ratchet & Clank: All 4 One Demo" }, // a demo that comes bundled with zookeeper movie lol, related ids BCED01452, BCED01513, BCUS70170
        { "BCED01564", "Official PlayStation Magazine Issue 69: April 2012" }, // :)
        { "BCED01565", "Official PlayStation Magazine Issue 70: May 2012" },
        { "BCED01566", "Official PlayStation Magazine Issue 71: June 2012" },
        { "BCED01567", "Official PlayStation Magazine Issue 72: July 2012" },
        { "BCED01568", "Official PlayStation Magazine Issue 73: August 2012" },
        { "BCED01569", "Official PlayStation Magazine Issue 74: September 2012" },
        { "BCED01570", "Official PlayStation Magazine Issue 75: October 2012" },
        { "BCED01571", "Official PlayStation Magazine Issue 76: November 2012" },
        { "BCED01572", "Official PlayStation Magazine Issue 77: December 2012" },
        { "BCED01573", "Official PlayStation Magazine Issue 78: Christmas 2012" },
        { "BCED01574", "Official PlayStation Magazine Issue 79: January 2013" },
        { "BCED01575", "Official PlayStation Magazine Issue 80: February 2013" },
        { "BCED01576", "Official PlayStation Magazine Issue 81: March 2013" },
        { "BCED01577", "Official PlayStation Magazine Issue 68: March 2012" },
        { "BCED01817", "Official PlayStation Magazine Issue 82: April 2013" },
        { "BCED01818", "Official PlayStation Magazine Issue 83: May 2013" },
        { "BCED01819", "Official PlayStation Magazine Issue 84: June 2013" },
        { "BCES01454", "Tekken Hybrid" },
        { "BCJB95006", "トルネ" },
        { "BCJS30067", "フレ！フレ！ボウリング" },
        { "BCJS30093", "Rain" },
        { "BCJX96003", "プレイステーション３　スペシャルデモディスク" },
        { "BCJX96005", "もっと　あそ棒。 PlayStation Move 体験ディスク" },
        { "BCJX96008", "ラチェット＆クランク　オールフォーワン" },
        { "BCUS98261", "High Velocity Bowling" },
        { "BCUS98263", "PlayStation Move Game Demo Disc" },
        { "BCUS99205", "Best of PlayStation Network Vol. 1" },
        { "BLES01129", "Final Fantasy XIV Online: A Realm Reborn" },
        { "BLES01610", "Worms Collection" },
        { "BLES01813", "Borderlands 2: Add-On Content Pack" },
        { "BLES01965", "Borderlands 2: Game of the Year Edition (Add-On Disc)" },
        { "BLES02227", "Aegis of Earth: Protonovus Assault" },
        { "BLJM60306", "ファイナルファンタジーⅩⅣ　オンライン：新生エオルゼア" },
        { "BLJM60372", "バイオハザード　リバイバルセレクション" },
        { "BLJM60433", "バイオハザード　クロニクルズ　ＨＤセレクション" },
        { "BLJM60467", "大神　絶景版" },
        { "BLJM60510", "ファイナルファンタジーⅩⅢ－２　追加コンテンツセレクション" },
        { "BLJM60577", "モンスターハンター　フロンティア　G" },
        { "BLJM61238", "絶対迎撃ウォーズ　Metropolis Defenders" },
        { "BLJM61282", "ファイナルファンタジーⅩⅣ　Online" },
        { "BLJM61283", "ファイナルファンタジーⅩⅣ　オンライン： 蒼天のイシュガルド" },
        { "BLJM85001", "モンスター・ハンター・ポータブル　3rd HD Ver." }, // psp remasters
        { "BLJM85002", "けいおん！ 放課後ライブ！！ HD Ver." },
        { "BLJM85004", "英雄伝説　空の軌跡FC:改　HD Edition" },
        { "BLJM85005", "英雄伝説 空の軌跡SC:改 HD EDITION" },
        { "BLJM85006", "英雄伝説　空の軌跡ｔｈｅ　３ｒｄ：改　HD" }, // end psp remasters
        { "BLJS10123", "エンジェル戦記" },
        { "BLJS10124", "エンジェルラブオンライン" },
        { "BLJS10222", "テラリア" },
        { "BLJS10252", "ボーダーランズ２　ゲーム・オブ・ザ・イヤー・エディション（追加コンテンツディスク）" },
        { "BLJS93002", "Tekken Hybrid" },
        { "BLJS93014", "劇場版マクロスＦ　３０ｔｈ　ｄシュディスタｂ　ＢＯＸ　プロジェクトＦ　アルティメット☆ハイブリッドディスク" },
        { "BLJX94009", "Metal Gear Rising: Revengeance Demo" },
        { "BLKS20512", "절대요격 Wars: Metropolis Defenders" },
        { "BLUD80021", "Guitar Hero: Warriors of Rock" },
        { "BLUS30611", "Final Fantasy XIV Online: A Realm Reborn" },
        { "BLUS30716", "Days of Thunder: NASCAR Edition" },
        { "BLUS30739", "Top Gun" },
        { "BLUS30766", "Tekken Hybrid" },
        { "BLUS30911", "Deadliest Warrior: Ancient Combat" },
        { "BLUS31157", "Borderlands 2: Add-On Content Pack" },
        { "BLUS31192", "Worms Collection" },
        { "BLUS31385", "Worms: The Revolution Collection" },
        { "BLUS31561", "Final Fantasy XIV Online: The Complete Experience" },
        { "BLUS31562", "Final Fantasy XIV Online: Heavensward" },
        { "BLUS31583", "Borderlands Triple Pack (Add-On Installation Disc BLUS82013)" },
        { "BLUS31587", "Aegis of Earth: Protonovus Assault" },
        { "BLUS31620", "Oddworld: Stranger's Wrath HD" },
        { "BLUS31621", "Oddworld: Abe's Oddysee: New 'n' Tasty!" },
        { "BLJM61153", "ストライダー飛竜" },
        { "BLUS41046", "Borderlands 2: Game of the Year Edition (Add-On Disc)" }, 
        { "BLJM61008", "ウィザードリィ　パーフェクトパック" },
        { "BLJM60312", "ウィザードリィ　ツインパック" },
        { "BLJS10280", "デッドアイランド　ダブルゾンビパック" },
        { "BCUS98274", "This Is the Next Level: 3D Games and Demo Disc" },
        { "BLES02218", "Borderlands Triple Pack (Add-On Installation Disc)" },
        { "BLES02028", "Syberia Collection" },
        { "BLES01973", "Worms: The Revolution Collection" },
        // title fixes
        { "BLES00039", "ARMORED CORE 4" },
        { "BLJM60012", "ARMORED CORE 4" },
        { "BLJM55005", "ARMORED CORE for Answer" },
        { "BLES00909", "Assassin's Creed: Brotherhood" },
        { "BLES00910", "Assassin's Creed: Brotherhood" },
        { "BLES00911", "Assassin's Creed: Brotherhood" },
        { "BLJM60250", "Assassin's Creed: Brotherhood" },
        { "BLUS30537", "Assassin's Creed: Brotherhood" },
        { "BLES01384", "Assassin's Creed: Revelations" },
        { "BLES01385", "Assassin's Creed: Revelations" },
        { "BLES01466", "Assassin's Creed: Revelations" },
        { "BLES01467", "Assassin's Creed: Revelations" },
        { "BLES01772", "Assassin's Creed: Revelations" },
        { "BLJM60412", "Assassin's Creed: Revelations" },
        { "BLJM60573", "Assassin's Creed: Revelations" },
        { "BLJM67011", "Assassin's Creed: Revelations" },
        { "BLUS30808", "Assassin's Creed: Revelations" },
        { "BLUS30905", "Assassin's Creed: Revelations" },
        { "BLUS31145", "Assassin's Creed: Revelations" },
        { "BCKS10030", "Gran Turismo 5: Prologue" },
        { "BLJM60023", "Professional BaseBall Spirits 4" },
        { "BLJM60134", "Skate 2" },
        { "BLJM60055", "INITIAL D EXTREME STAGE" },
        { "BLES02219", "Grand Theft Auto: San Andreas" },
        { "BLJM61327", "Grand Theft Auto: San Andreas" },
        { "BLUS31584", "Grand Theft Auto: San Andreas" },
        { "BLES00683", "Call of Duty: Modern Warfare 2" },
        { "BLES00684", "Call of Duty: Modern Warfare 2" },
        { "BLES00685", "Call of Duty: Modern Warfare 2" },
        { "BLES00686", "Call of Duty: Modern Warfare 2" },
        { "BLES00687", "Call of Duty: Modern Warfare 2" },
        { "BLES00690", "Call of Duty: Modern Warfare 2" },
        { "BLES00691", "Call of Duty: Modern Warfare 2" },
        { "BLJM60191", "Call of Duty: Modern Warfare 2" },
        { "BLUS30377", "Call of Duty: Modern Warfare 2" },
        { "BLJS10095", "Disgaea 4" },
        { "BLJS10011", "Disgaea 3" },
        { "BLES00452", "Disgaea 3" },
        { "BLUS30181", "Disgaea 3" },
        { "BLES00396", "MotoGP 08" },
        { "BLUS30220", "MotoGP 08" },
        { "BLUS30596", "Yoostar 2" },
        { "BLES01080", "Yoostar 2" },
        { "BLJM60492", "Ultra Dimension Neptune V" },
        { "BLJM60504", "Heavy Fire: Afghanistan" },
        { "BLUS31000", "Heavy Fire: Shattered Spear" },
        { "BLJM60570", "Heavy Fire: Shattered Spear" },
        { "BLJM60103", "FIFA 09" },
        { "BLKS20101", "FIFA 09" },
        { "BLKS20353", "Hyperdimension Neptunia mk2" },
        { "BLJM60992", "Hyperdimension Neptunia mk2" },
        { "BLJS10219", "Kamen Rider: Battride War: Premium TV Sound Edition" },
        { "BLJS10220", "Kamen Rider: Battride War" },
        { "BLJM60031", "Major League Baseball 2K7" },
        { "BLES00025", "NBA 2K7" },
        { "BLJM60442", "Persona 4 The ULTIMATE in MAYONAKA ARENA" },
        { "BLJM61209", "Persona 4 The ULTIMAX ULTRA SUPLEX HOLD" },
        { "BLES01179", "Red Dead Redemption: Undead Nightmare" },
        { "BLJM60314", "Red Dead Redemption: Undead Nightmare" },
        { "BLUS30711", "Red Dead Redemption: Undead Nightmare" },
        { "BLES00368", "SBK 08: Superbike World Championship" },
        { "BLES00536", "SBK 09: Superbike World Championship" },
        { "BLUS30519", "SBK 09: Superbike World Championship" },
        { "BLUS30236", "SBK: Superbike World Championship" },
        { "BLAS50546", "The Elder Scrolls V: Skyrim" },
        { "BLES01329", "The Elder Scrolls V: Skyrim" },
        { "BLES01330", "The Elder Scrolls V: Skyrim" },
        { "BLJM60413", "The Elder Scrolls V: Skyrim" },
        { "BLUS30778", "The Elder Scrolls V: Skyrim" },
        { "BLAS50624", "The Elder Scrolls V: Skyrim: Legendary Edition" },
        { "BLES01885", "The Elder Scrolls V: Skyrim: Legendary Edition" },
        { "BLES01886", "The Elder Scrolls V: Skyrim: Legendary Edition" },
        { "BLJM61086", "The Elder Scrolls V: Skyrim: Legendary Edition" },
        { "BLUS31202", "The Elder Scrolls V: Skyrim: Legendary Edition" },
        { "BLES00048", "The Elder Scrolls IV: Oblivion" },
        { "BLUS30007", "The Elder Scrolls IV: Oblivion" },
        { "BLJM60032", "The Elder Scrolls IV: Oblivion" }, // original and goty?
        { "BLES00163", "The Elder Scrolls IV: Oblivion: Game of the Year Edition" },
        { "BLUS30087", "The Elder Scrolls IV: Oblivion: Game of the Year Edition" },
        { "BLJS10034", "The Elder Scrolls IV: Oblivion: Game of the Year Edition" },
        { "BLUS30106", "The Elder Scrolls IV: Shivering Isles" },
        { "BLJM60411", "Suigetsu 2" },
        { "BLJM60019", "Winning Post 7 MAXIMUM 2007" },
        { "BLJM60067", "Winning Post 7 MAXIMUM 2008" },
        { "BCED00393", "Gran Turismo 5: Prologue: Special Event Version: GT by Citroën" },
        { "BLJM60018", "Gundam Musou" },
        { "BLES00146", "The Simpsons Game" },
        { "BLES01245", "Cars 2" },
        { "BLES01924", "Dishonored: Game of the Year Edition" },
        { "BLES01925", "Dishonored: Game of the Year Edition" },
        { "BLES01926", "Dishonored: Game of the Year Edition" },
        { "BLJM61114", "Dishonored: Game of the Year Edition" },
        { "BLUS41038", "Dishonored: Game of the Year Edition" },
        { "BCAS20023", "Ratchet and Clank Future: Tools of Destruction" },
        { "BCJS30014", "Ratchet and Clank Future: Tools of Destruction" },
        { "BLJS10106", "Rune Factory Oceans" },
        // multigame discs PS3_GMXX
        { "BLES02226", "Saints Row: Game of the Century Edition & Gat out of Hell" }, // BLES02019, BLES02095
        { "BLES02221", "Naruto Shippuden: Ultimate Ninja Storm Collection" }, // BLES00371, BLES00952, BLES01951
        { "BLES02212", "Far Cry 3 + Far Cry 4: Double Pack" },
        { "BLES02203", "Far Cry 3 + Far Cry 4: Double Pack" }, // BLES01137, BLES02011
        { "BLUS82012", "Borderlands Triple Pack" },
        { "BLES82007", "Borderlands Triple Pack" }, // BLES00697, BLES01684, BLES02058
        { "BLES02211", "Assassin's Creed IV: Black Flag + Assassin's Creed: Rogue" },
        { "BLES02204", "Assassin's Creed IV: Black Flag + Assassin's Creed: Rogue" }, // BLES01882, BLES02061
        { "BLES02208", "Rayman Legends + Rayman Origins" }, // BLES01896, BLES01510
        { "BLES02183", "Rayman Legends + Rayman Origins" }, // BLES01863, BLES01386
        { "BLES02198", "The Disgaea Triple Play Collection" }, // BLES00452, BLES01225, BLES01939
        { "BLUS31577", "The Disgaea Triple Play Collection" },
        { "BLES02156", "Tales of Symphonia Chronicles + Tales of Graces f" }, // BLES01617, BLES01864
        { "BLES02137", "Hyperdimension Neptunia Hypercollection" }, // BLES01178, BLES01507, BLES01788
        { "BLES02138", "The Arland Atelier Trilogy" }, // BLES01030, BLES01221, BLES01593
        { "BLUS31581", "The Arland Atelier Trilogy" },
        { "BLES02131", "One Piece: Pirate Warriors + One Piece: Pirate Warriors 2" }, // BLES01672, BLES01913
        { "BLES02130", "Motorbike Racing Pack" }, // BLES01805, BLES01551, BLES01647
        { "BLES02129", "Fighting Edition" }, // BLES01250, BLES00635, BLES01702
        { "BLES02124", "Ultimate Stealth Triple Pack" }, // BLES01151, BLES01778, BLES01982
        { "BLES02122", "Ultimate Stealth Triple Pack" }, // BLES01151, BLES01403, BLES01982
        { "BLES02116", "Ultimate Stealth Triple Pack" }, // BLES01150, BLES01403, BLES01982
        { "BLUS31552", "Ultimate Stealth Triple Pack" },
        { "BLUS31551", "Ultimate Action Triple Pack" }, // BLUS30400, BLUS30927, BLUS31036
        { "BLES02123", "Ultimate Action Triple Pack" }, // BLES00517, BLES01704, BLES01780
        { "BLES02121", "Ultimate Action Triple Pack" }, // BLES00517, BLES01704, BLES01780
        { "BLES02117", "Ultimate Action Triple Pack" }, // BLES00517, BLES01661, BLES01780
        { "BLES02094", "Saints Row: Double Pack" }, // BLES01747, BLES02019
        { "BLES01840", "Tom Clancy's Ghost Recon Double Pack" },
        // prototypes
        { "TEST01814", "Section 8 Prejudice 2010-07-08 Beta" },
    };
}