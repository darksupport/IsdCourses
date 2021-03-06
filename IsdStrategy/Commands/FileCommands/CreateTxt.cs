﻿using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy.Commands.FileCommands
{
    class CreateTxt : ICommand
    {
        public void Command(string path, string param = null)
        {
            if (!File.Exists(param + path + ".txt"))
            File.Create(param + path + ".txt").Dispose(); //нужен Dispose, т.к. после создания файл занят
            Console.WriteLine("\n\nCreating in {0} file {1} ok!\n\n", path, param + path + ".txt");
        }
    }
}
