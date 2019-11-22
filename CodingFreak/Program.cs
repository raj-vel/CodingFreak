using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingFreak
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

            //Application.Run(new LinkedList());
            // Application.Run(new BinaryTree());
            //Application.Run(new String())
            //Application.Run(new Array());

            Application.Run(new DynamicProgramming());

            // Application.Run(new xDailyCodingProblem_Easy());
            // Application.Run(new xDailyCodingProblem_Medium());
            // Application.Run(new xDailyCodingProblem_Hard());
        }
    }
}
