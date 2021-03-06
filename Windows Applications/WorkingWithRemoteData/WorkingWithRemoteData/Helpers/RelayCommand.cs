﻿namespace WorkingWithRemoteData.Helpers
{
    using System;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        private Action execute;
        private Func<bool> canExecute;
        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecute == null)
            {
                return true;
            }
            return this.canExecute();
        }               

        public void Execute(object parameter)
        {
            this.execute();
        }
    }
}
