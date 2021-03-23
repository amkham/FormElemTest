using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElemTest
{
    static public class RichBoxEvents
    {

        // target - целевое слово для замены
        // fileLocation - путь к файлу на диске
        // color - цвет 
        // start - начальная позиция поиска
        static public void FindAndChangeColor(string target, string fileLocation, Color color, int start)
        {
            RichTextBox textBox = new RichTextBox();
            textBox.LoadFile(fileLocation);
            int newPosition = textBox.Find(target, start + target.Length, RichTextBoxFinds.MatchCase);
            textBox.SelectionColor = color;
            textBox.SaveFile(fileLocation, RichTextBoxStreamType.RichText);

            if (newPosition != -1)
            {
                FindAndChangeColor(target, fileLocation, color, newPosition);

            }
        }


        // start, end - границы поиска
        public static void FindAndChangeColor(string target, string fileLocation, Color color, int start, int end)
        {
            
        }


        // sample - замена 
        public static void FindAndChangeWord(string target, string sample, string fileLocation, int start, int end)
        {

        }
    }
}
