using Avalonia.OpenGL;
using PearlCalculatorCP.Models;
using PearlCalculatorCP.ViewModels;
using PearlCalculatorLib.PearlCalculationLib.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PearlCalculatorCP.Commands
{
    public class ChangePearlVersion : ICommand
    {
        public void Execute(string[]? parameters, string? cmdName, Action<ConsoleOutputItemModel> messageSender)
        {
            if(parameters != null && parameters.Length != 0)
            {
                try
                {
                    PearlEntity.BehaviorVersion version = Enum.Parse<PearlEntity.BehaviorVersion>(parameters[0]);
                    MainWindowViewModel.PearlVersion = version;
                    messageSender(DefineCmdOutput.MsgTemplate($"Change Max Ticks to {version}"));
                }
                catch (Exception ex)
                {
                    messageSender(DefineCmdOutput.ErrorTemplate("Value Incorrect"));
                }
            }
            else
                messageSender(DefineCmdOutput.ErrorTemplate("Missing Value"));
        }
    }
}
