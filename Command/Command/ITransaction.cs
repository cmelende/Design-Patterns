﻿namespace Command.Command
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }
}
