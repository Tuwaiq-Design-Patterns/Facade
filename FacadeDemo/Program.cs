using System;

namespace FacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            TalkingFacade talkingFacade = new TalkingFacade(new Brain(), new Lips(), new Tongue());
            
            human.GonnaTalk(talkingFacade);
        }
    }
}