﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeftyBotGui
{
    public static class Helpers
    {

        private static ConsoleControl.ConsoleControl _con = (ConsoleControl.ConsoleControl)(Application.OpenForms[0].Controls.Find("consoleControl1", false)[0]);

        public static ConsoleControl.ConsoleControl ConsoleControl { get {
                return _con;
            } }

        public static int GetAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dateOfBirth.Year;
            return age;
        }

        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}