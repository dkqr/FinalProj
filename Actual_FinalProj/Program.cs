using System.Text;
using System.Timers;
using System;
using System.Diagnostics;

namespace FinalProj {
    // taken from ultcalcv3 (finally have a slightly better use for it)
    class Rainbow {
        public static String RgbToAnsii(int r, int g, int b) {
            return "\x1b[38;2;" + r + ";" + g + ";" + b + "m";
        }
        public static String GetRainbow(Char c, int o) {
            String[] colours = {
                RgbToAnsii(255, 0, 0),
                RgbToAnsii(255, 127, 0),
                RgbToAnsii(255, 255, 0),
                RgbToAnsii(127, 255, 0),
                RgbToAnsii(0, 255, 0),
                RgbToAnsii(0, 255, 127),
                RgbToAnsii(0, 255, 255),
                RgbToAnsii(0, 127, 255),
                RgbToAnsii(0, 0, 255),
                RgbToAnsii(127, 0, 255),
                RgbToAnsii(255, 0, 255),
                RgbToAnsii(255, 0, 127),
            };
            return colours[o % colours.Length] + c;
        }
        public static string stringToRainbow(string s, int o) {
            string built = "";
            for (int i = 0; i < s.Length; i++) {
                built += GetRainbow(s[i], o);
            }
            return built;
        }
    }
    // :)
    class PARROTIZER {
        string[] p0, p1, p2, p3, p4, p5, p6, p7, p8, p9;
        // frames taken from here :
        // https://github.com/hugomd/parrot.live/tree/master/frames
        public PARROTIZER() {
            p0 = new string[18] {   "                         .cccc;;cc;';c.           ",
                                    "                      .,:dkdc:;;:c:,:d:.          ",
                                    "                     .loc'.,cc::c:::,..;:.        ",
                                    "                   .cl;....;dkdccc::,...c;        ",
                                    "                  .c:,';:'..ckc',;::;....;c.      ",
                                    "                .c:'.,dkkoc:ok:;llllc,,c,';:.     ",
                                    "               .;c,';okkkkkkkk:;lllll,:kd;.;:,.   ",
                                    "               co..:kkkkkkkkkk:;llllc':kkc..oNc   ",
                                    "             .cl;.,oxkkkkkkkkkc,:cll;,okkc'.cO;   ",
                                    "             ;k:..ckkkkkkkkkkkl..,;,.;xkko:',l'   ",
                                    "            .,...';dkkkkkkkkkkd;.....ckkkl'.cO;   ",
                                    "         .,,:,.;oo:ckkkkkkkkkkkdoc;;cdkkkc..cd,   ",
                                    "      .cclo;,ccdkkl;llccdkkkkkkkkkkkkkkkd,.c;     ",
                                    "     .lol:;;okkkkkxooc::coodkkkkkkkkkkkko'.oc     ",
                                    "   .c:'..lkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkd,.oc     ",
                                    "  .lo;,:cdkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkd,.c;     ",
                                    ",dx:..;lllllllllllllllllllllllllllllllllc'...     ",
                                    "cNO;........................................      ",};
            p1 = new string[18] {  "                .ckx;'........':c.                ",
                                            "             .,:c:::::oxxocoo::::,',.             ",
                                            "            .odc'..:lkkoolllllo;..;d,             ",
                                            "            ;c..:o:..;:..',;'.......;.            ",
                                            "           ,c..:0Xx::o:.,cllc:,'::,.,c.           ",
                                            "           ;c;lkXKXXXXl.;lllll;lKXOo;':c.         ",
                                            "         ,dc.oXXXXXXXXl.,lllll;lXXXXx,c0:         ",
                                            "         ;Oc.oXXXXXXXXo.':ll:;'oXXXXO;,l'         ",
                                            "         'l;;kXXXXXXXXd'.'::'..dXXXXO;,l'         ",
                                            "         'l;:0XXXXXXXX0x:...,:o0XXXXx,:x,         ",
                                            "         'l;;kXXXXXXXXXKkol;oXXXXXXXO;oNc         ",
                                            "        ,c'..ckk0XXXXXXXXXX00XXXXXXX0:;o:.        ",
                                            "      .':;..:do::ooookXXXXXXXXXXXXXXXo..c;        ",
                                            "    .',',:co0XX0kkkxxOXXXXXXXXXXXXXXXOc..;l.      ",
                                            "  .:;'..oXXXXXXXXXXXXXXXXXXXXXXXXXXXXXko;';:.     ",
                                            ".ldc..:oOXKXXXXXXKXXKXXXXXXXXXXXXXXXXXXXo..oc     ",
                                            ":0o...:dxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxo,.:,     ",
                                            "cNo........................................;'     ",};
            p2 = new string[18] {  "            .cc;.  ...  .;c.                      ",
                                            "         .,,cc:cc:lxxxl:ccc:;,.                   ",
                                            "        .lo;...lKKklllookl..cO;                   ",
                                            "      .cl;.,:'.okl;..''.;,..';:.                  ",
                                            "     .:o;;dkd,.ll..,cc::,..,'.;:,.                ",
                                            "     co..lKKKkokl.':lloo;''ol..;dl.               ",
                                            "   .,c;.,xKKKKKKo.':llll;.'oOxl,.cl,.             ",
                                            "   cNo..lKKKKKKKo'';llll;;okKKKl..oNc             ",
                                            "   cNo..lKKKKKKKko;':c:,'lKKKKKo'.oNc             ",
                                            "   cNo..lKKKKKKKKKl.....'dKKKKKxc,l0:             ",
                                            "   .c:'.lKKKKKKKKKk;....lKKKKKKo'.oNc             ",
                                            "     ,:.'oxOKKKKKKKOxxxxOKKKKKKxc,;ol:.           ",
                                            "     ;c..'':oookKKKKKKKKKKKKKKKKKk:.'clc.         ",
                                            "   ,xl'.,oxo;'';oxOKKKKKKKKKKKKKKKOxxl:::;,.      ",
                                            "  .dOc..lKKKkoooookKKKKKKKKKKKKKKKKKKKxl,;ol.     ",
                                            "  cx,';okKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKl..;lc.   ",
                                            "  co..:dddddddddddddddddddddddddddddddddl::',::.  ",
                                            "  co...........................................   ",};
            p3 = new string[18] {  "           .ccccccc.                              ",
                                            "      .,,,;cooolccoo;;,,.                         ",
                                            "     .dOx;..;lllll;..;xOd.                        ",
                                            "   .cdo;',loOXXXXXkll;';odc.                      ",
                                            "  ,ol:;c,':oko:cccccc,...ckl.                     ",
                                            "  ;c.;kXo..::..;c::'.......oc                     ",
                                            ",dc..oXX0kk0o.':lll;..cxxc.,ld,                   ",
                                            "kNo.'oXXXXXXo',:lll;..oXXOo;cOd.                  ",
                                            "KOc;oOXXXXXXo.':lol;..dXXXXl';xc                  ",
                                            "Ol,:k0XXXXXX0c.,clc'.:0XXXXx,.oc                  ",
                                            "KOc;dOXXXXXXXl..';'..lXXXXXo..oc                  ",
                                            "dNo..oXXXXXXXOx:..'lxOXXXXXk,.:; ..               ",
                                            "cNo..lXXXXXXXXXOolkXXXXXXXXXkl,..;:';.            ",
                                            ".,;'.,dkkkkk0XXXXXXXXXXXXXXXXXOxxl;,;,;l:.        ",
                                            "  ;c.;:''''':doOXXXXXXXXXXXXXXXXXXOdo;';clc.      ",
                                            "  ;c.lOdood:'''oXXXXXXXXXXXXXXXXXXXXXk,..;ol.     ",
                                            "  ';.:xxxxxocccoxxxxxxxxxxxxxxxxxxxxxxl::'.';;.   ",
                                            "  ';........................................;l'   ",};
            p4 = new string[18] {  "                                                  ",
                                            "        .;:;;,.,;;::,.                            ",
                                            "     .;':;........'co:.                           ",
                                            "   .clc;'':cllllc::,.':c.                         ",
                                            "  .lo;;o:coxdllllllc;''::,,.                      ",
                                            ".c:'.,cl,.'l:',,;;'......cO;                      ",
                                            "do;';oxoc;:l;;llllc'.';;'.,;.                     ",
                                            "c..ckkkkkkkd,;llllc'.:kkd;.':c.                   ",
                                            "'.,okkkkkkkkc;lllll,.:kkkdl,cO;                   ",
                                            "..;xkkkkkkkkc,ccll:,;okkkkk:,co,                  ",
                                            "..,dkkkkkkkkc..,;,'ckkkkkkkc;ll.                  ",
                                            "..'okkkkkkkko,....'okkkkkkkc,:c.                  ",
                                            "c..ckkkkkkkkkdl;,:okkkkkkkkd,.',';.               ",
                                            "d..':lxkkkkkkkkxxkkkkkkkkkkkdoc;,;'..'.,.         ",
                                            "o...'';llllldkkkkkkkkkkkkkkkkkkdll;..'cdo.        ",
                                            "o..,l;'''''';dkkkkkkkkkkkkkkkkkkkkdlc,..;lc.      ",
                                            "o..;lc;;;;;;,,;clllllllllllllllllllllc'..,:c.     ",
                                            "o..........................................;'     ",};
            p5 = new string[18] {  "                                                  ",
                                            "           .,,,,,,,,,.                            ",
                                            "         .ckKxodooxOOdcc.                         ",
                                            "      .cclooc'....';;cool.                        ",
                                            "     .loc;;;;clllllc;;;;;:;,.                     ",
                                            "   .c:'.,okd;;cdo:::::cl,..oc                     ",
                                            "  .:o;';okkx;';;,';::;'....,:,.                   ",
                                            "  co..ckkkkkddkc,cclll;.,c:,:o:.                  ",
                                            "  co..ckkkkkkkk:,cllll;.:kkd,.':c.                ",
                                            ".,:;.,okkkkkkkk:,cclll;.ckkkdl;;o:.               ",
                                            "cNo..ckkkkkkkkko,.;loc,.ckkkkkc..oc               ",
                                            ",dd;.:kkkkkkkkkx;..;:,.'lkkkkko,.:,               ",
                                            "  ;:.ckkkkkkkkkkc.....;ldkkkkkk:.,'               ",
                                            ",dc..'okkkkkkkkkxoc;;cxkkkkkkkkc..,;,.            ",
                                            "kNo..':lllllldkkkkkkkkkkkkkkkkkdcc,.;l.           ",
                                            "KOc,c;''''''';lldkkkkkkkkkkkkkkkkkc..;lc.         ",
                                            "xx:':;;;;,.,,...,;;cllllllllllllllc;'.;od,        ",
                                            "cNo.....................................oc        ",};
            p6 = new string[18] {  "                                                  ",
                                            "                                                  ",
                                            "                   .ccccccc.                      ",
                                            "               .ccckNKOOOOkdcc.                   ",
                                            "            .;;cc:ccccccc:,:c::,,.                ",
                                            "         .c;:;.,cccllxOOOxlllc,;ol.               ",
                                            "        .lkc,coxo:;oOOxooooooo;..:,               ",
                                            "      .cdc.,dOOOc..cOd,.',,;'....':l.             ",
                                            "      cNx'.lOOOOxlldOc..;lll;.....cO;             ",
                                            "     ,do;,:dOOOOOOOOOl'':lll;..:d:''c,            ",
                                            "     co..lOOOOOOOOOOOl'':lll;.'lOd,.cd.           ",
                                            "     co.'dOOOOOOOOOOOo,.;llc,.,dOOc..dc           ",
                                            "     co..lOOOOOOOOOOOOc.';:,..cOOOl..oc           ",
                                            "   .,:;.'::lxOOOOOOOOOo:'...,:oOOOc.'dc           ",
                                            "   ;Oc..cl'':lldOOOOOOOOdcclxOOOOx,.cd.           ",
                                            "  .:;';lxl''''':lldOOOOOOOOOOOOOOc..oc            ",
                                            ",dl,.'cooc:::,....,::coooooooooooc'.c:            ",
                                            "cNo.................................oc            ",};
            p7 = new string[18] {  "                                                  ",
                                            "                                                  ",
                                            "                                                  ",
                                            "                        .cccccccc.                ",
                                            "                  .,,,;;cc:cccccc:;;,.            ",
                                            "                .cdxo;..,::cccc::,..;l.           ",
                                            "               ,do:,,:c:coxxdllll:;,';:,.         ",
                                            "             .cl;.,oxxc'.,cc,.';;;'...oNc         ",
                                            "             ;Oc..cxxxc'.,c;..;lll;...cO;         ",
                                            "           .;;',:ldxxxdoldxc..;lll:'...'c,        ",
                                            "           ;c..cxxxxkxxkxxxc'.;lll:'','.cdc.      ",
                                            "         .c;.;odxxxxxxxxxxxd;.,cll;.,l:.'dNc      ",
                                            "        .:,''ccoxkxxkxxxxxxx:..,:;'.:xc..oNc      ",
                                            "      .lc,.'lc':dxxxkxxxxxxxol,...',lx:..dNc      ",
                                            "     .:,',coxoc;;ccccoxxxxxxxxo:::oxxo,.cdc.      ",
                                            "  .;':;.'oxxxxxc''''';cccoxxxxxxxxxxxc..oc        ",
                                            ",do:'..,:llllll:;;;;;;,..,;:lllllllll;..oc        ",
                                            "cNo.....................................oc        ",};
            p8 = new string[18] {  "                                                  ",
                                            "                                                  ",
                                            "                              .ccccc.             ",
                                            "                         .cc;'coooxkl;.           ",
                                            "                     .:c:::c:,,,,,;c;;,.'.        ",
                                            "                   .clc,',:,..:xxocc;'..c;        ",
                                            "                  .c:,';:ox:..:c,,,,,,...cd,      ",
                                            "                .c:'.,oxxxxl::l:.,loll;..;ol.     ",
                                            "                ;Oc..:xxxxxxxxx:.,llll,....oc     ",
                                            "             .,;,',:loxxxxxxxxx:.,llll;.,,.'ld,   ",
                                            "            .lo;..:xxxxxxxxxxxx:.'cllc,.:l:'cO;   ",
                                            "           .:;...'cxxxxxxxxxxxxoc;,::,..cdl;;l'   ",
                                            "         .cl;':,'';oxxxxxxdxxxxxx:....,cooc,cO;   ",
                                            "     .,,,::;,lxoc:,,:lxxxxxxxxxxxo:,,;lxxl;'oNc   ",
                                            "   .cdxo;':lxxxxxxc'';cccccoxxxxxxxxxxxxo,.;lc.   ",
                                            "  .loc'.'lxxxxxxxxocc;''''';ccoxxxxxxxxx:..oc     ",
                                            "olc,..',:cccccccccccc:;;;;;;;;:ccccccccc,.'c,     ",
                                            "Ol;......................................;l'      ",};
            p9 = new string[18] {  "                                                  ",
                                            "                              ,ddoodd,            ",
                                            "                         .cc' ,ooccoo,'cc.        ",
                                            "                      .ccldo;...',,...;oxdc.      ",
                                            "                   .,,:cc;.,'..;lol;;,'..lkl.     ",
                                            "                  .dOc';:ccl;..;dl,.''.....oc     ",
                                            "                .,lc',cdddddlccld;.,;c::'..,cc:.  ",
                                            "                cNo..:ddddddddddd;':clll;,c,';xc  ",
                                            "               .lo;,clddddddddddd;':clll;:kc..;'  ",
                                            "             .,c;..:ddddddddddddd:';clll,;ll,..   ",
                                            "             ;Oc..';:ldddddddddddl,.,c:;';dd;..   ",
                                            "           .''',:c:,'cdddddddddddo:,''..'cdd;..   ",
                                            "         .cdc';lddd:';lddddddddddddd;.';lddl,..   ",
                                            "      .,;::;,cdddddol;;lllllodddddddlcldddd:.'l;  ",
                                            "     .dOc..,lddddddddlcc:;'';cclddddddddddd;;ll.  ",
                                            "   .coc,;::ldddddddddddddlcccc:ldddddddddl:,cO;   ",
                                            ",xl::,..,cccccccccccccccccccccccccccccccc:;':xx,  ",
                                            "cNd.........................................;lOc  ",};
        }
        public string[] getParrotFrame(int frame) {
            switch (frame) {
                case 0:
                    return p0;
                case 1:
                    return p1;
                case 2:
                    return p2;
                case 3:
                    return p3;
                case 4:
                    return p4;
                case 5:
                    return p5;
                case 6:
                    return p6;
                case 7:
                    return p7;
                case 8:
                    return p8;
                case 9:
                    return p9;
                default:
                    throw new ArgumentException("Only 9 frames exists, you entered " + frame);
            }
        }
    }
    // The entire purpose of the class is just to deal with printing or clearing characters
    class TextPrinter {
        public static void Print<T>(int left, int top, T txt, int layer = 5) {
            // FIND A BETTER FONT, THIS IS NOT MONOSPACED SO IT RUINS EVERYTHING >:C
            // or just fix it in some way idk
            // i guessed i fixed it !! (in like the worst way possible)
            string alph1 = " █████  ██████   ██████ ██████  ███████ ███████  ██████  ██   ██ ██      ██ ██   ██ ██      ███    ███ ███    ██  ██████  ██████   ██████  ██████  ███████ ████████ ██    ██ ██    ██ ██     ██ ██   ██ ██    ██ ███████ ";
            string alph2 = "██   ██ ██   ██ ██      ██   ██ ██      ██      ██       ██   ██ ██      ██ ██  ██  ██      ████  ████ ████   ██ ██    ██ ██   ██ ██    ██ ██   ██ ██         ██    ██    ██ ██    ██ ██     ██  ██ ██   ██  ██     ███  ";
            string alph3 = "███████ ██████  ██      ██   ██ █████   █████   ██   ███ ███████ ██      ██ █████   ██      ██ ████ ██ ██ ██  ██ ██    ██ ██████  ██    ██ ██████  ███████    ██    ██    ██ ██    ██ ██  █  ██   ███     ████     ███   ";
            string alph4 = "██   ██ ██   ██ ██      ██   ██ ██      ██      ██    ██ ██   ██ ██ ██   ██ ██  ██  ██      ██  ██  ██ ██  ██ ██ ██    ██ ██      ██ ▄▄ ██ ██   ██      ██    ██    ██    ██  ██  ██  ██ ███ ██  ██ ██     ██     ███    ";
            string alph5 = "██   ██ ██████   ██████ ██████  ███████ ██       ██████  ██   ██ ██  █████  ██   ██ ███████ ██      ██ ██   ████  ██████  ██       ██████  ██   ██ ███████    ██     ██████    ████    ███ ███  ██   ██    ██    ███████ ";
            
            string num1 = " ██████   ██      ██████   ██████   ██   ██  ███████   ██████  ███████   █████    █████   ";
            string num2 = "██  ████ ███           ██       ██  ██   ██  ██       ██            ██  ██   ██  ██   ██  ";
            string num3 = "██ ██ ██  ██       █████    █████   ███████  ███████  ███████      ██    █████    ██████  ";
            string num4 = "████  ██  ██      ██            ██       ██       ██  ██    ██    ██    ██   ██       ██  ";
            string num5 = " ██████   ██      ███████  ██████        ██  ███████   ██████     ██     █████    █████   ";

            string brac1 = "███ ███ ";
            string brac2 = "██   ██ ";
            string brac3 = "██   ██ ";
            string brac4 = "██   ██ ";
            string brac5 = "███ ███ ";
            int[] alphWidths = new int[26] {
            //  A  B  C  D  E  F  G  H  I  J  K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z
                8, 8, 8, 8, 8, 8, 9, 8, 3, 8, 8, 8, 11,10,9, 8, 9, 8, 8, 9, 9, 9, 10,8, 9, 8
            };
            int[] numWidths = new int[10] {
            //  0  1  2  3  4  5  6  7  8  9
                9, 9, 9, 9, 9, 9, 9, 9, 9, 9
            };
            string text = txt.ToString();
            text = text.ToUpper();
            foreach (char c in text) {
                int finalWidth = 0;
                if (c >= 'A' && c <= 'Z') {
                    int offset = 0;
                    for (int i = 0; i < (c - 'A'); i++) {
                        offset += alphWidths[i];
                    }
                    finalWidth = alphWidths[(c - 'A')];
                    if (left + finalWidth > Console.WindowWidth) {
                        break;
                    }
                    Console.SetCursorPosition(left, top);
                    if (layer > 0)
                        Console.Write(alph1.Substring(offset, alphWidths[(c - 'A')]));
                    Console.SetCursorPosition(left, top + 1);
                    if (layer > 1)
                        Console.Write(alph2.Substring(offset, alphWidths[(c - 'A')]));
                    Console.SetCursorPosition(left, top + 2);
                    if (layer > 2)
                        Console.Write(alph3.Substring(offset, alphWidths[(c - 'A')]));
                    Console.SetCursorPosition(left, top + 3);
                    if (layer > 3)
                        Console.Write(alph4.Substring(offset, alphWidths[(c - 'A')]));
                    Console.SetCursorPosition(left, top + 4);
                    if (layer > 4)
                        Console.Write(alph5.Substring(offset, alphWidths[(c - 'A')]));
                } else if (c >= '0' && c <= '9') {
                    int offset = 0;
                    for (int i = 0; i < (c - '0'); i++) {
                        offset += numWidths[i];
                    }
                    finalWidth = numWidths[(c - '0')];
                    if (left + finalWidth > Console.WindowWidth) {
                        break;
                    }
                    Console.SetCursorPosition(left, top);
                    if (layer > 0)
                        Console.Write(num1.Substring(offset, numWidths[(c - '0')]));
                    Console.SetCursorPosition(left, top + 1);
                    if (layer > 1)
                        Console.Write(num2.Substring(offset, numWidths[(c - '0')]));
                    Console.SetCursorPosition(left, top + 2);
                    if (layer > 2)
                        Console.Write(num3.Substring(offset, numWidths[(c - '0')]));
                    Console.SetCursorPosition(left, top + 3);
                    if (layer > 3)
                        Console.Write(num4.Substring(offset, numWidths[(c - '0')]));
                    Console.SetCursorPosition(left, top + 4);
                    if (layer > 4)
                        Console.Write(num5.Substring(offset, numWidths[(c - '0')]));
                } else if (c == '[' || c == ']') {
                    int offset = 0;
                    if (c == ']') {
                        offset = 4;
                    }
                    finalWidth = 5;
                    Console.SetCursorPosition(left, top);
                    if (layer > 0)
                        Console.Write(brac1.Substring(offset, 4));
                    Console.SetCursorPosition(left, top + 1);
                    if (layer > 1)
                        Console.Write(brac2.Substring(offset, 4));
                    Console.SetCursorPosition(left, top + 2);
                    if (layer > 2)
                        Console.Write(brac3.Substring(offset, 4));
                    Console.SetCursorPosition(left, top + 3);
                    if (layer > 3)
                        Console.Write(brac4.Substring(offset, 4));
                    Console.SetCursorPosition(left, top + 4);
                    if (layer > 4)
                        Console.Write(brac5.Substring(offset, 4));
                } else if (c == ' ') {
                    finalWidth = 5;
                    Console.SetCursorPosition(left, top);
                    Console.Write("    ");
                    Console.SetCursorPosition(left, top + 1);
                    Console.Write("    ");
                    Console.SetCursorPosition(left, top + 2);
                    Console.Write("    ");
                    Console.SetCursorPosition(left, top + 3);
                    Console.Write("    ");
                    Console.SetCursorPosition(left, top + 4);
                    Console.Write("    ");
                } else if (c == '/') {
                    finalWidth = 6;
                    Console.SetCursorPosition(left, top);
                    if (layer > 0)
                        Console.Write("    █");
                    Console.SetCursorPosition(left, top + 1);
                    if (layer > 1)
                        Console.Write("   █ ");
                    Console.SetCursorPosition(left, top + 2);
                    if (layer > 2)
                        Console.Write("  █  ");
                    Console.SetCursorPosition(left, top + 3);
                    if (layer > 3)
                        Console.Write(" █   ");
                    Console.SetCursorPosition(left, top + 4);
                    if (layer > 4)
                        Console.Write("█    ");
                } else if (c == '>') {
                    finalWidth = 8;
                    Console.SetCursorPosition(left, top);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 1);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 2);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 3);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 4);
                    Console.Write("        ");
                } else if (c == '<') {
                    finalWidth = 2;
                    Console.SetCursorPosition(left, top);
                    Console.Write("  ");
                    Console.SetCursorPosition(left, top + 1);
                    Console.Write("  ");
                    Console.SetCursorPosition(left, top + 2);
                    Console.Write("  ");
                    Console.SetCursorPosition(left, top + 3);
                    Console.Write("  ");
                    Console.SetCursorPosition(left, top + 4);
                    Console.Write("  ");
                } else if (c == '_') {
                    finalWidth = 8;
                    Console.SetCursorPosition(left, top);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 1);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 2);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 3);
                    Console.Write("        ");
                    Console.SetCursorPosition(left, top + 4);
                    Console.Write("███████ ");
                }
                left += finalWidth;
            }
            Console.SetCursorPosition(0, 0);
        }
        public static void ClearLine(int top, int height = 5) {
            for (int i = 0; i < height; i++) {
                Console.SetCursorPosition(1, top + i);
                Console.Write(new String(' ', Console.WindowWidth - 2));
            }
        }
    }
    class Debugger {
        public static void DebugText<T>(T text) {
            //(int, int) old = Console.GetCursorPosition();
            Console.SetCursorPosition(Console.WindowWidth - 16, 1);
            Console.Write("┌─────────────┐");
            //Console.SetCursorPosition(Console.WindowWidth - 17, 2);
            //Console.Write("│             │");
            Console.SetCursorPosition(Console.WindowWidth - 16, 2);
            Console.Write("│" + text.ToString().PadRight(13) + "│");
            //Console.SetCursorPosition(Console.WindowWidth - 17, 4);
            //Console.Write("│             │");
            Console.SetCursorPosition(Console.WindowWidth - 16, 3);
            Console.Write("└─────────────┘");
            Console.SetCursorPosition(0, 0);
        }
    }
    // This is used for every screen class to have all the basic nessisities for the gui and or printing.
    abstract class Screen : KeyHandler.KeyListener {
        protected System.Timers.Timer t;
        protected int charAmount = 0;
        protected int cWidth;
        protected int cHeight;
        protected bool Transitioning = false;
        protected bool Opened = false;
        protected bool FinishedRendering = false;
        protected bool LastTransition = false;
        public void Write(string text) {
            (int, int) pos = Console.GetCursorPosition();
            for (int i = 0; i < text.Length; i++) {
                if (pos.Item1 + i <= 0 || pos.Item1 + i >= cWidth || pos.Item2 <= 0 || pos.Item2 >= cHeight) {
                    continue;
                }
                Console.SetCursorPosition(pos.Item1 + i, pos.Item2);
                Console.Write(text[i]);
            }
        }
        public bool IsFinished() {
            return FinishedRendering;
        }
        public Screen(KeyHandler.KeyHandler kh) : base(kh) {
            Console.Clear();
            this.accepting = false;
            // Default is 50
            // change to make faster or slower transition
            t = new System.Timers.Timer(5);
            t.Elapsed += UpChar;
            t.Enabled = false;
            cWidth = Console.WindowWidth;
            cHeight = Console.WindowHeight;
        }
        protected void SetTransitionSpeed(int speed) {
            t.Interval = speed;
        }
        protected void FinalTransition() {
            charAmount = 0;
            Opened = !Opened;
            this.Transitioning = true;
            t.Start();
            LastTransition = true;
        }
        protected void StartTransition() {
            charAmount = 0;
            Opened = !Opened;
            this.Transitioning = true;
            t.Start();
        }
        protected void StopTransition() {
            this.Transitioning = false;
            t.Stop();
        }
        protected void Transition(int offset, bool reversed) {
            Console.SetCursorPosition(0, 0);
            StringBuilder sb = new StringBuilder();
            if (reversed) {
                for (int i = 1; i < Math.Max(1, cHeight-1 - offset); i++) {
                    Console.SetCursorPosition(1, i);
                    for (int j = 0; j < cWidth-2; j++) {
                        sb.Append('#');
                    }
                    Console.Write(sb);
                    sb.Clear();
                }
                for (int i = Math.Max(1, cHeight-1 - offset); i < cHeight-1; i++) {
                    Console.SetCursorPosition(1, i);
                    for (int j = 0; j < cWidth-2; j++) {
                        sb.Append(' ');
                    }
                    Console.Write(sb);
                    sb.Clear();
                }
            } else {
                for (int i = 1; i < Math.Min(cHeight-1, offset); i++) {
                    Console.SetCursorPosition(1, i);
                    for (int j = 1; j < cWidth-1; j++) {
                        sb.Append('#');
                    }
                    Console.Write(sb);
                    sb.Clear();
                }
            }
        }
        private void UpChar(Object source, ElapsedEventArgs e) {
            //Transition(charAmount, Opened);
            charAmount++;
        }
        protected void RenderBorder() {
            Console.SetCursorPosition(0, 0);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.cWidth; i++) {
                sb.Append("#");
            }
            Console.Write(sb);
            Console.SetCursorPosition(0, cHeight-1);
            Console.Write(sb);
            sb.Clear();
            for (int i = 0; i < this.cHeight; i++) {
                if (i == cHeight - 1) {
                    sb.Append("#");
                } else {
                    sb.Append("#\n");
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.Write(sb);
            for (int i = 0; i < this.cHeight; i++) {
                Console.SetCursorPosition(cWidth-1, i);
                Console.Write('#');
            }
        }
        public abstract void Render();
        public void RenderScreen() {
            this.RenderBorder();
            if (Transitioning) {
                this.Transition(charAmount, Opened);
                accepting = false;
                if (charAmount >= cHeight) {
#pragma warning disable CS0642 // Possible mistaken empty statement
                    if (Opened == false && LastTransition) FinishedRendering = true;
                    else if (Opened == false) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
                    else accepting = true;
                    StopTransition();
                }
            } else {
                Render();
            }
        }
        public override void OnKeyPress(ConsoleKeyInfo cki) {
        }
    }
    // The main menu screen, all it does is just ensure that numlock is on or the game wont work (+ something else)
    class MainMenu : Screen {
        // down up down up down up down up down <--- do that on the main menu :)
        ConsoleKeyInfo lastKey;
        int distance = 0;
        int sillyOffset = 0;
        int poser = 0;
        System.Timers.Timer sillyTimer = new System.Timers.Timer(50);
        public MainMenu(KeyHandler.KeyHandler kh) : base(kh) {
            StartTransition();
        }
        public void NormalRender() {
            TextPrinter.Print(25, 5, "Limited RPS");
            TextPrinter.Print(35, 18, "[ENTER]");
            if (!Console.NumberLock)
                TextPrinter.Print(1, 24, "Enable NumLock");
            else
                TextPrinter.ClearLine(24);
        }
        private (int, int) GetCirclePoint(int a, double radius, int cX, int cY) {
            double angle = 2 * Math.PI / 100 * -a;
            int newX = (int)(radius * Math.Cos(angle) * 2 + cX);
            int newY = (int)(cY + radius * Math.Sin(angle));
            return (newX, newY);
        }
        public void silly() {
            PARROTIZER p = new PARROTIZER();
            poser++;
            IntPtr handle = Process.GetCurrentProcess().MainWindowHandle;
            var (x, y) = GetCirclePoint(poser*2, 140, WindowUtility.GetWindowSize().Width / 2 - (cWidth/2), WindowUtility.GetWindowSize().Height / 2- (cHeight / 2));
            WindowUtility.SetPosition(x,y);
            for (int i = 0; i < 18; i++) {
                Console.SetCursorPosition(35, 8 + i);
                Console.Write(Rainbow.stringToRainbow(p.getParrotFrame(sillyOffset)[i], sillyOffset));
                //Console.Write(Rainbow.stringToRainbow(p.getParrotFrame(sillyOffset)[i], i));
            }
        }
        public override void Render() {
            if (distance < 8) {
                NormalRender();
            } else {
                if (!sillyTimer.Enabled) {
                    Console.Clear();
                    sillyTimer.Start();
                    sillyTimer.Elapsed += SillyTimer_Elapsed;
                }
                silly();
            }
        }
        private void SillyTimer_Elapsed(object? sender, ElapsedEventArgs e) {
            sillyOffset++;
            sillyOffset = sillyOffset % 10;
        }

        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (cki.Key == ConsoleKey.Enter && Console.NumberLock) {
                Console.SetCursorPosition(0, 0);
                Console.Write(Rainbow.RgbToAnsii(192, 192, 192));
                FinalTransition();
            } else if (cki != lastKey) {
                if (cki.Key == ConsoleKey.DownArrow && lastKey.Key == ConsoleKey.UpArrow) {
                    distance++;
                } else if (cki.Key == ConsoleKey.UpArrow && lastKey.Key == ConsoleKey.DownArrow) {
                    distance++;
                } else if (distance < 8){
                    distance = 0;
                }
                lastKey = cki;
            }
        }
    }
    // Allows the user to select the amount of people playing, min of 2 max of 30
    class PlayerSelector : Screen {
        public int PlayerAmt = 2;
        // Switch thing, so it only clears the line when it switches from 10 to 9 to correctly overwrite the previous line
        bool s = false;
        public PlayerSelector(KeyHandler.KeyHandler kh) : base(kh) {
            StartTransition();
        }
        public int GetPlayerAmount() {
            return PlayerAmt;
        }
        public override void Render() {
            if (PlayerAmt < 10) {
                if (s == false)
                    TextPrinter.ClearLine(3);
                s = true;
                TextPrinter.Print(10, 3, "Plr Amount: " + PlayerAmt);
            } else {
                s = false;
                TextPrinter.Print(7, 3, "Plr Amount: " + PlayerAmt.ToString().PadRight(4, '<'));
            }
            TextPrinter.Print(32, 12, "up/down");
            TextPrinter.Print(35, 22, "[ENTER]");
        }
        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (cki.Key == ConsoleKey.Enter) {
                FinalTransition();
            }
            if (cki.Key == ConsoleKey.DownArrow) {
                if (PlayerAmt > 2)
                    PlayerAmt--;
            } else if (cki.Key == ConsoleKey.UpArrow) {
                if (PlayerAmt < 30)
                    PlayerAmt++;
            }
        }
    }
    // Allows the user to select how many items 
    class ItemSelector : Screen {
        int rocks = 2;
        int papers = 2;
        int scissors = 2;
        int selector = 0;
        public ItemSelector(KeyHandler.KeyHandler kh) : base(kh) {
            StartTransition();
        }
        public (int, int, int) getAmounts() {
            return (rocks,papers,scissors);
        }

        public override void Render() {
            TextPrinter.Print(30, 3, "R");
            TextPrinter.Print(60, 3, "P");
            TextPrinter.Print(90, 3, "S");
            string rock = selector == 0 ? "[" + rocks + "]" : " " + rocks + " ";
            TextPrinter.Print(25, 20, rock);
            string paper = selector == 1 ? "[" + papers + "]" : " " + papers + " ";
            TextPrinter.Print(55, 20, paper);
            string scissor = selector == 2 ? "[" + scissors + "]" : " " + scissors + " ";
            TextPrinter.Print(85, 20, scissor);
        }

        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (cki.Key == ConsoleKey.RightArrow) {
                selector++;
                selector = selector % 3;
            } else if (cki.Key == ConsoleKey.LeftArrow) {
                selector--;
                if (selector <= -1) {
                    selector = 2;
                }
            } else if (cki.Key == ConsoleKey.UpArrow) {
                switch (selector) {
                    case 0:
                        rocks++;
                        if (rocks > 9) rocks = 9;
                        break;
                    case 1:
                        papers++;
                        if (papers > 9) papers = 9;
                        break;
                    case 2:
                        scissors++;
                        if (scissors > 9) scissors = 9;
                        break;
                }
            } else if (cki.Key == ConsoleKey.DownArrow) {
                switch (selector) {
                    case 0:
                        rocks--;
                        if (rocks < 2) rocks = 2;
                        break;
                    case 1:
                        papers--;
                        if (papers < 2) papers = 2;
                        break;
                    case 2:
                        scissors--;
                        if (scissors < 2) scissors = 2;
                        break;
                }
            } else if (cki.Key == ConsoleKey.Enter) {
                FinalTransition();
            }
        }
    }
    // Allows each player to select the name used to identify them.
    class NameSelector : Screen {
        private string name = "";
        private int index;
        private int oldLen;
        private string fakeName = "";
        public string getName() {
            return this.name;
        }
        public NameSelector(KeyHandler.KeyHandler kh, int index) : base(kh) {
            SetTransitionSpeed(2);
            StartTransition();
            this.index = index;
        }
        public override void Render() {
            // 9 Chars max
            if (oldLen != name.Length) {
                // if i have time, fix this so it doesnt have the flickering effect
                // nvm idc
                TextPrinter.ClearLine(16);
                oldLen = name.Length;
            }
            TextPrinter.Print(13, 7, "Player " + index + "");
            TextPrinter.Print(13, 16, fakeName.PadRight(9, '_'));
        }
        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (char.IsLetter(cki.KeyChar)) {
                int count = 0;
                for (int i = 0; i < name.Length; i++) {
                    if (name[i].ToString().ToLower() == "w" || name[i].ToString().ToLower() == "m" || name[i].ToString().ToLower() == "n") {
                        count++;
                    }
                }
                if (name.Length < 9 && count < 4) {
                    name += cki.KeyChar;
                    fakeName = name;
                }
            } else if (cki.Key == ConsoleKey.Backspace) {
                if (name.Length > 0) {
                    name = name.Remove(name.Length - 1, 1);
                    fakeName = name;
                }
            } else if (cki.Key == ConsoleKey.Enter) {
                if (name == "") return;
                accepting = false;
                fakeName = "█████████";
                FinalTransition();
            }
        }
    }
    // Only displays the order of the players.
    class OrderDisplay : Screen {
        Player[] plrs;
        public OrderDisplay(KeyHandler.KeyHandler kh, Player[] p) : base(kh) {
            StartTransition();
            this.plrs = p;
        }

        public override void Render() {
            TextPrinter.Print(7, 9, "Player Order:");
            Console.SetCursorPosition(7, 15);
            for (int i = 0; i < plrs.Length; i++) {
                Console.Write(plrs[i].getViewableIndex() + (i == plrs.Length-1 ? "" : ", "));
            }
            /*for (int i = 0; i < plrs.Length; i++) {
                if (i > 15) {
                    TextPrinter.Print(7 + (i-15) * 18, 24, plrs[i].getViewableIndex() + " ");
                } else if (i >= 10) {
                    TextPrinter.Print(7 + (i-10) * 18, 16, plrs[i].getViewableIndex() + " ");
                } else if (i < 10){
                    TextPrinter.Print(7 + i * 9, 9, plrs[i].getViewableIndex());
                }
            } */
        }
        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (cki.Key == ConsoleKey.Enter) {
                FinalTransition();
            }
        }
    }
    // Lets the current player select who they are going to go up against
    class ChallengerSelect : Screen {
        int playerInd;
        Player[] plrs;
        int challengeInd = 0;
        int prevInd = -1;
        public ChallengerSelect(KeyHandler.KeyHandler kh, int index, Player[] plrs, Player[] pOrder) : base(kh) {
            playerInd = pOrder[index].getInitIndex();
            this.plrs = plrs;

            while ((!plrs[challengeInd].getPlaying() || challengeInd == playerInd) && challengeInd < plrs.Length-1) {
                challengeInd++;
            }
            StartTransition();
        }
        public override void Render() {
            if (prevInd != challengeInd) {
                prevInd = challengeInd;
                TextPrinter.ClearLine(20);
            }
            TextPrinter.Print(10, 5, "Player " + (playerInd+1));
            TextPrinter.Print(10, 12, plrs[playerInd].getName());
            TextPrinter.Print(10, 20, "P " + (challengeInd+1) + "/" + plrs[challengeInd].getName() + (!plrs[challengeInd].getPlaying() ? " X" : ""));
        }
        public int getChallenger() {
            return challengeInd;
        }

        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (cki.Key == ConsoleKey.Enter) {
                if (plrs[challengeInd] == plrs[playerInd]) return;
                if (!plrs[challengeInd].getPlaying()) return;
                FinalTransition();
            } else if (cki.Key == ConsoleKey.RightArrow) {
                if (challengeInd < plrs.Length-1) {
                    challengeInd++;
                }
            } else if (cki.Key == ConsoleKey.LeftArrow) {
                if (challengeInd > 0) {
                    challengeInd--;
                }
            }
        }
    }
    // The screen for the main game where one person covers their side of the keyboard (a,s,d) so they can choose their option,
    // while the other person covers the numpad using (4,5,6) to choose (r,p,s)
    class RoundScreen : Screen {
        enum Options {
            ROCK, PAPER, SCISSORS, NONE
        }
        Player plr, chal;
        Player[] plrs;
        Options plrChoice = Options.NONE;
        Options chalChoice = Options.NONE;
        bool swip = false;
        bool gameFinished = false;
        int winner = -1;
        public RoundScreen(KeyHandler.KeyHandler kh, Player[] plrs, Player plrInd, Player chalInd) : base(kh) {
            this.plrs = plrs;
            this.plr = plrInd;
            this.chal = chalInd;
            StartTransition();
        }
        public void SplitStage() {
            for (int i = 0; i < cHeight - 1; i++) {
                Console.SetCursorPosition(cWidth / 2, i + 1);
                Console.Write('#');
            }
        }
        public void Stage1() {
            SplitStage();
            TextPrinter.Print(2, 2, "P" + (plr.getViewableIndex()));
            TextPrinter.Print(2, 8, plr.getName().Substring(0, plr.getName().Length >= 6 ? 6 : plr.getName().Length));
            TextPrinter.Print(cWidth / 2 + 2, 2, "P" + (chal.getViewableIndex()));
            TextPrinter.Print(cWidth / 2 + 2, 8, chal.getName().Substring(0, chal.getName().Length >= 6 ? 6 : chal.getName().Length));
            if (plrChoice != Options.NONE) {
                TextPrinter.Print(3, 15, "Locked<<");
                TextPrinter.Print(3, 23, "In>>>>");
            } else {
                TextPrinter.Print(3, 15, "R  P  S");
                TextPrinter.Print(3, 23, "A  S  D");
            }
            if (chalChoice != Options.NONE) {
                TextPrinter.Print(cWidth / 2 + 3, 15, "Locked<<");
                TextPrinter.Print(cWidth / 2 + 3, 23, "In>>>>");
            } else {
                TextPrinter.Print(cWidth / 2 + 3, 15, "R  P  S");
                TextPrinter.Print(cWidth / 2 + 3, 23, "4  5  6");
            }
        }
        private string reverseString(string str) {
            string built = "";
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == '(') {
                    built += ')';
                } else if (str[i] == ')') {
                    built += '(';
                } else {
                    built += str[i];
                }
            }
            char[] charA = built.ToCharArray();
            Array.Reverse(charA);
            return new string(charA);
        }
        public override void Render() {
            if (plrChoice == Options.NONE || chalChoice == Options.NONE) {
                winner = -1;
                Stage1();
            } else {
                if (swip == false) {
                    Console.Clear();
                    swip = true;
                    switch (plrChoice) {
                        case Options.ROCK:
                            plr.Rock--;
                            break;
                        case Options.PAPER:
                            plr.Paper--;
                            break;
                        case Options.SCISSORS:
                            plr.Scissors--;
                            break;
                    }
                    switch (chalChoice) {
                        case Options.ROCK:
                            chal.Rock--;
                            break;
                        case Options.PAPER:
                            chal.Paper--;
                            break;
                        case Options.SCISSORS:
                            chal.Scissors--;
                            break;
                    }
                    if ((plrChoice == Options.ROCK && chalChoice == Options.SCISSORS) || (plrChoice == Options.PAPER && chalChoice == Options.ROCK) || (plrChoice == Options.SCISSORS && chalChoice == Options.PAPER)) {
                        winner = 0;
                        plr.increasePoints();
                        chal.decreasePoints();
                    }
                    if ((chalChoice == Options.ROCK && plrChoice == Options.SCISSORS) || (chalChoice == Options.PAPER && plrChoice == Options.ROCK) || (chalChoice == Options.SCISSORS && plrChoice == Options.PAPER)) {
                        winner = 1;
                        plr.decreasePoints();
                        chal.increasePoints();
                    }
                }
                SplitStage();
                TextPrinter.Print(2, 2, "P" + plr.getViewableIndex() + (winner == 0 ? " WIN" : "") + (winner == -1 ? " TIE" : ""));
                TextPrinter.Print(cWidth / 2 + 2, 2, "P" + chal.getViewableIndex() + (winner == 1 ? " WIN" : "") + (winner == -1 ? " TIE" : ""));
                string[] rock = new string[] {
                    "    _______   ",
                    "---'   ____)  ",
                    "      (_____) ",
                    "      (_____) ",
                    "      (____)  ",
                    "---.__(___)   "
                };
                string[] paper = new string[] {
                    "     _______      ",
                    "---'    ____)____ ",
                    "           ______)",
                    "          _______)",
                    "         _______) ",
                    "---.__________)   "
                };
                string[] scissors = new string[] {
                    "    _______       ",
                    "---'   ____)____  ",
                    "          ______) ",
                    "       __________)",
                    "      (____)      ",
                    "---.__(___)       "
                };
                if (plrChoice == Options.ROCK) {
                    TextPrinter.Print(2, 14, "ROCK");
                    for (int i = 0; i < rock.Length; i++) {
                        Console.SetCursorPosition(20, 20 + i);
                        Console.Write(rock[i]);
                    }
                } else if (plrChoice == Options.PAPER) {
                    TextPrinter.Print(2, 14, "PAPER");
                    for (int i = 0; i < paper.Length; i++) {
                        Console.SetCursorPosition(20, 20 + i);
                        Console.Write(paper[i]);
                    }
                } else if (plrChoice == Options.SCISSORS) {
                    TextPrinter.Print(2, 14, "SCISSOR");
                    for (int i = 0; i < scissors.Length; i++) {
                        Console.SetCursorPosition(20, 20 + i);
                        Console.Write(scissors[i]);
                    }
                }
                if (chalChoice == Options.ROCK) {
                    TextPrinter.Print(cWidth-58, 14, "ROCK");
                    for (int i = 0; i < rock.Length; i++) {
                        Console.SetCursorPosition(cWidth - 40, 20 + i);
                        Console.Write(reverseString(rock[i]));
                    }
                } else if (chalChoice == Options.PAPER) {
                    TextPrinter.Print(cWidth - 58, 14, "PAPER");
                    for (int i = 0; i < paper.Length; i++) {
                        Console.SetCursorPosition(cWidth - 40, 20 + i);
                        Console.Write(reverseString(paper[i]));
                    }
                } else if (chalChoice == Options.SCISSORS) {
                    TextPrinter.Print(cWidth - 58, 14, "SCISSOR");
                    for (int i = 0; i < scissors.Length; i++) {
                        Console.SetCursorPosition(cWidth - 40, 20 + i);
                        Console.Write(reverseString(scissors[i]));
                    }
                }
            }
        }
        public bool IsGameFinished() {
            return gameFinished;
        }
        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (cki.Key == ConsoleKey.A && plrChoice == Options.NONE && plr.Rock > 0) {
                plrChoice = Options.ROCK;
            } else if (cki.Key == ConsoleKey.S && plrChoice == Options.NONE && plr.Paper > 0) {
                plrChoice = Options.PAPER;
            } else if (cki.Key == ConsoleKey.D && plrChoice == Options.NONE && plr.Scissors > 0) {
                plrChoice = Options.SCISSORS;
            }
            if ((cki.Key == ConsoleKey.NumPad4 || cki.Key == ConsoleKey.D4) && chalChoice == Options.NONE && chal.Rock > 0) {
                chalChoice = Options.ROCK;
            } else if ((cki.Key == ConsoleKey.NumPad5 || cki.Key == ConsoleKey.D5) && chalChoice == Options.NONE && chal.Paper > 0) {
                chalChoice = Options.PAPER;
            } else if ((cki.Key == ConsoleKey.NumPad6 || cki.Key == ConsoleKey.D6) && chalChoice == Options.NONE && chal.Scissors > 0) {
                chalChoice = Options.SCISSORS;
            }
            if (cki.Key == ConsoleKey.Enter) {
                if (!(plrChoice == Options.NONE || chalChoice == Options.NONE)) {
                    int playersLeft = plrs.Length;
                    for (int i = 0; i < plrs.Length; i++) {
                        if ((plrs[i].Rock < 1 && plrs[i].Paper < 1 && plrs[i].Scissors < 1) || (plrs[i].getPoints() < 1)) {
                            playersLeft--;
                        }
                    }
                    if (playersLeft <= 1) {
                        gameFinished = true;
                    }
                    FinalTransition();
                }
            }
        }
    }
    // Displays the winners, and allows you to view the final points by using the arrow keys
    class WinnerScreen : Screen {
        Player[] winners;
        bool screen1 = false;
        // swip is back at it again, fixing the flickering !!!
        bool swip = false;
        public WinnerScreen(KeyHandler.KeyHandler kh, Player[] winners) : base(kh) {
            this.winners = winners;
            StartTransition();
        }
        public void PrintPlace(int ind, string place) {
            TextPrinter.Print(2, 6 + 8 * ind, $"{place}: P" + winners[ind].getViewableIndex() + " " + winners[ind].getName());
        }
        public override void Render() {
            if (!screen1) {
                if (swip) {
                    TextPrinter.ClearLine(6);
                    TextPrinter.ClearLine(14);
                    TextPrinter.ClearLine(22);
                    swip = false;
                }
                PrintPlace(0, "1st");
                PrintPlace(1, "2nd");
                if (winners.Length > 2) {
                    PrintPlace(2, "3rd");
                }
            } else {
                if (!swip) {
                    TextPrinter.ClearLine(6);
                    TextPrinter.ClearLine(14);
                    TextPrinter.ClearLine(22);
                    swip = true;
                }
                TextPrinter.Print(2, 6, "1st with " + winners[0].getPoints() + "p");
                TextPrinter.Print(2, 14, "2nd with " + winners[1].getPoints() + "p");
                if (winners.Length > 2) {
                    TextPrinter.Print(2, 22, "3rd with " + winners[2].getPoints() + "p");
                }
            }
        }
        public override void OnKeyPress(ConsoleKeyInfo cki) {
            if (cki.Key == ConsoleKey.RightArrow || cki.Key == ConsoleKey.LeftArrow) {
                screen1 = !screen1;
            }
        }
    }
    // Just the player, holds basic information about them.
    class Player {
        private int Points = 3;
        public int Rock;
        public int Paper;
        public int Scissors;
        private string Name;
        private int initIndex;
        private int viewableIndex;
        private bool StillPlaying = true;
        public Player(int rock, int paper, int scissors, string name, int index) {
            this.Rock = rock;
            this.Paper = paper;
            this.Scissors = scissors;
            this.Name = name;
            this.initIndex = index;
            this.viewableIndex = index + 1;
        }
        public string getName() {
            return Name;
        }
        public int getInitIndex() {
            return initIndex;
        }
        public int getViewableIndex() {
            return viewableIndex;
        }
        public int getPoints() {
            return Points;
        }
        public void increasePoints() {
            this.Points = this.Points+1;
        }
        public void decreasePoints() {
            this.Points = this.Points - 1;
        }
        public void Lost() {
            StillPlaying = false;
        }
        public bool getPlaying() {
            return StillPlaying;
        }
    }
    internal class Program {
        // These are added in .NET 8
        // so i decided to use it here as we are just using a lower version of .NET
        // (it still uses the shuffle method talked about in class)
        // https://github.com/dotnet/runtime/blob/5535e31a712343a63f5d7d796cd874e563e5ac14/src/libraries/System.Private.CoreLib/src/System/Random.cs#L261C13-L263C10
        public static void Shuffle<T>(T[] values) {
            ArgumentNullException.ThrowIfNull(values);
            Shuffle(values.AsSpan());
        }
        public static void Shuffle<T>(Span<T> values) {
            Random rng = new Random();
            int n = values.Length;

            for (int i = 0; i < n - 1; i++) {
                int j = rng.Next(i, n);

                if (j != i) {
                    T temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                }
            }
        }

        // sorry for the weird name, all this does is just render a screen until said screen is finished then return the object for further usage of variables or methods.
        /*  ex.
         *  MainMenu mm = new MainMenu(kh);
         *  RenderizeScreen(mm);
         *  or.
         *  NameSelector ns = new NameSelector(kh);
         *  string playerName = RenderizeScreen(ns).GetName();
         *  (where NameSelector class has a public method called GetName)
         */
        public static T RenderizeScreen<T>(T s) where T : Screen {
            while (true) {
                Console.CursorVisible = false;
                s.RenderScreen();
                if (s.IsFinished()) break;
            }
            return s;
        }
        // where the magic happens
        public static void Main(string[] args) {
            // Main keyhandler used for every screen, this handles key input and makes sure to correctly pass the pressed keys to the screen.
            KeyHandler.KeyHandler kh = new KeyHandler.KeyHandler();

            /* These fixes that are being initlizied are to fix the console being weird
             * FreezeFix : Happens when a user clicks off, which freezes the consoles and can mess up transitions
             * SizingFix : Just disables the ability to resize the window as that completely messes it up
             * BufferWidth/BufferHeight : Removes the ability to scroll in the console and removes the scrollbar
             */
            FreezeFix.FreezeFix.init();
            SizingFix.SizingFix.init();
            Console.WindowHeight = 30;
            Console.WindowWidth = 120;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;

            // Just a main menu, not much else
            MainMenu mm = new MainMenu(kh);
            RenderizeScreen(mm);

            // Get the amount of players for the tournament
            PlayerSelector ps = new PlayerSelector(kh);
            int playerAmount = RenderizeScreen(ps).PlayerAmt;

            // Get the amount of rocks, papers and scissors for these rounds
            ItemSelector itemS = new ItemSelector(kh);
            (int, int, int) amount = RenderizeScreen(itemS).getAmounts();

            // Populates the player array with the specified rock paper scissor amount and gives them a name
            Player[] players = new Player[playerAmount];
            for (int i = 0; i < playerAmount; i++) {
                NameSelector ns = new NameSelector(kh, i + 1);
                string name = RenderizeScreen(ns).getName();
                players[i] = new Player(amount.Item1, amount.Item2, amount.Item3, name, i);
            }
            // Game loop, runs until there is either noone left with rock paper or scissors, or just one is left.
            bool notFinished = true;
            while (notFinished) {
                // Randomize players
                Player[] pOrder = (Player[])players.Clone();
                Shuffle(pOrder);

                // Display Order
                RenderizeScreen(new OrderDisplay(kh, pOrder));

                // Start the games !!
                for (int i = 0; i < pOrder.Length; i++) {
                    // Some checks to stop players that cant play, from playing, skips over the selector if they have nothing, and puts a x and makes them unselectable in the challenge select.
                    for (int j = 0; j < players.Length; j++) {
                        if ((pOrder[j].Rock < 1 && pOrder[j].Paper < 1 && pOrder[j].Scissors < 1) || (pOrder[j].getPoints() < 1)) {
                            pOrder[j].Lost();
                        }
                    }
                    for (int j = 0; j < players.Length; j++) {
                        if ((players[j].Rock < 1 && players[j].Paper < 1 && players[j].Scissors < 1) || (players[j].getPoints() < 1)) {
                            players[j].Lost();
                        }
                    }
                    if (!pOrder[i].getPlaying()) continue;
                    // A screen to let the current person choose someone to go up against, and return the index of said player chosen.
                    ChallengerSelect cs = new ChallengerSelect(kh, i, players, pOrder);
                    int challengerInd = RenderizeScreen(cs).getChallenger();
                    // Just the round screen, its when the selector goes against the person they challenged, returns if the entire game is finished.
                    RoundScreen rs = new RoundScreen(kh, players, pOrder[i], players[challengerInd]);
                    bool finished = RenderizeScreen(rs).IsGameFinished();
                    if (finished) {
                        notFinished = false;
                        break;
                    }
                }
            }

            // determine winner !!!!!
            // https://www.tutorialsteacher.com/articles/sort-object-array-by-specific-property-in-csharp#:~:text=The%20same%20result%20can%20be%20achieved%20using%20LINQ%20query%20easily,%20as%20shown%20below.
            var sortedPlayers = from p in players
                      orderby p.getPoints()
                      select p;
            Player[] topPlayers = sortedPlayers.Reverse().ToArray();

            WinnerScreen ws = new WinnerScreen(kh, topPlayers);
            RenderizeScreen(ws);
        }
    }
}