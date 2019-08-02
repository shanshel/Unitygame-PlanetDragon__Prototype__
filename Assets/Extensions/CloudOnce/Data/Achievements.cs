// <copyright file="Achievements.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CloudOnce
{
    using System.Collections.Generic;
    using Internal;

    /// <summary>
    /// Provides access to achievements registered via the CloudOnce Editor.
    /// This file was automatically generated by CloudOnce. Do not edit.
    /// </summary>
    public static class Achievements
    {
        private static readonly UnifiedAchievement s_chickenPlanet = new UnifiedAchievement("ChickenPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQAg"
#else
            "ChickenPlanet"
#endif
            );

        public static UnifiedAchievement ChickenPlanet
        {
            get { return s_chickenPlanet; }
        }

        private static readonly UnifiedAchievement s_sheepPlanet = new UnifiedAchievement("SheepPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQAw"
#else
            "SheepPlanet"
#endif
            );

        public static UnifiedAchievement SheepPlanet
        {
            get { return s_sheepPlanet; }
        }

        private static readonly UnifiedAchievement s_pigPlanet = new UnifiedAchievement("PigPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQBA"
#else
            "PigPlanet"
#endif
            );

        public static UnifiedAchievement PigPlanet
        {
            get { return s_pigPlanet; }
        }

        private static readonly UnifiedAchievement s_goatPlanet = new UnifiedAchievement("GoatPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQBQ"
#else
            "GoatPlanet"
#endif
            );

        public static UnifiedAchievement GoatPlanet
        {
            get { return s_goatPlanet; }
        }

        private static readonly UnifiedAchievement s_horsePlanet = new UnifiedAchievement("HorsePlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQBg"
#else
            "HorsePlanet"
#endif
            );

        public static UnifiedAchievement HorsePlanet
        {
            get { return s_horsePlanet; }
        }

        private static readonly UnifiedAchievement s_cowPlanet = new UnifiedAchievement("CowPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQBw"
#else
            "CowPlanet"
#endif
            );

        public static UnifiedAchievement CowPlanet
        {
            get { return s_cowPlanet; }
        }

        private static readonly UnifiedAchievement s_bullPlanet = new UnifiedAchievement("BullPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQCA"
#else
            "BullPlanet"
#endif
            );

        public static UnifiedAchievement BullPlanet
        {
            get { return s_bullPlanet; }
        }

        private static readonly UnifiedAchievement s_hippoPlanet = new UnifiedAchievement("HippoPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQCQ"
#else
            "HippoPlanet"
#endif
            );

        public static UnifiedAchievement HippoPlanet
        {
            get { return s_hippoPlanet; }
        }

        private static readonly UnifiedAchievement s_starFishPlanet = new UnifiedAchievement("StarFishPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQCg"
#else
            "StarFishPlanet"
#endif
            );

        public static UnifiedAchievement StarFishPlanet
        {
            get { return s_starFishPlanet; }
        }

        private static readonly UnifiedAchievement s_wolfPlanet = new UnifiedAchievement("WolfPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQCw"
#else
            "WolfPlanet"
#endif
            );

        public static UnifiedAchievement WolfPlanet
        {
            get { return s_wolfPlanet; }
        }

        private static readonly UnifiedAchievement s_tigerPlanet = new UnifiedAchievement("TigerPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQDA"
#else
            "TigerPlanet"
#endif
            );

        public static UnifiedAchievement TigerPlanet
        {
            get { return s_tigerPlanet; }
        }

        private static readonly UnifiedAchievement s_pandaPlanet = new UnifiedAchievement("PandaPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQDQ"
#else
            "PandaPlanet"
#endif
            );

        public static UnifiedAchievement PandaPlanet
        {
            get { return s_pandaPlanet; }
        }

        private static readonly UnifiedAchievement s_deerPlanet = new UnifiedAchievement("DeerPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQDg"
#else
            "DeerPlanet"
#endif
            );

        public static UnifiedAchievement DeerPlanet
        {
            get { return s_deerPlanet; }
        }

        private static readonly UnifiedAchievement s_dragonPlanet = new UnifiedAchievement("DragonPlanet",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQDw"
#else
            "DragonPlanet"
#endif
            );

        public static UnifiedAchievement DragonPlanet
        {
            get { return s_dragonPlanet; }
        }

        private static readonly UnifiedAchievement s_chickenEater = new UnifiedAchievement("ChickenEater",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQEA"
#else
            "ChickenEater"
#endif
            );

        public static UnifiedAchievement ChickenEater
        {
            get { return s_chickenEater; }
        }

        private static readonly UnifiedAchievement s_horseRider = new UnifiedAchievement("HorseRider",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQEQ"
#else
            "HorseRider"
#endif
            );

        public static UnifiedAchievement HorseRider
        {
            get { return s_horseRider; }
        }

        private static readonly UnifiedAchievement s_planetEater = new UnifiedAchievement("PlanetEater",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQEg"
#else
            "PlanetEater"
#endif
            );

        public static UnifiedAchievement PlanetEater
        {
            get { return s_planetEater; }
        }

        private static readonly UnifiedAchievement s_bronzeMedal = new UnifiedAchievement("BronzeMedal",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQEw"
#else
            "BronzeMedal"
#endif
            );

        public static UnifiedAchievement BronzeMedal
        {
            get { return s_bronzeMedal; }
        }

        private static readonly UnifiedAchievement s_bronzeCup = new UnifiedAchievement("BronzeCup",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQFA"
#else
            "BronzeCup"
#endif
            );

        public static UnifiedAchievement BronzeCup
        {
            get { return s_bronzeCup; }
        }

        private static readonly UnifiedAchievement s_bronzeCrown = new UnifiedAchievement("BronzeCrown",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQFQ"
#else
            "BronzeCrown"
#endif
            );

        public static UnifiedAchievement BronzeCrown
        {
            get { return s_bronzeCrown; }
        }

        private static readonly UnifiedAchievement s_sliverMedal = new UnifiedAchievement("SliverMedal",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQFg"
#else
            "SliverMedal"
#endif
            );

        public static UnifiedAchievement SliverMedal
        {
            get { return s_sliverMedal; }
        }

        private static readonly UnifiedAchievement s_sliverCup = new UnifiedAchievement("SliverCup",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQFw"
#else
            "SliverCup"
#endif
            );

        public static UnifiedAchievement SliverCup
        {
            get { return s_sliverCup; }
        }

        private static readonly UnifiedAchievement s_sliverCrown = new UnifiedAchievement("SliverCrown",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQGA"
#else
            "SliverCrown"
#endif
            );

        public static UnifiedAchievement SliverCrown
        {
            get { return s_sliverCrown; }
        }

        private static readonly UnifiedAchievement s_goldMedal = new UnifiedAchievement("GoldMedal",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQGQ"
#else
            "GoldMedal"
#endif
            );

        public static UnifiedAchievement GoldMedal
        {
            get { return s_goldMedal; }
        }

        private static readonly UnifiedAchievement s_goldCup = new UnifiedAchievement("GoldCup",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQGg"
#else
            "GoldCup"
#endif
            );

        public static UnifiedAchievement GoldCup
        {
            get { return s_goldCup; }
        }

        private static readonly UnifiedAchievement s_goldCrown = new UnifiedAchievement("GoldCrown",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQGw"
#else
            "GoldCrown"
#endif
            );

        public static UnifiedAchievement GoldCrown
        {
            get { return s_goldCrown; }
        }

        private static readonly UnifiedAchievement s_youRock = new UnifiedAchievement("YouRock",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQHA"
#else
            "YouRock"
#endif
            );

        public static UnifiedAchievement YouRock
        {
            get { return s_youRock; }
        }

        private static readonly UnifiedAchievement s_unbelievable = new UnifiedAchievement("Unbelievable",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQHQ"
#else
            "Unbelievable"
#endif
            );

        public static UnifiedAchievement Unbelievable
        {
            get { return s_unbelievable; }
        }

        private static readonly UnifiedAchievement s_epic = new UnifiedAchievement("Epic",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            "CgkItNyolLYREAIQHg"
#else
            "Epic"
#endif
            );

        public static UnifiedAchievement Epic
        {
            get { return s_epic; }
        }

        public static readonly UnifiedAchievement[] All =
        {
            s_chickenPlanet,
            s_sheepPlanet,
            s_pigPlanet,
            s_goatPlanet,
            s_horsePlanet,
            s_cowPlanet,
            s_bullPlanet,
            s_hippoPlanet,
            s_starFishPlanet,
            s_wolfPlanet,
            s_tigerPlanet,
            s_pandaPlanet,
            s_deerPlanet,
            s_dragonPlanet,
            s_chickenEater,
            s_horseRider,
            s_planetEater,
            s_bronzeMedal,
            s_bronzeCup,
            s_bronzeCrown,
            s_sliverMedal,
            s_sliverCup,
            s_sliverCrown,
            s_goldMedal,
            s_goldCup,
            s_goldCrown,
            s_youRock,
            s_unbelievable,
            s_epic,
        };

        public static string GetPlatformID(string internalId)
        {
            return s_achievementDictionary.ContainsKey(internalId)
                ? s_achievementDictionary[internalId].ID
                : string.Empty;
        }

        private static readonly Dictionary<string, UnifiedAchievement> s_achievementDictionary = new Dictionary<string, UnifiedAchievement>
        {
            { "ChickenPlanet", s_chickenPlanet },
            { "SheepPlanet", s_sheepPlanet },
            { "PigPlanet", s_pigPlanet },
            { "GoatPlanet", s_goatPlanet },
            { "HorsePlanet", s_horsePlanet },
            { "CowPlanet", s_cowPlanet },
            { "BullPlanet", s_bullPlanet },
            { "HippoPlanet", s_hippoPlanet },
            { "StarFishPlanet", s_starFishPlanet },
            { "WolfPlanet", s_wolfPlanet },
            { "TigerPlanet", s_tigerPlanet },
            { "PandaPlanet", s_pandaPlanet },
            { "DeerPlanet", s_deerPlanet },
            { "DragonPlanet", s_dragonPlanet },
            { "ChickenEater", s_chickenEater },
            { "HorseRider", s_horseRider },
            { "PlanetEater", s_planetEater },
            { "BronzeMedal", s_bronzeMedal },
            { "BronzeCup", s_bronzeCup },
            { "BronzeCrown", s_bronzeCrown },
            { "SliverMedal", s_sliverMedal },
            { "SliverCup", s_sliverCup },
            { "SliverCrown", s_sliverCrown },
            { "GoldMedal", s_goldMedal },
            { "GoldCup", s_goldCup },
            { "GoldCrown", s_goldCrown },
            { "YouRock", s_youRock },
            { "Unbelievable", s_unbelievable },
            { "Epic", s_epic },
        };
    }
}
