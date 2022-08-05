// Copyright (c) Virtuous. Licensed under the MIT license.
// See LICENSE.md in the project root for license information.

namespace RenderingDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(GameMaster game = new GameMaster())
            {
                game.Run();
            }
        }
    }
}