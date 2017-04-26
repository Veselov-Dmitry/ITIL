using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using S4;

namespace ITIL
{
    static class Program
    {
        /// <summary>
        /// Объект Search
        /// </summary>
        public static TS4App S4App;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Work testau=new Work();

            // Проверка факта запуска нужных процессов
           testau.CheckProc();
            // Первоначальаная инициализация объекта Search
            
            testau.ComSearch();
            testau.test = new Form1( );
       
                    Application.Run(testau.test);
        }
    }
}
