using AutoMapper;
using Hospital.Services;
using System;
using System.Windows.Forms;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Mapper.Initialize(c => c.AddProfile(new MapperConfig()));

            //Application.Run(new LoginForm());
            Application.Run(new InstitutionsForm());
        }
    }
}
