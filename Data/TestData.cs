﻿namespace HopfieldNetwork.Data
{
    public static class TestData
    {
        public static IEnumerable<Letter> Letters = new[] {
            new Letter
            {
                Character = 'Н',
                Representation = new int[,]{
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1,  1,  1,  1,  1,  1,  1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 }
                }
            },
            new Letter
            {
                Character = 'К',
                Representation = new int[,]{
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1,  1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1,  1, -1, -1, -1 },
                    { -1, 1, -1,  1,  1,  1, -1, -1, -1, -1 },
                    { -1, 1, -1, -1, -1,  1, -1, -1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1,  1, -1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1,  1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 }
                }
            },
            new Letter
            {
                Character = 'Л',
                Representation = new int[,]{
                    { -1, -1, -1, -1, -1, -1, -1,  1, 1, -1 },
                    { -1, -1, -1, -1, -1, -1,  1, -1, 1, -1 },
                    { -1, -1, -1, -1, -1,  1, -1, -1, 1, -1 },
                    { -1, -1, -1, -1,  1, -1, -1, -1, 1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1, 1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1, 1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1, 1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1, 1, -1 },
                    { -1, -1,  1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1, 1, -1 }
                }
            },
            new Letter
            {
                Character = 'В',
                Representation = new int[,]{
                    { -1, 1,  1,  1,  1,  1,  1, -1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1,  1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1,  1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1,  1, -1, -1 },
                    { -1, 1,  1,  1,  1,  1,  1, -1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1,  1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1,  1,  1,  1,  1,  1,  1, -1, -1 }
                }
            },
            new Letter
            {
                Character = '-',
                Representation = new int[,]{
                    { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1, -1, -1,  1,  1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1,  1, -1, -1, -1, -1, -1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1,  1, -1, -1, -1,  1, -1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1, -1, -1 }
                }
            },
            new Letter
            {
                Character = 'Л',
                Representation = new int[,]{
                    { -1, -1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1,  1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1,  1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1,  1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1,  1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1,  1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1, -1, -1 }
                }
            },
            new Letter
            {
                Character = 'Н',
                Representation = new int[,]{
                    {  1,  1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1,  1, -1,  1,  1, -1,  1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1,  1, -1 }
                }
            },
            new Letter
            {
                Character = 'К',
                Representation = new int[,]{
                    { -1,  1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1,  1, -1, -1, -1, -1,  1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1,  1, -1, -1 },
                    { -1, -1, -1, -1, -1, -1,  1, -1, -1, -1 },
                    { -1,  1, -1,  1, -1,  1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1,  1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1,  1,  1, -1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1,  1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1,  1, -1 }
                }
            },
            new Letter
            {
                Character = 'И',
                Representation = new int[,]{
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1,  1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1,  1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1,  1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1,  1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1,  1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1,  1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1, 1, -1 }
                }
            },
            new Letter
            {
                Character = 'Н',
                Representation = new int[,]{
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1,  1,  1,  1,  1,  1, -1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 },
                    { -1, 1, -1, -1, -1, -1, -1, -1,  1, -1 }
                }
            }
        };
    }
}