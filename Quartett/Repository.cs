﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartett
{
    class Repository
    {
        public int cards = magic.Count();

        public string[] name = new string[]
        {  "Fleur Delacour",
           "Rubeus Hagrid",
           "Vincent Crabbe",
           "Barty Crouch",
           "Parvati Patil",
           "Rita Kimmkorn",
           "Ron Weasley",
           "Arthur Weasley",
           "Professor Moody",
           "Madame Maxime",
           "Ungarischer Hornschwanz",
           "Gabrielle Delacour",
           "Cedric Diggory",
           "Hermine Granger",
           "Fred Weasley",
           "George Weasley",
           "Cho Chang",
           "Lucius Malfoy",
           "Draco Malfoy",
           "Professor Karkaroff",
           "Padma Patil",
           "Barty Crouch Jr",
           "Professor Dumbledore",
           "Harry Potter",
           "Gregory Goyle",
           "Viktor Krum",
           "Neville Longbottom",
           "Professor Snape",
           "Cornelius Fudge",
           "Professor Mcgonagall"
        };

        public static int[] magic = new int[]
        {
            59,
            12,
            10,
            90,
            24,
            40,
            45,
            62,
            82,
            96,
            0,
            15,
            58,
            60,
            87,
            87,
            40,
            62,
            42,
            79,
            24,
            70,
            105,
            62,
            10,
            56,
            24,
            85,
            52,
            95
        };

        public static int[] cleverness = new int[]
        {
            19,
            11,
            13,
            24,
            11,
            24,
            14,
            5,
            20,
            13,
            15,
            11,
            23,
            16,
            13,
            13,
            8,
            21,
            22,
            22,
            9,
            23,
            21,
            21,
            14,
            22,
            9,
            24,
            14,
            19
        };

        public static int[] braveness = new int[]
        {
            36,
            30,
            8,
            26,
            23,
            11,
            40,
            29,
            35,
            20,
            21,
            30,
            40,
            40,
            30,
            30,
            25,
            42,
            10,
            19,
            23,
            0,
            39,
            42,
            7,
            38,
            28,
            19,
            25,
            29
        };
        public static int[] knowledge = new int[]
        {
            54,
            8,
            4,
            80,
            15,
            61,
            22,
            60,
            69,
            70,
            0,
            15,
            55,
            73,
            22,
            22,
            31,
            26,
            12,
            79,
            13,
            31,
            82,
            26,
            2,
            30,
            15,
            71,
            44,
            76
        };

        public static int[] hate = new int[]
        {
            6,
            7,
            7,
            1,
            2,
            7,
            4,
            2,
            5,
            4,
            10,
            0,
            2,
            2,
            4,
            4,
            3,
            7,
            9,
            8,
            1,
            9,
            0,
            7,
            8,
            7,
            2,
            7,
            4,
            5
        };

        public static string[] picture = new string[]
        {
            "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%",
            "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%",
            "%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&%%#%%%%%%%%%%%%%%%%%%%%%%%%%",
            "%%%%%%%%%%%%%%%%%%##&&@@@@@@@@@@&%#%&%&%#%%%%%%%%%%%%%%%%%%",
            "%%%%%%%%%%%%%%%%%%%##%&@&@@@@@&&&&%%#%&&@&%#%%%%%%%%%%%%%%%",
            "%%%%%%%%%%%#%%%%%%##&%&@@@@@@&&@&%%#%@&@@@@#%##%%%%%%%%%%",
            "%%%%%%%%%%%%%%%&%#%%#%&@@@@&&&%%&&&@@@@@@@@@######%%%%%%%%%",
            "%%%%%%%%%%%%&&&(#%##%&&@@@&@&%%&%%##&@@@@@@@@#####%%%%%%%%%",
            "%%%%%%%%%%%&&%(#%%#%##%&&&&@@@#%%&&%&&%&@@@@@##%%%%%%%%%%",
            "%%%%%%%%%%&@&&%#(##(#%##&&&&@&%&&&@@@@@@@@@@%###%%%%%%%%%",
            "%%%%%%####%@&%#%&&%%%##%#(%%%%%#%@@@@@@@@@@@@@#%%%%%%%%%%",
            "%%%%#%####&@&&@&&@&%&%##(##%%%&%%&@@@@@@@@@@@@@%%%%%%%%%%%%",
            "%%%######%@@@@@&&&%(#%&%#&%&&&&@@@@@@@@@@@@@@%#%###%%%%%%",
            "%%%%%%%###@@@@@&%##(*,(%//%&%#%%@@@@@@@@@@@@@#%%#%%%%%%",
            "%%%%%%%##%@@&@@#*,*/,..(*/#%#%%(/(&@@@@@@@@@@@@%########%%%",
            "###########@@&@(..*,,*(%**/(#&&&&&&@&%%&@@@@@############",
            "###########@@&@%,,,(/(#%##*,,(&&&&&&&&%#&@@@###########",
            "###########%@@@%.**,****/,/..,##//(#%%%%%#&@@@##%##########",
            "############%@@%,.,,..,,,.*. ,#((***//(#%%&@###############",
            "#############&@&*,..**,*/,...,(#(,,*/(#%%%@%###############",
            "##############%@/,,..........,(#%*,,*(#%%&@@%%#############",
            "###############%&(,,......*/(%@@@#**/#%%%@@%###############",
            "################%&*,,,........,*(###%&&%#################",
            "##################%*,,,,,,,,*//(##((&&&%###################",
            "##################%*,,,,******/(#%&&@&&@###############",
            "###############%&&&@*.*,,.....,,*(&&@@@&@%@@&%#############",
            "###########%&@@&&@@/  ,,*/*//((#%&@@@@@@@&@@@@@@@########",
            "########%&&@&@@&&@%*   .,,*(#%&&@@@@@@@@@@@@@@@@@@@%%######",
            "####%&&@&&&&&&&&&@((..   .,*/(%%&&@@@@@@@@@@@@@@@@@@@@@##",
            "##%&&&&&&&&&&&&&@&/%/       ./(/,,/(%&&@@@@@@@@@@@@@@@@@@@%",
            "%&@&&&&&&&&&&&&&@&%##*     .#%%&,,*/#%%#@@%@@@@@@@@@@@@@@@@",
            "&&&&@@&&&&&&&&&&@(#(%#,   ,%/*#&&,*//,*&&@@@@@@@@@@@@@@@@",
            "&&&&&&&&&&&@@&&@%((%/%#.  %&%&@&(.**,*%&(&@&@@@@@@@@@@@@@@@",
            "@&@@&&@@&&&@&&&@%#((#%##/(&&%%(((..*(%&(&@&%@@@@@@@@@@@@@@@",
            "@&@&&@@@&@@@&&&@#(##(#%#%#&(*(/%&(/#%#(&&%%%@@@@@@@@@@@@@@@",
            "@@@&&@@&&@@@&@@@#((#(#(%(%#/*#%#%&(&%&%#%%@@@@@@@@@@@@@@@",
            "@@@@@&&&@@@@@@@@#((#(((((########&%%%%###%@@@@@@@@@@@@@@@",
            "@@@@@&&@@@@@@@@@#(##((((#(%(%%((%%%%%%%%%##%@@@@@@@@@@@@@@@",
            "@@@@@&@@@@@@@@@@#####((#####&%#(##%#%##%%##&@@@@@@@@@@@@@@@",
            "@@@@@&@@@@@@@@@@#####((#####((##%%%%%%%%%%#&@@@@@@@@@@@@@@@",
            "@@@@&@@@@@@@@@@@#####(#####%%######%%%%%###&@@@@@@@@@@@@@@@"
        };

        public int[][] stats = { magic, cleverness, braveness, knowledge, hate };

        public string[] unit = new string[]
        {
            "Magic",
            "Cleverness",
            "Braveness",
            "Knowledge",
            "Hate"
        };
    }
}