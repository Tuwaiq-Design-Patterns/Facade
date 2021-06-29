using System;

namespace FacadeDemo
{
    public class Human
    {
        public void GonnaTalk(TalkingFacade talkingFacade)
        {
            Console.WriteLine("Human: I am Gonna Talk");
            talkingFacade.LetsTalk();
        }
    }
}