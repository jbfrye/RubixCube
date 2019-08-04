using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubixCube
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Cube cube = new Cube();
            cube.Rotate(1, 2, Side.Top, Direction.Up);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
