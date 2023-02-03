using System;
using System.Collections.Generic;
using System.Text;

namespace LabirintGame
{
    class Wall : MapSite
    {
        public Wall()
        {
        }
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}