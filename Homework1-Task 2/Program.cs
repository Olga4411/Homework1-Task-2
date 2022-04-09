using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1_Task_2
{
    static class Program
    {
        static DialogResult ShowMessageBoxes()
        {
            string message = "Текст сообщения";
            MessageBox.Show(message);
            string _caption = "Заголовок сообщения";

            message = "Текст сообщения ДА НЕТ";
            //string _caption = "Заголовок сообщения";

            DialogResult result = result = MessageBox.Show(message, _caption, MessageBoxButtons.YesNo);
            string _button = result.ToString();

            message = "Текст сообщения";
            MessageBox.Show(message);


            //result = result = MessageBox.Show("Вы нажали кнопку" + _button +"Повторить?", _button, MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);

            return result;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            DialogResult result;
            do
            {
                result = ShowMessageBoxes();
            } while (result == DialogResult.Retry);

          
        }
    }
}
