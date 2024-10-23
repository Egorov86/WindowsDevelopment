using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Linq.Expressions;

namespace Clock
{
    public partial class ChooseFont : Form
    {
        public Font ChosenFont { get; private set; }
        public string FontFile { get; private set; }
        public ChooseFont()
        {
            InitializeComponent();
            LoadFonts();
        }
        public ChooseFont(string fontFile):this()
        {
            SetFontFile(fontFile);
        }
        public Font SetFontFile(string fontFile)
        {
            FontFile = fontFile;
            comboBoxFonts.SelectedIndex = comboBoxFonts.Items.IndexOf(fontFile);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFile);
            return new Font(pfc.Families[0], 36);
        }
        void LoadFonts()
        {
            //1) Получаем список всех файлов в текущем каталоге и сохраняем этот список в массив "fonts" 
            string[] fonts = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.ttf").ToArray();
            //2) поскольку в массиве хранятся полные пусти к файлам убираем пути и оставляем только имена получ файлов
            for (int i = 0; i < fonts.Length; i++)
            {
                fonts[i] = fonts[i].Split('\\').Last();
            }
            //3) Загружаем весь массив файлов в ComboBox
            comboBoxFonts.Items.AddRange(fonts);
            comboBoxFonts.SelectedIndex = 0;
        }

        private void comboBoxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            //string fontFile = $"{Directory.GetCurrentDirectory()}\\{comboBoxFonts.SelectedItem.ToString()}";
            FontFile = $"{Directory.GetCurrentDirectory()}\\{comboBoxFonts.SelectedItem.ToString()}";
            //MessageBox.Show(fontFile);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFile);
            Font font = new Font(pfc.Families[0], 36);
            //comboBoxFonts.Font = font;
            labelExample.Font = font;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChosenFont = new Font(labelExample.Font.FontFamily, labelExample.Font.Size);
        }
    }
}
